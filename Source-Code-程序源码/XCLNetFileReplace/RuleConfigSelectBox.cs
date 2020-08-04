using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using XCLNetTools.Generic;

namespace XCLNetFileReplace
{
    public partial class RuleConfigSelectBox : BaseForm.BaseFormClass
    {
        private DataLayer.BLL.FileReplace_RuleConfig bll = new DataLayer.BLL.FileReplace_RuleConfig();
        private DataLayer.BLL.v_FileReplace_RuleConfig vbll = new DataLayer.BLL.v_FileReplace_RuleConfig();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private DataLayer.Model.FileReplaceSetting fileReplaceSetting = null;
        private static Index _mainForm = null;

        public RuleConfigSelectBox(Index mainForm = null)
        {
            _mainForm = mainForm;
            InitializeComponent();
            this.InitRuleConfigGrid();
            this.ckIsFileName.Checked = true;
            this.tabPageAdd.PageVisible = false;
            this.fileReplaceSetting = userSettingBLL.GetFileReplaceSetting();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //默认选中项
            this.dataGridRuleConfig.ClearSelection();
            if (null != fileReplaceSetting && null != fileReplaceSetting.RuleConfigIds && fileReplaceSetting.RuleConfigIds.Count > 0)
            {
                for (int i = 0; i < this.dataGridRuleConfig.RowCount; i++)
                {
                    var currentModel = this.dataGridRuleConfig.GetDataRow(i);
                    if (fileReplaceSetting.RuleConfigIds.Contains(XCLNetTools.Common.DataTypeConvert.ToInt(currentModel["RuleConfigID"])))
                    {
                        this.dataGridRuleConfig.SelectRow(i);
                    }
                }
            }
        }

        #region 规则选择TabPage

        /// <summary>
        /// 初始化规则grid
        /// </summary>
        public void InitRuleConfigGrid()
        {
            this.dataGridRuleConfig.GridControl.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(this.vbll.GetAllList());
        }

        /// <summary>
        /// 选好了
        /// </summary>
        private void btnSelectOK_Click(object sender, System.EventArgs e)
        {
            var model = userSettingBLL.GetFirstModel();
            if (null == model)
            {
                model = new DataLayer.Model.UserSetting();
            }
            DataLayer.Model.FileReplaceSetting setting = null;
            if (!string.IsNullOrEmpty(model.FileReplaceSetting))
            {
                setting = XCLNetTools.Serialize.JSON.DeSerialize<DataLayer.Model.FileReplaceSetting>(model.FileReplaceSetting);
            }
            if (null == setting)
            {
                setting = new DataLayer.Model.FileReplaceSetting();
            }
            //获取已选行
            setting.RuleConfigIds = new List<int>();
            var selectedRows = this.dataGridRuleConfig.GetSelectedRows();
            if (null != selectedRows && selectedRows.Length > 0)
            {
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    var currentData = this.dataGridRuleConfig.GetDataRow(selectedRows[i]);
                    if (null != currentData)
                    {
                        setting.RuleConfigIds.Add(XCLNetTools.Common.DataTypeConvert.ToInt(currentData["RuleConfigID"]));
                    }
                }
            }
            model.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(setting);
            userSettingBLL.Add(model);
            this.Close();
        }

        /// <summary>
        /// 全不选
        /// </summary>
        private void btnSelectNone_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.ClearSelection();
        }

        /// <summary>
        /// 反选
        /// </summary>
        private void btnSelectInverse_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < this.dataGridRuleConfig.RowCount; i++)
            {
                if (this.dataGridRuleConfig.IsRowSelected(i))
                {
                    this.dataGridRuleConfig.UnselectRow(i);
                }
                else
                {
                    this.dataGridRuleConfig.SelectRow(i);
                }
            }
        }

        /// <summary>
        /// 全选
        /// </summary>
        private void btnSelectAll_Click(object sender, System.EventArgs e)
        {
            this.dataGridRuleConfig.SelectAll();
        }

        /// <summary>
        /// 添加规则
        /// </summary>
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            this.InitDataByRuleId(0);
            this.tabPageAdd.Text = "添加规则";
            this.tabPageAdd.PageVisible = true;
            this.tabRuleConfig.SelectedPage = this.tabPageAdd;
        }

        /// <summary>
        /// 修改规则
        /// </summary>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            var selectedRows = this.dataGridRuleConfig.GetSelectedRows();
            if (null == selectedRows || selectedRows.Length != 1)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选择一条规则进行修改！", "系统提示");
                return;
            }
            this.InitDataByRuleId(XCLNetTools.Common.DataTypeConvert.ToInt(this.dataGridRuleConfig.GetRowCellValue(selectedRows[0], "RuleConfigID")));

            this.tabPageAdd.Text = "修改规则";
            this.tabPageAdd.PageVisible = true;
            this.tabRuleConfig.SelectedPage = this.tabPageAdd;
        }

        /// <summary>
        /// 删除规则
        /// </summary>
        private void btnDel_Click(object sender, System.EventArgs e)
        {
            List<int> ids = new List<int>();
            var selectedRows = this.dataGridRuleConfig.GetSelectedRows();
            if (null == selectedRows || selectedRows.Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请至少选择一条规则进行删除！", "系统提示");
                return;
            }

            if (DevExpress.XtraEditors.XtraMessageBox.Show("您确定要删除这些规则？", "系统提示", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            for (var i = 0; i < selectedRows.Length; i++)
            {
                var id = XCLNetTools.Common.DataTypeConvert.ToInt(this.dataGridRuleConfig.GetRowCellValue(selectedRows[i], "RuleConfigID"));
                bll.Delete(id);
                ids.Add(id);
            }

            this.InitRuleConfigGrid();
        }

        /// <summary>
        /// 导出规则
        /// </summary>
        private void btnRuleOutput_Click(object sender, EventArgs e)
        {
            var lst = this.vbll.GetAllList();
            if (lst.IsNullOrEmpty())
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("没有任何规则数据需要导出！", "系统提示");
                return;
            }
            var path = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), string.Format("规则信息{0:yyyyMMddHHmmssfff}.xlsx", DateTime.Now));
            var ds = XCLNetTools.DataSource.DataTableHelper.ToDataSet(lst);
            XCLNetTools.Office.ExcelHandler.DataToExcel.OutPutExcel(new XCLNetTools.Entity.Office.ExcelHandler.OutPutParamClass()
            {
                AutoDownLoad = false,
                ConTitle = new string[] { "规则信息" },
                CustomFileName = path,
                Ds = ds,
                OutPutClass = new List<XCLNetTools.Entity.Office.ExcelHandler.OutPutClass>() {
                    new XCLNetTools.Entity.Office.ExcelHandler.OutPutClass(){
                        Fields=new List<XCLNetTools.Entity.Office.ExcelHandler.OutPutField>(){
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="Name",
                                newName="名称"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="OldContent",
                                newName="查找内容"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="NewContent",
                                newName="替换内容"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="IsRegex_Text",
                                newName="是否为正则表达式"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="IsIgnoreCase_Text",
                                newName="是否忽略大小写"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="IsWholeMatch_Text",
                                newName="是否整字匹配"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="IsFileName_Text",
                                newName="是否匹配文件名"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="IsFileContent_Text",
                                newName="是否匹配文件内容"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="CreateTime",
                                newName="创建时间"
                            },
                            new XCLNetTools.Entity.Office.ExcelHandler.OutPutField(){
                                oldName="UpdateTime",
                                newName="更新时间"
                            }
                        },
                        TableName="规则信息字段"
                    }
                },
                TableName = new string[] { "规则信息字段" }
            });
            DevExpress.XtraEditors.XtraMessageBox.Show("导出成功：" + path, "系统提示");
        }

        /// <summary>
        /// 导入规则
        /// </summary>
        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel文件|*.xls;*.xlsx";
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            try
            {
                var dt = XCLNetTools.Office.ExcelHandler.ExcelToData.ReadExcelToTable(openFile.FileNames[0]);
                var nameColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "名称");
                var oldContentColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "查找内容");
                var newContentColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "替换内容");
                var isRegexColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "是否为正则表达式");
                var isIgnoreCaseColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "是否忽略大小写");
                var isWholeMatchColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "是否整字匹配");
                var isFileNameColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "是否匹配文件名");
                var isFileContentColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "是否匹配文件内容");
                var createTimeColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "创建时间");
                var updateTimeColIndex = XCLNetTools.DataSource.DataTableHelper.GetColIndex(dt, 1, "更新时间");

                if (nameColIndex == -1 || oldContentColIndex == -1 || newContentColIndex == -1 || isRegexColIndex == -1 || isIgnoreCaseColIndex == -1 || isWholeMatchColIndex == -1 || isFileNameColIndex == -1 || isFileContentColIndex == -1 || createTimeColIndex == -1 || updateTimeColIndex == -1)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("准备导入的文件模板缺少相关列，请确保模板是正确的（您可以将导出的Excel文件作为模板）！", "系统提示");
                    return;
                }

                if (dt.Rows.Count <= 2)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("没有任务数据需要导入！", "系统提示");
                    return;
                }

                var dtNow = DateTime.Now;
                var msg = new List<string>();
                var lst = new List<DataLayer.Model.FileReplace_RuleConfig>();

                for (var i = 2; i < dt.Rows.Count; i++)
                {
                    var dr = dt.Rows[i];
                    var model = new DataLayer.Model.FileReplace_RuleConfig();
                    model.Name = (dr[nameColIndex] ?? "").ToString().Trim();
                    model.OldContent = dr[oldContentColIndex].ToString();
                    model.NewContent = dr[newContentColIndex].ToString();
                    model.IsRegex = dr[isRegexColIndex].ToString() == "是";
                    model.IsIgnoreCase = dr[isIgnoreCaseColIndex].ToString() == "是";
                    model.IsWholeMatch = dr[isWholeMatchColIndex].ToString() == "是";
                    model.IsFileName = dr[isFileNameColIndex].ToString() == "是";
                    model.IsFileContent = dr[isFileContentColIndex].ToString() == "是";
                    model.CreateTime = XCLNetTools.Common.DataTypeConvert.ToDateTime(dr[createTimeColIndex].ToString(), dtNow);
                    model.UpdateTime = XCLNetTools.Common.DataTypeConvert.ToDateTime(dr[updateTimeColIndex].ToString(), dtNow);

                    if (string.IsNullOrWhiteSpace(model.Name))
                    {
                        msg.Add(string.Format("第{0}行中的【名称】必填！", (i + 1).ToString()));
                        break;
                    }

                    if (string.IsNullOrEmpty(model.OldContent))
                    {
                        msg.Add(string.Format("第{0}行中的【查找内容】必填！", (i + 1).ToString()));
                        break;
                    }

                    lst.Add(model);
                }

                if (msg.Count > 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Join(System.Environment.NewLine, msg.ToArray()), "系统提示");
                    return;
                }

                if (lst.Count > 0)
                {
                    this.bll.Add(lst);
                    this.InitRuleConfigGrid();
                    DevExpress.XtraEditors.XtraMessageBox.Show(string.Format("您已成功导入{0}条规则！", lst.Count.ToString()), "系统提示");
                    return;
                }
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("系统错误，请重新选择有效的文件！", "系统提示");
            }
        }

        #endregion 规则选择TabPage

        #region 添加或修改规则TabPage

        /// <summary>
        /// 保存
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ruleId = XCLNetTools.Common.DataTypeConvert.ToInt(this.txtRuleID.Text.Trim());
            DataLayer.Model.FileReplace_RuleConfig model = new DataLayer.Model.FileReplace_RuleConfig();
            model.CreateTime = model.UpdateTime = DateTime.Now;
            model.IsFileContent = this.ckIsFileContent.Checked;
            model.IsFileName = this.ckIsFileName.Checked;
            model.IsIgnoreCase = this.ckIsIgnoreCase.Checked;
            model.IsRegex = this.ckIsRegex.Checked;
            model.IsWholeMatch = this.ckIsWholeMatch.Checked;
            model.Name = this.txtRuleName.Text.Trim();
            model.NewContent = this.txtNewContent.Text.Trim();
            model.OldContent = this.txtOldContent.Text.Trim();

            if (string.IsNullOrEmpty(model.Name))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入规则名！", "系统提示");
                return;
            }

            if (string.IsNullOrEmpty(model.OldContent))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入要查找的内容！", "系统提示");
                return;
            }

            if (ruleId > 0 && bll.IsExist(ruleId))
            {
                model.RuleConfigID = ruleId;
                bll.Update(model);
            }
            else
            {
                bll.Add(model);
            }

            this.InitRuleConfigGrid();
            this.tabPageAdd.PageVisible = false;
            this.tabRuleConfig.SelectedPage = this.tabPageSelectRule;
        }

        /// <summary>
        /// 选择【是否为正则】
        /// </summary>
        private void ckIsRegex_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【是否整字匹配】
        /// </summary>
        private void ckIsWholeMatch_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【文件名】
        /// </summary>
        private void ckIsFileName_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 选择【文件内容】
        /// </summary>
        private void ckIsFileContent_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValid();
        }

        /// <summary>
        /// 根据规则id，填充该规则数据至编辑区域
        /// </summary>
        private void InitDataByRuleId(int ruleId)
        {
            var model = bll.GetModel(ruleId);
            this.txtRuleID.Text = null != model ? model.RuleConfigID.ToString() : "";
            this.txtRuleName.Text = null != model ? model.Name : "";
            this.txtNewContent.Text = null != model ? model.NewContent : "";
            this.txtOldContent.Text = null != model ? model.OldContent : "";
            this.ckIsFileContent.Checked = null != model ? model.IsFileContent : false;
            this.ckIsFileName.Checked = null != model ? model.IsFileName : false;
            this.ckIsIgnoreCase.Checked = null != model ? model.IsIgnoreCase : false;
            this.ckIsRegex.Checked = null != model ? model.IsRegex : false;
            this.ckIsWholeMatch.Checked = null != model ? model.IsWholeMatch : false;
        }

        /// <summary>
        /// 控件验证
        /// </summary>
        private void ControlValid()
        {
            if (this.ckIsRegex.Checked)
            {
                this.ckIsWholeMatch.Checked = false;
                this.ckIsWholeMatch.Enabled = false;
            }
            else
            {
                this.ckIsWholeMatch.Enabled = true;
            }

            if (!this.ckIsFileName.Checked && !this.ckIsFileContent.Checked)
            {
                this.ckIsFileName.Checked = true;
            }
        }

        #endregion 添加或修改规则TabPage

        private void RuleConfigSelectBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != _mainForm)
            {
                _mainForm.InitCurrentRuleList();
            }
        }
    }
}