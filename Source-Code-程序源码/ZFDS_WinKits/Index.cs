using AutoUpdaterDotNET;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace XCLWinKits
{
    public partial class Index : DevExpress.XtraEditors.XtraForm
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        private void InitData()
        {
            // 检查更新 delete by hwg
            //AutoUpdater.Start(@"http://soft.wodeabc.com/XCLWinKits/update.xml");

            #region 生成按钮

            foreach (var m in CommonHelper.ConfigHelper.Config.CategoryConfig.CategoryList)
            {
                var tab = new DevExpress.XtraTab.XtraTabPage();
                tab.Text = m.Name;
                FlowLayoutPanel flowPanel = new FlowLayoutPanel();
                flowPanel.Dock = DockStyle.Fill;
                if (null != m.CategoryItemList && m.CategoryItemList.Count > 0)
                {
                    for (int k = 0; k < m.CategoryItemList.Count; k++)
                    {
                        var model = m.CategoryItemList[k];
                        var bt = new DevExpress.XtraEditors.SimpleButton();
                        bt.Name = model.AssemblyName;
                        bt.Text = model.Name;
                        bt.AutoSize = true;
                        bt.Height = 40;
                        bt.Width = 180;
                        bt.Margin = new System.Windows.Forms.Padding(10);
                        bt.Padding = new System.Windows.Forms.Padding(5);
                        bt.Click += new EventHandler(bt_Click);
                        bt.Cursor = Cursors.Hand;
                        flowPanel.Controls.Add(bt);
                    }
                }
                tab.Controls.Add(flowPanel);
                this.tabMenu.TabPages.Add(tab);
            }

            #endregion 生成按钮

            //链接后期可以更改成逐浪的数据统计链接
            #region 生成用于统计用户访问的web控件

            var wb = new WebBrowser();
            wb.Url = new Uri("https://www.z01.com");
            wb.ScriptErrorsSuppressed = true;

            #endregion 生成用于统计用户访问的web控件
        }

        #region button事件

        private void bt_Click(object sender, EventArgs e)
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.GetType().Namespace == "XCLNetFileReplace")
                {
                    fm.Activate();
                    return;
                }
            }

            var bt = (DevExpress.XtraEditors.SimpleButton)sender;
            try
            {
                try
                {
                    Form form = Assembly.Load(bt.Name).CreateInstance(string.Format("{0}.Index", bt.Name)) as System.Windows.Forms.Form;
                    form.Show();
                }
                catch
                {
                    Form form = Assembly.Load(Application.StartupPath + @"\XCLWinKits.exe").CreateInstance(string.Format("{0}.Index", bt.Name)) as System.Windows.Forms.Form;
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("打开失败，程序集{0}.Index还未开发完成！{1}（{2}）", bt.Name, Environment.NewLine, ex.Message), "系统提示");
                CommonHelper.Common.WriteLog(ex);
            }
        }

        #endregion button事件

        #region 菜单

        // 链接最好是改成逐浪的官方链接 edit by hwg 2020年7月1日 15点54分
        private void 检查更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CommonHelper.ConfigHelper.OpenUrl("https://github.com/xucongli1989/XCLWinKits");
            CommonHelper.ConfigHelper.OpenUrl("http://ico.z01.com");
        }

        private void 正则表达式语法简明参考ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl(string.Format(@"{0}\Res\RegexFiles\regex0.html", Application.StartupPath.TrimEnd('\\')));
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 我的ABCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("https://www.z01.com");
        }

        private void GitHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("https://github.com/zoomla");
        }

        private void 捐助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("http://www.z01.com");
        }

        #endregion 菜单

        private void Index_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }


        private void barButtonItem10_ItemClick(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("http://www.ziti163.com/webfont");

        }

        private void 高端字库_ItemClick(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("http://f.ziti163.com");
        }

        private void barButtonItem4_ItemClick(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("http://ico.z01.com");

        }

        private void barButtonItem2_ItemClick(object sender, EventArgs e)
        {
            CommonHelper.ConfigHelper.OpenUrl("http://www.ziti163.com/uni");

        }

    }
}