using Aspose.Words.Replacing;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace XCLNetFileReplace
{
    public partial class Index : BaseForm.BaseFormClass
    {
        private Computer pc = new Computer();
        private object lockObject = new object();

        private delegate void Delegate_UpdateStatus(Model.DoState doState);

        private delegate DataLayer.Model.FileReplace_File Delegate_DoIt(DataLayer.Model.FileReplace_File model);

        private DataLayer.BLL.v_FileReplace_File v_fileBLL = new DataLayer.BLL.v_FileReplace_File();
        private DataLayer.BLL.FileReplace_File fileBLL = new DataLayer.BLL.FileReplace_File();
        private DataLayer.BLL.UserSetting userSettingBLL = new DataLayer.BLL.UserSetting();
        private DataLayer.BLL.v_FileReplace_RuleConfig v_ruleConfigBLL = new DataLayer.BLL.v_FileReplace_RuleConfig();

        private DataLayer.Model.FileReplaceSetting replaceSetting = new DataLayer.Model.FileReplaceSetting();
        private string[] defaultExt = { "xls", "xlsx", "csv", "xlt", "doc", "docx"/*, "ppt", "pptx","pdf"*/ };//这些格式由aspose去处理
        private string[] excelExt = { "xls", "xlsx", "csv", "xlt" };
        private string[] docExt = { "doc", "docx" };
        //private string[] pptExt = { "ppt", "pptx" };
        //private string[] pdfExt = { "pdf"};

        /// <summary>
        /// 构造方法
        /// </summary>
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        /// <summary>
        /// 初始化基本数据
        /// </summary>
        private void InitData()
        {
            this.dgFiles_gridControl.AllowDrop = true;
            this.replaceSetting = userSettingBLL.GetFileReplaceSetting() ?? new DataLayer.Model.FileReplaceSetting();
            fileBLL.Clear();
            this.InitCurrentRuleList();
            //初始化用户默认配置
            this.txtOutPutPath.Text = this.replaceSetting.OutPutPath;
            this.txtFileFirstName.Text = this.replaceSetting.PrefixName;
            this.txtFileLastName.Text = this.replaceSetting.SuffixName;
            if (this.replaceSetting.IsKeepDirectory.HasValue)
            {
                this.ckKeepDirectory.Checked = this.replaceSetting.IsKeepDirectory.Value;
            }
            if (this.replaceSetting.IsKeepDataFormat.HasValue)
            {
                this.ckExcelOptionIsKeepDataFormat.Checked = this.replaceSetting.IsKeepDataFormat.Value;
            }
            if (this.replaceSetting.IsKeepFormula.HasValue)
            {
                this.ckExcelOptionIsKeepFormula.Checked = this.replaceSetting.IsKeepFormula.Value;
            }
            this.toolStripStatusLabel2.Text = new Model.DoState().ToString();
            //文件选项
            this.comboxWordFileFormat.Properties.Items.Add("默认");
            XCLNetTools.Enum.EnumHelper.GetList(typeof(CommonHelper.CommonEnum.WordFileToFormatEnum)).ForEach(k =>
            {
                this.comboxWordFileFormat.Properties.Items.Add(k.Text);
            });
            this.comboxWordFileFormat.SelectedIndex = 0;
            this.comboxExcelFileFormat.Properties.Items.Add("默认");
            XCLNetTools.Enum.EnumHelper.GetList(typeof(CommonHelper.CommonEnum.ExcelFileToFormatEnum)).ForEach(k =>
            {
                this.comboxExcelFileFormat.Properties.Items.Add(k.Text);
            });
            this.comboxExcelFileFormat.SelectedIndex = 0;
        }

        /// <summary>
        /// 初始化已选配置
        /// </summary>
        public void InitCurrentRuleList()
        {
            List<DataLayer.Model.v_FileReplace_RuleConfig> ruleLst = null;
            var settings = this.userSettingBLL.GetFileReplaceSetting();
            if (null != settings && null != settings.RuleConfigIds && settings.RuleConfigIds.Count > 0)
            {
                ruleLst = this.v_ruleConfigBLL.GetAllList().Where(k => settings.RuleConfigIds.Contains(k.RuleConfigID)).ToList();
            }
            this.dataGridRuleConfig.GridControl.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(ruleLst);
        }

        /// <summary>
        /// 执行
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            var lst = this.fileBLL.GetAllList();

            #region 合法性验证

            if (null == lst || lst.Count == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请先选择待处理的文件！", "系统提示");
                return;
            }

            if (!string.IsNullOrEmpty(this.txtOutPutPath.Text))
            {
                if (XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
                {
                    //检查是否有文件
                    if (!XCLNetTools.FileHandler.FileDirectory.IsEmpty(this.txtOutPutPath.Text))
                    {
                        if (DevExpress.XtraEditors.XtraMessageBox.Show("您指定的输出目录不是空目录，是否继续？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return;
                        }
                    }
                }
                else
                {
                    if (!XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                    {
                        DevExpress.XtraEditors.XtraMessageBox.Show("输出目录不存在，请选择有效的输出目录！", "系统提示");
                        return;
                    }
                }
            }

            if (!lst.Exists(k => !k.IsDone))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("文件都已处理，请重新打开要处理的文件！", "系统提示");
                return;
            }

            if (DevExpress.XtraEditors.XtraMessageBox.Show("为了防止误操作，请您再次确认是否需要继续？", "系统提示", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            #endregion 合法性验证

            #region 将选项保存至配置文件中

            var ruleIdLst = new List<int>();
            var config = this.userSettingBLL.GetFirstModel() ?? new DataLayer.Model.UserSetting();
            for (var i = 0; i < this.dataGridRuleConfig.RowCount; i++)
            {
                ruleIdLst.Add(XCLNetTools.Common.DataTypeConvert.ToInt(this.dataGridRuleConfig.GetRowCellValue(i, "RuleConfigID")));
            }

            this.replaceSetting.OutPutPath = this.txtOutPutPath.Text;
            this.replaceSetting.PrefixName = this.txtFileFirstName.Text;
            this.replaceSetting.SuffixName = this.txtFileLastName.Text;
            this.replaceSetting.IsKeepDirectory = this.ckKeepDirectory.Checked;
            this.replaceSetting.IsKeepDataFormat = this.ckExcelOptionIsKeepDataFormat.Checked;
            this.replaceSetting.IsKeepFormula = this.ckExcelOptionIsKeepFormula.Checked;
            this.replaceSetting.RuleConfigIds = ruleIdLst;

            config.FileReplaceSetting = XCLNetTools.Serialize.JSON.Serialize(this.replaceSetting);

            this.userSettingBLL.Add(config);

            #endregion 将选项保存至配置文件中

            #region 任务处理

            this.txtLog.Clear();
            this.btnSave.Enabled = false;
            Model.DoState doState = new Model.DoState();
            doState.SumCount = lst.Count;
            this.UpdateStatus(doState);
            foreach (var m in lst)
            {
                this.SetTextLogValue(string.Format("正在处理文件：{0}", m.FileName));
                Delegate_DoIt dg = new Delegate_DoIt(this.DoIt);
                dg.BeginInvoke(m, new AsyncCallback(this.GetResultCallBack), doState);
            }

            #endregion 任务处理
        }

        /// <summary>
        /// 开始处理文件
        /// </summary>
        private DataLayer.Model.FileReplace_File DoIt(DataLayer.Model.FileReplace_File model)
        {
            model.IsDone = true;
            if (!System.IO.File.Exists(model.Path))
            {
                model.Remark = "文件不存在！";
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理;
                return model;
            }

            if (string.IsNullOrEmpty(model.ExtensionName))
            {
                model.Remark = "无法确认文件类型！";
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理;
                return model;
            }

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int replaceCount = 0;
            Regex reg = null;
            List<string> strRemark = new List<string>();

            Aspose.Cells.Cell currentCell = null;
            Aspose.Cells.CellValueType currentCellType;
            string cellValue = string.Empty;
            bool tempBool;
            int tempInt;
            double tempDouble;
            DateTime tempDateTime;
            bool isCellReplaced = false;
            int cellMatchCount;

            bool isDefaultExt = defaultExt.Contains(model.ExtensionName);
            bool isExcelExt = excelExt.Contains(model.ExtensionName);
            bool isDocExt = docExt.Contains(model.ExtensionName);
            //bool isPPTExt = pptExt.Contains(model.ExtensionName);
            //bool isPdfExt = pdfExt.Contains(model.ExtensionName);
            bool isTxtFile = XCLNetTools.FileHandler.ComFile.IsTextFile(model.Path);
            bool isNeedCopy = !string.IsNullOrEmpty(this.txtOutPutPath.Text);
            string realPath = model.Path;//被操作的文件实际路径，如果没有指定输出目录，则为原路径，如果指定了输出目录，则为copy到输出目录中后的路径
            string filetitle = XCLNetTools.FileHandler.ComFile.GetFileName(model.Path, false);//文件名，不含扩展名
            string newFileTitle = string.Empty;
            var wbSaveFormat = CommonHelper.Common.GetAsposeCellsFormatEnum(this.comboxExcelFileFormat.Text);
            var docSaveFormat = CommonHelper.Common.GetAsposeWordFormatEnum(this.comboxWordFileFormat.Text);

            try
            {
                #region 先处理替换文件名

                for (int ruleIndex = 0; ruleIndex < this.dataGridRuleConfig.RowCount; ruleIndex++)
                {
                    var ruleModel = XCLNetTools.Generic.ListHelper.DataRowToModel<DataLayer.Model.v_FileReplace_RuleConfig>(dataGridRuleConfig.GetDataRow(ruleIndex));
                    if (null == ruleModel || !ruleModel.IsFileName)
                    {
                        continue;
                    }

                    #region 是否启用正则替换

                    if (ruleModel.IsRegex)
                    {
                        reg = ruleModel.IsIgnoreCase ? new Regex(ruleModel.OldContent, RegexOptions.IgnoreCase) : new Regex(ruleModel.OldContent);
                    }
                    else
                    {
                        string newExpStr = ruleModel.IsWholeMatch ? string.Format(@"\b{0}\b", Regex.Escape(ruleModel.OldContent)) : Regex.Escape(ruleModel.OldContent);
                        reg = ruleModel.IsIgnoreCase ? new Regex(newExpStr, RegexOptions.IgnoreCase) : new Regex(newExpStr);
                    }

                    #endregion 是否启用正则替换

                    #region 判断是否替换文件名

                    replaceCount = reg.Matches(filetitle).Count;
                    strRemark.Add(string.Format("规则【{0}】文件名替换【{1}】处；", ruleModel.Name, replaceCount));
                    filetitle = reg.Replace(filetitle, ruleModel.NewContent);
                    model.ProcessBlockCount += replaceCount;

                    #endregion 判断是否替换文件名
                }

                filetitle = string.Format("{0}{1}{2}", this.txtFileFirstName.Text, filetitle, this.txtFileLastName.Text);

                bool isFileNameChanged = !string.Equals(XCLNetTools.FileHandler.ComFile.GetFileName(model.Path, false), filetitle, StringComparison.OrdinalIgnoreCase);

                if (isNeedCopy)
                {
                    if (isFileNameChanged)
                    {
                        realPath = XCLNetTools.FileHandler.ComFile.GetFileFolderPath(model.Path) + "\\" + filetitle + "." + model.ExtensionName;
                    }
                    if (this.ckKeepDirectory.Checked)
                    {
                        realPath = realPath.Replace(System.IO.Path.GetPathRoot(realPath).TrimEnd('\\'), this.txtOutPutPath.Text.TrimEnd('\\'));
                    }
                    else
                    {
                        realPath = realPath.Replace(XCLNetTools.FileHandler.ComFile.GetFileFolderPath(realPath), this.txtOutPutPath.Text.TrimEnd('\\'));
                    }
                    XCLNetTools.FileHandler.ComFile.CopyFile(model.Path, realPath);
                    if (!System.IO.File.Exists(realPath))
                    {
                        model.Remark = "复制到输出目录执行失败！";
                        model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                        return model;
                    }
                }
                else
                {
                    if (isFileNameChanged)
                    {
                        newFileTitle = filetitle + "." + model.ExtensionName;
                        this.pc.FileSystem.RenameFile(model.Path, newFileTitle);
                        realPath = XCLNetTools.FileHandler.ComFile.ChangePathByFileName(realPath, newFileTitle);
                    }
                }

                #endregion 先处理替换文件名

                #region 替换文件内容

                Aspose.Cells.Workbook wb = null;
                Aspose.Words.Document wordDocument = null;
                string textContent = null;
                var txtEncoding = System.Text.Encoding.Default;

                for (int ruleIndex = 0; ruleIndex < this.dataGridRuleConfig.RowCount; ruleIndex++)
                {
                    var ruleModel = XCLNetTools.Generic.ListHelper.DataRowToModel<DataLayer.Model.v_FileReplace_RuleConfig>(dataGridRuleConfig.GetDataRow(ruleIndex));
                    if (null == ruleModel || !ruleModel.IsFileContent)
                    {
                        continue;
                    }

                    #region 验证扩展名及是否为文本文件

                    if (!isDefaultExt && !isTxtFile && ruleModel.IsFileContent)
                    {
                        //非aspose能处理的文件，且非文本文件，则不能替换内容！
                        strRemark.Add(string.Format("规则【{0}】不支持替换该文件的内容！", ruleModel.Name));
                        continue;
                    }

                    #endregion 验证扩展名及是否为文本文件

                    #region 是否启用正则替换

                    if (ruleModel.IsRegex)
                    {
                        reg = ruleModel.IsIgnoreCase ? new Regex(ruleModel.OldContent, RegexOptions.IgnoreCase) : new Regex(ruleModel.OldContent);
                    }
                    else
                    {
                        string newExpStr = ruleModel.IsWholeMatch ? string.Format(@"\b{0}\b", Regex.Escape(ruleModel.OldContent)) : Regex.Escape(ruleModel.OldContent);
                        reg = ruleModel.IsIgnoreCase ? new Regex(newExpStr, RegexOptions.IgnoreCase) : new Regex(newExpStr);
                    }

                    #endregion 是否启用正则替换

                    #region 开始替换文件内容

                    if (isDefaultExt)
                    {
                        if (isExcelExt)
                        {
                            #region 处理excel文件

                            if (null == wb)
                            {
                                wb = new Aspose.Cells.Workbook(realPath);
                            }

                            for (int i = 0; i < wb.Worksheets.Count; i++)
                            {
                                Aspose.Cells.Cells sheetCells = wb.Worksheets[i].Cells;

                                for (int cellsRowIndex = 0; cellsRowIndex < sheetCells.MaxDataRow + 1; cellsRowIndex++)
                                {
                                    for (int cellsColumn = 0; cellsColumn < sheetCells.MaxDataColumn + 1; cellsColumn++)
                                    {
                                        currentCell = sheetCells[cellsRowIndex, cellsColumn];

                                        if (currentCell.IsFormula && this.ckExcelOptionIsKeepFormula.Checked)
                                        {
                                            continue;
                                        }

                                        cellValue = Convert.ToString(currentCell.Value);
                                        if (string.IsNullOrEmpty(cellValue))
                                        {
                                            continue;
                                        }

                                        cellMatchCount = reg.Matches(cellValue).Count;

                                        if (cellMatchCount == 0)
                                        {
                                            continue;
                                        }

                                        var cellCharacters = currentCell.GetCharacters();

                                        cellValue = reg.Replace(cellValue, ruleModel.NewContent);

                                        currentCellType = this.ckExcelOptionIsKeepDataFormat.Checked ? currentCell.Type : Aspose.Cells.CellValueType.IsString;

                                        switch (currentCellType)
                                        {
                                            case Aspose.Cells.CellValueType.IsBool:
                                                if (bool.TryParse(cellValue, out tempBool))
                                                {
                                                    currentCell.PutValue(tempBool);
                                                    isCellReplaced = true;
                                                }
                                                break;

                                            case Aspose.Cells.CellValueType.IsDateTime:
                                                if (DateTime.TryParse(cellValue, out tempDateTime))
                                                {
                                                    currentCell.PutValue(tempDateTime);
                                                    isCellReplaced = true;
                                                }
                                                break;

                                            case Aspose.Cells.CellValueType.IsNumeric:
                                                if (int.TryParse(cellValue, out tempInt))
                                                {
                                                    currentCell.PutValue(tempInt);
                                                    isCellReplaced = true;
                                                }
                                                else
                                                {
                                                    if (double.TryParse(cellValue, out tempDouble))
                                                    {
                                                        currentCell.PutValue(tempDouble);
                                                        isCellReplaced = true;
                                                    }
                                                }
                                                break;

                                            default:
                                                currentCell.PutValue(cellValue);
                                                isCellReplaced = true;
                                                break;
                                        }

                                        if (isCellReplaced)
                                        {
                                            if (null != cellCharacters && cellCharacters.Length > 0)
                                            {
                                                currentCell.SetCharacters(cellCharacters);
                                            }
                                            replaceCount += cellMatchCount;
                                        }
                                    }
                                }
                            }

                            #endregion 处理excel文件
                        }
                        else if (isDocExt)
                        {
                            #region 处理word

                            if (null == wordDocument)
                            {
                                wordDocument = new Aspose.Words.Document(realPath);
                            }
                            var finder = new FindReplaceOptions();
                            replaceCount = wordDocument.Range.Replace(reg, ruleModel.NewContent, finder);

                            #endregion 处理word
                        }
                        //else if (isPPTExt)
                        //{
                        //    #region 处理PPT
                        //    Aspose.Slides.Pptx.PresentationEx pptPres = new Aspose.Slides.Pptx.PresentationEx(realPath);
                        //    #endregion
                        //}
                        //else if (isPdfExt)
                        //{
                        //    #region 处理pdf文件
                        //    Aspose.Pdf.Kit.PdfContentEditor pdfEditor = new Aspose.Pdf.Kit.PdfContentEditor();
                        //    pdfEditor.BindPdf(realPath);
                        //    pdfEditor.ReplaceText(this.txtOldValue.Text, this.txtNew.Text);
                        //    pdfEditor.Save(realPath);
                        //    #endregion
                        //}
                    }
                    else
                    {
                        #region 处理文本文件

                        if (null == textContent)
                        {
                            txtEncoding = XCLNetTools.FileHandler.ComFile.GetFileEncoding(realPath);
                            textContent = System.IO.File.ReadAllText(realPath, txtEncoding) ?? "";
                        }
                        replaceCount = reg.Matches(textContent).Count;
                        textContent = reg.Replace(textContent, ruleModel.NewContent);

                        #endregion 处理文本文件
                    }
                    strRemark.Add(string.Format("规则【{0}】文件内容替换【{1}】处；", ruleModel.Name, replaceCount));

                    #endregion 开始替换文件内容

                    this.SetTextLogValue(string.Format("正在处理文件【{0}】，应用规则【{1}】", model.FileName, ruleModel.Name));

                    model.ProcessBlockCount += replaceCount;
                }

                if (null == wb && isExcelExt && wbSaveFormat != Aspose.Cells.SaveFormat.Unknown)
                {
                    wb = new Aspose.Cells.Workbook(realPath);
                }
                if (null == wordDocument && isDocExt && docSaveFormat != Aspose.Words.SaveFormat.Unknown)
                {
                    wordDocument = new Aspose.Words.Document(realPath);
                }

                if (null != wb)
                {
                    if (this.ckExcelOptionIsKeepFormula.Checked)
                    {
                        wb.CalculateFormula();
                    }
                    if (wbSaveFormat == Aspose.Cells.SaveFormat.Unknown)
                    {
                        wb.Save(realPath);
                    }
                    else
                    {
                        realPath = XCLNetTools.FileHandler.ComFile.GetFilePathWithNewExt(realPath, this.comboxExcelFileFormat.Text);
                        wb.Save(realPath, wbSaveFormat);
                    }
                }
                if (null != wordDocument)
                {
                    if (docSaveFormat == Aspose.Words.SaveFormat.Unknown)
                    {
                        wordDocument.Save(realPath);
                    }
                    else
                    {
                        realPath = XCLNetTools.FileHandler.ComFile.GetFilePathWithNewExt(realPath, this.comboxWordFileFormat.Text);
                        wordDocument.Save(realPath, docSaveFormat);
                    }
                }
                if (null != textContent)
                {
                    System.IO.File.WriteAllText(realPath, textContent, txtEncoding);
                }

                #endregion 替换文件内容

                if (strRemark.Count > 0)
                {
                    model.Remark = string.Join("；", strRemark.ToArray());
                }

                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功;
            }
            catch (Exception e)
            {
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败;
                model.Remark = e.Message;
            }
            finally
            {
                sw.Stop();
                model.ProcessDuration = (int)sw.Elapsed.TotalSeconds;
            }

            if (string.IsNullOrWhiteSpace(model.Remark))
            {
                this.SetTextLogValue(string.Format("文件【{0}】处理完毕", model.FileName));
            }
            else
            {
                this.SetTextLogValue(string.Format("文件【{0}】处理完毕（{1}）", model.FileName, model.Remark));
            }

            return model;
        }

        /// <summary>
        /// 处理文件回调函数
        /// </summary>
        private void GetResultCallBack(IAsyncResult asyncResult)
        {
            lock (this.lockObject)
            {
                Model.DoState doState = asyncResult.AsyncState as Model.DoState;
                AsyncResult result = (AsyncResult)asyncResult;
                Delegate_DoIt delegateDoit = (Delegate_DoIt)result.AsyncDelegate;
                var model = delegateDoit.EndInvoke(asyncResult);

                switch (model.ProcessState)
                {
                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理失败:
                        doState.FailCount += 1;
                        break;

                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.处理成功:
                        doState.SuccessCount += 1;
                        break;

                    case (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.无需处理:
                        doState.IgnoreCount += 1;
                        break;
                }
                //更新model
                this.fileBLL.Update(model);

                if (this.InvokeRequired)
                {
                    this.Invoke(new Delegate_UpdateStatus(this.UpdateStatus), new object[] { doState });
                }
                else
                {
                    this.UpdateStatus(doState);
                }
            }
        }

        /// <summary>
        /// 更新状态栏
        /// </summary>
        private void UpdateStatus(Model.DoState doState)
        {
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
            if (doState.CurrentCount == doState.SumCount)
            {
                this.btnSave.Enabled = true;
                this.txtLog.AppendText("文件已全部处理完毕！" + Environment.NewLine);
                this.dgFiles.GridControl.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(this.v_fileBLL.GetAllList());
            }
        }

        /// <summary>
        /// 初始化状态栏
        /// </summary>
        private void InitStatus()
        {
            Model.DoState doState = new Model.DoState();
            this.toolStripStatusLabel2.Text = doState.ToString();
            this.toolStripProgressBar1.Value = (int)doState.DoPercent;
        }

        /// <summary>
        /// 设置输出目录
        /// </summary>
        private void btnOutPutPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (openFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtOutPutPath.Text = openFolder.SelectedPath;
            }
        }

        /// <summary>
        /// 初始化待处理文件
        /// </summary>
        private void InitFiles(string[] files)
        {
            List<DataLayer.Model.FileReplace_File> lst = new List<DataLayer.Model.FileReplace_File>();
            for (int i = 0; i < files.Length; i++)
            {
                var model = new DataLayer.Model.FileReplace_File();
                model.CreateTime = model.UpdateTime = DateTime.Now;
                model.ExtensionName = (XCLNetTools.FileHandler.ComFile.GetExtName(files[i]) ?? "").ToLower();
                if (string.IsNullOrEmpty(model.ExtensionName))
                {
                    continue;
                }
                model.FileName = XCLNetTools.FileHandler.ComFile.GetFileName(files[i]);
                model.IsDone = false;
                model.Path = files[i];
                if (!string.IsNullOrEmpty(model.Path))
                {
                    model.Path = string.Format("{0}.{1}", model.Path.Substring(0, model.Path.LastIndexOf('.')), XCLNetTools.FileHandler.ComFile.GetExtName(model.Path).ToLower());
                }
                model.ProcessBlockCount = 0;
                model.ProcessDuration = 0;
                model.ProcessState = (int)DataLayer.Common.DataEnum.FileReplace_File_ProcessStateEnum.等待处理;
                model.Remark = "";
                lst.Add(model);
            }
            fileBLL.Add(lst);

            this.dgFiles.GridControl.DataSource = XCLNetTools.DataSource.DataTableHelper.ToDataTable(this.v_fileBLL.GetAllList());
            this.InitStatus();
        }

        /// <summary>
        /// 打开输出目录
        /// </summary>
        private void btnOpenOutPath_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtOutPutPath.Text))
            {
                if (XCLNetTools.FileHandler.FileDirectory.DirectoryExists(this.txtOutPutPath.Text))
                {
                    System.Diagnostics.Process.Start("Explorer.exe", this.txtOutPutPath.Text);
                }
                else
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show("该目录不存在，是否要创建？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (XCLNetTools.FileHandler.FileDirectory.MakeDirectory(this.txtOutPutPath.Text))
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("目录创建成功！", "系统提示");
                        }
                        else
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("目录创建失败，请手动选择有效目录！", "系统提示");
                        }
                    }
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请先选择输出目录！", "系统提示");
            }
        }

        /// <summary>
        /// 重写标题
        /// </summary>
        public override string SubAssemblyName
        {
            get { return Assembly.GetExecutingAssembly().GetName().Name; }
        }

        /// <summary>
        /// 选择规则
        /// </summary>
        private void btnSelectRule_Click(object sender, EventArgs e)
        {
            XCLNetFileReplace.RuleConfigSelectBox fm = new RuleConfigSelectBox(this);
            fm.ShowDialog();
        }

        /// <summary>
        /// 【执行】按钮切换可用/不可用状态事件
        /// </summary>
        private void btnSave_EnabledChanged(object sender, EventArgs e)
        {
            bool state = this.btnSave.Enabled;

            this.btnSave.Enabled = state;
            this.btnSelectRule.Enabled = state;

            this.打开文件ToolStripMenuItem.Enabled = state;
            this.打开文件夹ToolStripMenuItem.Enabled = state;
            this.导出ToolStripMenuItem.Enabled = state;
        }

        /// <summary>
        /// 设置日志文本框的值
        /// </summary>
        public void SetTextLogValue(string logMsg)
        {
            logMsg += Environment.NewLine;
            if (this.txtLog.InvokeRequired)
            {
                this.txtLog.Invoke(new Action<string>((txt) =>
                {
                    this.txtLog.AppendText(txt);
                }), new object[] { logMsg });
            }
            else
            {
                this.txtLog.AppendText(logMsg);
            }
        }

        /// <summary>
        /// 导出待处理文件
        /// </summary>
        private void btnExportWaitFile_Click(object sender, EventArgs e)
        {
            var lst = new DataLayer.BLL.v_FileReplace_File_ForExport().GetAllList();
            if (null == lst || lst.Count == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前没有任何数据可供导出！", "系统提示");
                return;
            }
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            openFolder.Description = "请选择要存放的目录！";
            if (openFolder.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            string folderPath = openFolder.SelectedPath.TrimEnd('\\');
            Aspose.Cells.Workbook wb = new Aspose.Cells.Workbook();
            wb.Worksheets[0].Cells.ImportDataTable(XCLNetTools.DataSource.DataTableHelper.ToDataTable(lst), true, 0, 0);
            string filePath = string.Format(@"{0}\XCLNetFileRelace_{1:yyyyMMddHHmmssfff}.xlsx", folderPath, DateTime.Now);
            wb.Save(filePath, Aspose.Cells.SaveFormat.Xlsx);
            if (DevExpress.XtraEditors.XtraMessageBox.Show("导出成功，是否打开该文件？", "系统提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(filePath);
            }
        }

        /// <summary>
        /// 打开待处理文件
        /// </summary>
        private void btnOpenAWaitFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = true;
            openFile.Filter = "所有文件|*.*|Excel文档|*.xlsx;*.xls|Word文档|*.docx;*.doc|文本文件|*.txt";
            if (!string.IsNullOrWhiteSpace(this.replaceSetting.LastOpenFolderPath) && System.IO.Directory.Exists(this.replaceSetting.LastOpenFolderPath))
            {
                openFile.InitialDirectory = this.replaceSetting.LastOpenFolderPath;
            }
            if (openFile.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            try
            {
                var currentFileNameLst = this.fileBLL.GetAllList().Select(k => k.Path).ToList();
                currentFileNameLst.AddRange(openFile.FileNames.ToList());
                this.InitFiles(currentFileNameLst.Distinct().ToArray());
                if (null != openFile.FileNames && openFile.FileNames.Length > 0)
                {
                    string fName = XCLNetTools.FileHandler.ComFile.GetFileName(openFile.FileNames[0]);
                    this.replaceSetting.LastOpenFolderPath = openFile.FileNames[0].Replace(fName, "");
                }
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("系统错误，请重新打开有效文件！", "系统提示");
            }
        }

        /// <summary>
        /// 打开待处理文件夹
        /// </summary>
        private void btnOpenFolderWaitFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();
            if (!string.IsNullOrWhiteSpace(this.replaceSetting.LastOpenFolderPath) && System.IO.Directory.Exists(this.replaceSetting.LastOpenFolderPath))
            {
                openFolder.SelectedPath = this.replaceSetting.LastOpenFolderPath;
            }
            if (openFolder.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            try
            {
                var currentFileNameLst = this.fileBLL.GetAllList().Select(k => k.Path).ToList();
                string[] files = XCLNetTools.FileHandler.ComFile.GetFolderFilesByRecursion(openFolder.SelectedPath);
                currentFileNameLst.AddRange(files.ToList());
                this.InitFiles(currentFileNameLst.Distinct().ToArray());
                this.replaceSetting.LastOpenFolderPath = openFolder.SelectedPath;
            }
            catch
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("系统错误，请重新打开有效文件夹！", "系统提示");
            }
        }

        /// <summary>
        /// 文件列表拖拽
        /// </summary>
        private void dgFiles_gridControl_DragDrop(object sender, DragEventArgs e)
        {
            var pathList = ((Array)e.Data.GetData(DataFormats.FileDrop));
            if (null == pathList || pathList.Length == 0)
            {
                return;
            }
            var fileList = new List<string>();
            foreach (string path in pathList)
            {
                if (System.IO.File.Exists(path))
                {
                    fileList.Add(path);
                }
                else if (System.IO.Directory.Exists(path))
                {
                    fileList.AddRange(XCLNetTools.FileHandler.ComFile.GetFolderFilesByRecursion(path));
                }
            }
            var currentFileNameLst = this.fileBLL.GetAllList().Select(k => k.Path).ToList();
            currentFileNameLst.AddRange(fileList);
            this.InitFiles(currentFileNameLst.Distinct().ToArray());
        }

        /// <summary>
        /// 文件拖拽
        /// </summary>
        private void dgFiles_gridControl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 从待处理列表中移除选中的文件
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedRowIndexArr = this.dgFiles.GetSelectedRows();
            if (null == selectedRowIndexArr || selectedRowIndexArr.Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选择需要移除的文件！", "系统提示");
                return;
            }
            var needRemovePathList = new List<string>();
            selectedRowIndexArr.ToList().ForEach(k =>
            {
                needRemovePathList.Add(this.dgFiles.GetRowCellValue(k, "Path").ToString());
            });
            var fileNameList = this.fileBLL.GetAllList().Where(k => !needRemovePathList.Contains(k.Path)).Select(k => k.Path).ToArray();
            this.InitFiles(fileNameList.ToArray());
        }

        /// <summary>
        /// 清空文件列表
        /// </summary>
        private void btnClearFileList_Click(object sender, EventArgs e)
        {
            this.InitFiles(new string[] { });
        }

        /// <summary>
        /// 重载列表文件
        /// </summary>
        private void btnReloadFileList_Click(object sender, EventArgs e)
        {
            var currentFileNameLst = this.fileBLL.GetAllList().Select(k => k.Path).Where(k => System.IO.File.Exists(k)).ToList();
            this.InitFiles(currentFileNameLst.Distinct().ToArray());
        }
    }
}