using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using DB2ExcelDX.Common.Excel;
using System.Runtime.InteropServices;
using System.Globalization;
using System.IO;
using System.Net;
using System.Xml;

namespace DB2ExcelDX
{
    public partial class Index : BaseForm.BaseFormClass
    {
        #region internal variables ,defined by hwg
        private SqlConnection con;
        private int totalCount;
        /// <summary>
        /// program running path
        /// </summary>
        private string currentPath;
        /// <summary>
        /// config file name
        /// </summary>
        private string confFileName;
        /// <summary>
        /// export base path
        /// </summary>
        private string exportPath;
        private Config config;
        List<Config> cs;
        /// <summary>
        /// the path of export
        /// </summary>
        private string savePath;
        #endregion
        

        /*bool init;
        IntPtr hwnd;
        [DllImport("user32")]
        private static extern int GetComboBoxInfo(IntPtr hwnd, out COMBOBOXINFO comboInfo);*/

        public Index()
        {
            totalCount = 0;
            currentPath = System.Environment.CurrentDirectory;
            confFileName = "DB2Excel.dat";
            exportPath = "D:\\数据导出\\";
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            loadConfig();
            InitSavedScript();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            //InitSavedScript();
        }
        
        protected override void OnClosed(EventArgs e)
        {
            if (this.con != null)
            {
                try
                {
                    con.Close();
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
            base.OnClosed(e);
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        #region load config file
        public void loadConfig(bool auto = true)
        {
            string filePath = currentPath + "\\" + confFileName;
            string url = Config.getUrl(filePath);
            this.checkUpdate(url,auto);
            savePath = exportPath + "\\" + DateTime.Now.ToString("yyyy-MM-dd", DateTimeFormatInfo.InvariantInfo);
            string path = Config.getSavePath(currentPath + "\\" + confFileName);
            if (!"default".Equals(path))
                savePath = path;
            this.savePathLabel.Text = savePath + "   点击更改";
        }


        #endregion

        #region check update and config
        private void checkUpdate(string url = "", Boolean auto = true)
        {
            #region get latest config from url
            StringBuilder sb = new StringBuilder();
            if (url.Length <= 0&&!auto)
            {
                Interaction.MsgBox("无效的url地址", MsgBoxStyle.OkOnly, "提示");
                return;
            }
            try
            {
                //HttpWebRequest rq = HttpWebRequest.CreateHttp("https://code.z01.com/4.0/examples/DB2Excel.txt");
                HttpWebRequest rq = HttpWebRequest.CreateHttp(url);
                rq.Method = "get";
                rq.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36 SE 2.X MetaSr 1.0";
                HttpWebResponse res = (HttpWebResponse)rq.GetResponse();
                Stream stream = res.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream, System.Text.Encoding.GetEncoding("utf-8"));
                string temp = "";
                while ((temp = streamReader.ReadLine()) != null)
                {
                    sb.Append(temp);
                }
                stream.Close();
                streamReader.Close();
            }catch(Exception x)
            {
                if (x.Message.Contains("404"))
                {
                    if(!auto)
                        MessageBox.Show("没有发现云端配置文件!","提示",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("请检查网络连接,如已连接,请忽略","提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                return;
            }
            #endregion

            #region parse xml
            try
            {
                Config.parseNetConfig(sb.ToString(), currentPath + "\\" + confFileName,auto);
                this.InitSavedScript();
            }catch(Exception x)
            {
                MessageBox.Show("合并过程中出现了错误,请重试\r\n" + x.Message);
            }
            
            #endregion
        }

        #endregion

        #region initialize the srcript list , read from config file
        private void InitSavedScript()
        {
            /*scriptList.HandleCreated += (s, e) =>
            {
                COMBOBOXINFO combo = new COMBOBOXINFO();
                combo.cbSize = Marshal.SizeOf(combo);
                GetComboBoxInfo(scriptList.Handle, out combo);
                hwnd = combo.hwndList;
                init = false;
            };*/
            cs = Config.ReadDoc(currentPath + "\\" + confFileName);
            List<string> names = new List<string>();
            //this.scriptList.Items.Add("--共 " + cs.Count + " 条--");
            names.Add("--共 " + cs.Count + " 进程--");
            foreach (Config c in cs)
            {
                names.Add(c.Script.Name);
                //this.scriptList.Items.Add(c.Name);
            }
            this.scriptList.DataSource = names;

            this.tabPage1.Parent = null;
            this.tabPage2.Parent = null;
            this.tabPage3.Parent = this.stepControl;
        }
        #endregion

        #region connert test,if success,bind the database data to dblist

        private void btnConnectTest_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(DBUtils.GetConnetionString(this.ipBox.Text.Trim(),
                    this.userBox.Text.Trim(),
                    this.pwdBox.Text.Trim()));
                con.Open();
                string sql = @"Select   name   from   master..sysdatabases where   name   not   in('master','model','msdb','tempdb','northwind','pubs')";
                var dt = DBUtils.execSql(con, sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    if (!this.dbList.Enabled)
                        this.dbList.Enabled = true;
                    this.dbList.DataSource = null;
                    this.dbList.Items.Clear();
                    this.dbList.DataSource = dt.AsEnumerable().Select(r => r["name"].ToString()).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据源配置出错,请检查\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region load the script by name
        private void btnLoadScript_Click(object sender, EventArgs e)
        {
            string selectedScriptName = this.scriptList.SelectedItem.ToString();
            if (this.scriptList.SelectedIndex <= 0)
            {
                return;
            }
            foreach (Config c in cs)
            {
                if (selectedScriptName.Equals(c.Script.Name))
                {
                    config = new Config(new Scripts(c.Script.Dbid,c.Script.Name,c.Script.Sql,c.Script.Db),
                        new DataSource(c.DataSource.Id,c.DataSource.Ip,c.DataSource.User,c.DataSource.Pwd));
                    break;
                }
            }
            /*this.ipBox.Text = config.Ip;
            this.userBox.Text = config.User;
            this.dbList.SelectedItem = config.Db;
            this.pwdBox.Text = config.Pwd;
            this.sqlBox.Text = config.Sql;*/
            /*btnConnectTest_Click(sender, e);
            btnSqlTest_Click(sender, e);*/
            loadColumns();
        }
        #endregion

        #region script test.if available ,show the total Count
        private void btnSqlTest_Click(object sender, EventArgs e)
        {
            string db = this.dbList.SelectedItem.ToString();
            con.ChangeDatabase(db);
            string sql = "SELECT count( * ) as count  FROM (" + this.sqlBox.Text.Trim() + ") as temp";
            try
            {
                var dt = DBUtils.execSql(con, sql);
                totalCount = Convert.ToInt32(dt.Rows[0]["count"]);
                MessageBox.Show("当前脚本共有" + totalCount + "条数据", "提示", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("您的脚本语句有语法错误,具体如下\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region save script . if the name was existed ,try another
        private void btnSaveScript_Click(object sender, EventArgs e)
        {
            try
            {
                DataSource ds = new DataSource(this.ipBox.Text.Trim(), this.userBox.Text.Trim(), this.pwdBox.Text.Trim());
                //get a new name
                string confName = Interaction.InputBox("脚本名称", "请输入");
                if (confName.Length == 0)
                {
                    MessageBox.Show("没有输入,无效操作");
                    return;
                }
                else
                {
                    foreach(Config c in cs)
                    {
                        if (c.Script.Name.Equals(confName))
                        {

                            MessageBox.Show("名称重复!");
                            return;
                        }
                    }
                }
                Scripts s = new Scripts(confName, this.sqlBox.Text.Trim(), this.dbList.SelectedItem.ToString());
                config = new Config(s,ds);
                Config.saveScript(config, currentPath, confFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region designed for debug ,do not care ,it'll disappear automatically in the produce environment
        private void button1_Click(object sender, EventArgs e)
        {
            InitSavedScript();
        }
        #endregion

        #region load the columns  then bind to DataGridView.DataSource
        private void loadColumns()
        {
            /*if (totalCount == 0)
            {
                MessageBox.Show("请先设置脚本!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }*/

            #region try to set connettion
            try
            {
                if (con != null)
                {
                    con.Close();
                }
                con = new SqlConnection(DBUtils.GetConnetionString(config.DataSource.Ip, config.DataSource.User, config.DataSource.Pwd, config.Script.Db));
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("该脚本已不可用,请重新自定义或联系逐浪官方\r\n" + ex.Message,
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region check connection and query columns
            if (con.State != ConnectionState.Open)
            {
                MessageBox.Show("连接未打开!\r\n请重新测试脚本 或 重新加载", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //从数据库获取列名
            string sql = "select top 0 * from (" + config.Script.Sql + ") as temp";
            DataTable dt;
            try
            {
                dt = DBUtils.execSql(con, sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("您的脚本语句有语法错误,具体如下\r\n" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region try to parse the data from server then bind to DataGridView
            this.dataFormatTable.Rows.Clear();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                DataGridViewRow r = new DataGridViewRow();
                DataGridViewCheckBoxCell stateCheckBox = new DataGridViewCheckBoxCell();
                stateCheckBox.Value = true;
                DataGridViewComboBoxCell typeComboList = new DataGridViewComboBoxCell();
                typeComboList.Items.Add("普通文本");
                typeComboList.Items.Add("日期");
                typeComboList.Items.Add("日期和时间");
                typeComboList.Items.Add("真假");
                typeComboList.Items.Add("整型");
                typeComboList.Items.Add("浮点型");
                typeComboList.Items.Add("超链接");
                typeComboList.Items.Add("其他");
                typeComboList.Items.Add("小数型");
                DBType dBType = (DBType)Enum.Parse(typeof(DBType), (dt.Columns[i].DataType).ToString().Split('.')[1]);
                typeComboList.Value = ((ComboName)((int)dBType)).ToString();
                DataGridViewTextBoxCell nameBox = new DataGridViewTextBoxCell();
                nameBox.Value = dt.Columns[i].ColumnName;
                DataGridViewTextBoxCell widthBox = new DataGridViewTextBoxCell();
                widthBox.Value = 10;
                DataGridViewTextBoxCell hideColumnName = new DataGridViewTextBoxCell();
                hideColumnName.Value = dt.Columns[i].ColumnName;
                r.Cells.Add(stateCheckBox);
                r.Cells.Add(nameBox);
                r.Cells.Add(typeComboList);
                r.Cells.Add(widthBox);
                r.Cells.Add(hideColumnName);
                this.dataFormatTable.Rows.Add(r);
            }
            #endregion

            #region step control
            this.tabPage2.Parent = this.stepControl;
            this.tabPage1.Parent = null;
            this.tabPage3.Parent = null;

            

            #endregion
        }
        #endregion

        #region back to script list tab , from data format set tab
        private void button2_Click(object sender, EventArgs e)
        {
            this.tabPage1.Parent = null;
            this.tabPage2.Parent = null;
            this.tabPage3.Parent = this.stepControl;
        }
        #endregion

        #region export to excel
        private void btnExport_Click(object sender, EventArgs e)
        {
            #region collect the format of columns
            Collection c = new Collection();
            foreach (DataGridViewRow item in this.dataFormatTable.Rows)
            {
                if (Boolean.Parse(item.Cells[0].Value.ToString()))
                    c.Add(item);
            }
            #endregion 
            #region get query sql string
            StringBuilder sb = new StringBuilder("select ");
            if (c.Count < 1)
            {
                MessageBox.Show("至少要选择一列");
                return;
            }
            foreach (DataGridViewRow item in c)
            {
                sb.Append(item.Cells[4].Value + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append(" from (" + config.Script.Sql + ") as temp");
            string sql = sb.ToString();
            /*MessageBox.Show(sql);
            return;*/
            #endregion
            #region make sure that the user have checkd all and check the connection
            int result = (int)Interaction.MsgBox("确定要导出吗?", MsgBoxStyle.OkCancel, "提示");
            if (result != 1)
                return;
            if (con.State != ConnectionState.Open)
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接建立失败!\r\n" + ex.Message,
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion
            #region execute the sql
            DataTable rdt;
            try
            {
                rdt = DBUtils.execSql(con, sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据查询失败!\r\n" + ex.Message,
                        "提示",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region parse data from server
            var columns = new List<Common.Excel.Column>();
            foreach (DataGridViewRow item in c)
            {
                columns.Add(new Common.Excel.Column(item.Cells[4].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    (ColumnDataType)((ComboName)(Enum.Parse(typeof(ComboName), item.Cells[2].Value.ToString()))),
                    int.Parse(item.Cells[3].Value.ToString())));
            }
            #endregion
            #region [Old Version]export to excel file
            /*var fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fileDialog.Filter = "Excel文档(*.xls)|*xls";
            fileDialog.RestoreDirectory = true;
            fileDialog.FileName = config.Name+DateTime.Now.ToString("HH-mm-ss", DateTimeFormatInfo.InvariantInfo)+".xls";
            var rel = fileDialog.ShowDialog();
            if (rel == DialogResult.OK)
            {
                string localFilePath = fileDialog.FileName;
                using (var workbook = new Common.Excel.Workbook())
                {
                    var sheet = new Common.Excel.Sheet("数据", columns, rdt);
                    workbook.CreateSheet(sheet);

                    using (var ms = workbook.GetMemoryStream())
                    {
                        var fs = new System.IO.FileStream(localFilePath, System.IO.FileMode.Create);
                        byte[] buff = ms.ToArray();
                        fs.Write(buff, 0, buff.Length);
                        fs.Flush();
                        fs.Close();
                    }
                }

                MessageBox.Show("保存成功。");

            }*/
            #endregion

            #region [New Version]export to excel file
            //check if the directory exist
            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);
            string FileName = config.Script.Name + DateTime.Now.ToString("HH-mm-ss", DateTimeFormatInfo.InvariantInfo) + ".xlsx";
            try
            {
                using (var workbook = new Common.Excel.Workbook())
                {
                    var sheet = new Common.Excel.Sheet("数据", columns, rdt);
                    workbook.CreateSheet(sheet);

                    using (var ms = workbook.GetMemoryStream())
                    {
                        var fs = new System.IO.FileStream(savePath + "\\" + FileName, System.IO.FileMode.Create);
                        byte[] buff = ms.ToArray();
                        fs.Write(buff, 0, buff.Length);
                        fs.Flush();
                        fs.Close();
                    }
                }
                MessageBox.Show("导出文件成功\r\n" + "文件路径:" + savePath + "\\" + FileName,
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }catch(Exception ex)
            {
                MessageBox.Show("文件导出失败\r\n"+ex.Message,
                    "提示",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            #endregion
        }
        #endregion

        #region table click response function
        private void dataFormatTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("RowIndex:" + e.RowIndex + "\r\nColIndex:" + e.ColumnIndex);
            if (e.ColumnIndex == 0)
            {
                this.dataFormatTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    !bool.Parse(this.dataFormatTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                this.dataFormatTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;

                this.dataFormatTable.EndEdit();
            }

        }
        #endregion

        #region enter the user-defined tab
        private void button3_Click(object sender, EventArgs e)
        {
            this.tabPage1.Parent = this.stepControl;
            this.tabPage2.Parent = null;
            this.tabPage3.Parent = null;
        }
        #endregion

        #region back to script list tab
        private void btnNextStep_Click(object sender, EventArgs e)
        {
            InitSavedScript();
        }
        #endregion

        #region delete script
        private void label9_Click(object sender, EventArgs e)
        {
            string selectedScriptName = this.scriptList.SelectedItem.ToString();
            if (this.scriptList.SelectedIndex <= 0)
            {
                return;
            }
            MsgBoxResult result = Interaction.MsgBox("确定删除此进程吗?", MsgBoxStyle.OkCancel, "提示");
            if (result != MsgBoxResult.Ok)
            {
                return;
            }
            else
            {
                try
                {
                    Config.deleteConfigByName(selectedScriptName, currentPath + "\\" + confFileName);

                    MessageBox.Show("删除成功", "提示",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    InitSavedScript();
                }
                catch(Exception x)
                {
                    MessageBox.Show("删除过程中出现了错误,建议重新启动程序\r\n" + x.Message+"\r\n"+x.StackTrace, "警告",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

        #endregion

        private void label11_Click(object sender, EventArgs e)
        {
            string url = Interaction.InputBox("请输入网络数据源地址:", "提示",
                "http://");
            int re = Config.saveUrl(currentPath + "\\" + confFileName, url);
            if (re == 1)
            {
                this.loadConfig(false);
            }
            else
            {
                MessageBox.Show("配置文件不存在,请重新启动", "提示",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description=("请选择导出的文件夹");
            if (!(dialog.ShowDialog() == DialogResult.OK || dialog.ShowDialog() == DialogResult.Yes))
            {
                return;
            }
            else
            {
                string newPath = dialog.SelectedPath;
                this.savePathLabel.Text = newPath + "   点击更改";
                Config.saveSavePath(currentPath + "\\" + confFileName, newPath);
                savePath = newPath;
            }
        }
    }
}
