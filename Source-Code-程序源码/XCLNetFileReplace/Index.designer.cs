namespace XCLNetFileReplace
{
    partial class Index
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.dgFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgFiles_FileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_FileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_Path = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_ExtensionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_IsDone_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_ProcessState_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_ProcessDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_ProcessBlockCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_Remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgFiles_gridControl = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.打开文件ToolStripMenuItem = new DevExpress.XtraBars.BarButtonItem();
            this.打开文件夹ToolStripMenuItem = new DevExpress.XtraBars.BarButtonItem();
            this.导出ToolStripMenuItem = new DevExpress.XtraBars.BarButtonItem();
            this.退出ToolStripMenuItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.contextMenuStrip_LBoxWait = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridRuleConfig = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid_RuleConfigID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_OldContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_NewContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_IsRegex_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_IsIgnoreCase_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_IsWholeMatch_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_IsFileName_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_IsFileContent_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_CreateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_UpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgRuleConfig_gridControl = new DevExpress.XtraGrid.GridControl();
            this.btnSelectRule = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtOutPutPath = new System.Windows.Forms.TextBox();
            this.btnOutPutPath = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenOutPath = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileFirstName = new System.Windows.Forms.TextBox();
            this.txtFileLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckExcelOptionIsKeepFormula = new System.Windows.Forms.CheckBox();
            this.ckExcelOptionIsKeepDataFormat = new System.Windows.Forms.CheckBox();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnReloadFileList = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearFileList = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportWaitFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenFolderWaitFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenAWaitFile = new DevExpress.XtraEditors.SimpleButton();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.label7 = new System.Windows.Forms.Label();
            this.comboxExcelFileFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.comboxWordFileFormat = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ckKeepDirectory = new System.Windows.Forms.CheckBox();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.contextMenuStrip_LBoxWait.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleConfig_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxExcelFileFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxWordFileFormat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFiles
            // 
            this.dgFiles.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.dgFiles.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgFiles.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgFiles.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dgFiles_FileID,
            this.dgFiles_FileName,
            this.dgFiles_Path,
            this.dgFiles_ExtensionName,
            this.dgFiles_IsDone_Text,
            this.dgFiles_ProcessState_Text,
            this.dgFiles_ProcessDuration,
            this.dgFiles_ProcessBlockCount,
            this.dgFiles_Remark});
            this.dgFiles.GridControl = this.dgFiles_gridControl;
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.OptionsBehavior.Editable = false;
            this.dgFiles.OptionsCustomization.AllowFilter = false;
            this.dgFiles.OptionsCustomization.AllowGroup = false;
            this.dgFiles.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dgFiles.OptionsSelection.MultiSelect = true;
            this.dgFiles.OptionsView.ShowGroupPanel = false;
            // 
            // dgFiles_FileID
            // 
            this.dgFiles_FileID.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_FileID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_FileID.AppearanceHeader.Options.UseTextOptions = true;
            this.dgFiles_FileID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_FileID.Caption = "编号";
            this.dgFiles_FileID.FieldName = "FileID";
            this.dgFiles_FileID.MinWidth = 10;
            this.dgFiles_FileID.Name = "dgFiles_FileID";
            this.dgFiles_FileID.Visible = true;
            this.dgFiles_FileID.VisibleIndex = 0;
            this.dgFiles_FileID.Width = 60;
            // 
            // dgFiles_FileName
            // 
            this.dgFiles_FileName.Caption = "文件名";
            this.dgFiles_FileName.FieldName = "FileName";
            this.dgFiles_FileName.MinWidth = 10;
            this.dgFiles_FileName.Name = "dgFiles_FileName";
            this.dgFiles_FileName.Visible = true;
            this.dgFiles_FileName.VisibleIndex = 1;
            this.dgFiles_FileName.Width = 124;
            // 
            // dgFiles_Path
            // 
            this.dgFiles_Path.Caption = "路径";
            this.dgFiles_Path.FieldName = "Path";
            this.dgFiles_Path.MinWidth = 10;
            this.dgFiles_Path.Name = "dgFiles_Path";
            this.dgFiles_Path.Visible = true;
            this.dgFiles_Path.VisibleIndex = 2;
            this.dgFiles_Path.Width = 150;
            // 
            // dgFiles_ExtensionName
            // 
            this.dgFiles_ExtensionName.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_ExtensionName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_ExtensionName.Caption = "扩展名";
            this.dgFiles_ExtensionName.FieldName = "ExtensionName";
            this.dgFiles_ExtensionName.MinWidth = 10;
            this.dgFiles_ExtensionName.Name = "dgFiles_ExtensionName";
            this.dgFiles_ExtensionName.Visible = true;
            this.dgFiles_ExtensionName.VisibleIndex = 3;
            this.dgFiles_ExtensionName.Width = 120;
            // 
            // dgFiles_IsDone_Text
            // 
            this.dgFiles_IsDone_Text.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_IsDone_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_IsDone_Text.Caption = "是否已处理";
            this.dgFiles_IsDone_Text.FieldName = "IsDone_Text";
            this.dgFiles_IsDone_Text.MinWidth = 10;
            this.dgFiles_IsDone_Text.Name = "dgFiles_IsDone_Text";
            this.dgFiles_IsDone_Text.Visible = true;
            this.dgFiles_IsDone_Text.VisibleIndex = 4;
            this.dgFiles_IsDone_Text.Width = 120;
            // 
            // dgFiles_ProcessState_Text
            // 
            this.dgFiles_ProcessState_Text.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_ProcessState_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_ProcessState_Text.Caption = "处理结果";
            this.dgFiles_ProcessState_Text.FieldName = "ProcessState_Text";
            this.dgFiles_ProcessState_Text.MinWidth = 10;
            this.dgFiles_ProcessState_Text.Name = "dgFiles_ProcessState_Text";
            this.dgFiles_ProcessState_Text.Visible = true;
            this.dgFiles_ProcessState_Text.VisibleIndex = 5;
            this.dgFiles_ProcessState_Text.Width = 120;
            // 
            // dgFiles_ProcessDuration
            // 
            this.dgFiles_ProcessDuration.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_ProcessDuration.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_ProcessDuration.Caption = "处理用时（秒）";
            this.dgFiles_ProcessDuration.FieldName = "ProcessDuration";
            this.dgFiles_ProcessDuration.MinWidth = 10;
            this.dgFiles_ProcessDuration.Name = "dgFiles_ProcessDuration";
            this.dgFiles_ProcessDuration.Visible = true;
            this.dgFiles_ProcessDuration.VisibleIndex = 6;
            this.dgFiles_ProcessDuration.Width = 120;
            // 
            // dgFiles_ProcessBlockCount
            // 
            this.dgFiles_ProcessBlockCount.AppearanceCell.Options.UseTextOptions = true;
            this.dgFiles_ProcessBlockCount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgFiles_ProcessBlockCount.Caption = "处理数量";
            this.dgFiles_ProcessBlockCount.FieldName = "ProcessBlockCount";
            this.dgFiles_ProcessBlockCount.MinWidth = 10;
            this.dgFiles_ProcessBlockCount.Name = "dgFiles_ProcessBlockCount";
            this.dgFiles_ProcessBlockCount.Visible = true;
            this.dgFiles_ProcessBlockCount.VisibleIndex = 7;
            this.dgFiles_ProcessBlockCount.Width = 110;
            // 
            // dgFiles_Remark
            // 
            this.dgFiles_Remark.Caption = "备注";
            this.dgFiles_Remark.FieldName = "Remark";
            this.dgFiles_Remark.MinWidth = 10;
            this.dgFiles_Remark.Name = "dgFiles_Remark";
            this.dgFiles_Remark.Visible = true;
            this.dgFiles_Remark.VisibleIndex = 8;
            this.dgFiles_Remark.Width = 110;
            // 
            // dgFiles_gridControl
            // 
            this.dgFiles_gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgFiles_gridControl.Location = new System.Drawing.Point(2, 3);
            this.dgFiles_gridControl.MainView = this.dgFiles;
            this.dgFiles_gridControl.MenuManager = this.barManager1;
            this.dgFiles_gridControl.Name = "dgFiles_gridControl";
            this.dgFiles_gridControl.Size = new System.Drawing.Size(956, 404);
            this.dgFiles_gridControl.TabIndex = 0;
            this.dgFiles_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgFiles});
            this.dgFiles_gridControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgFiles_gridControl_DragDrop);
            this.dgFiles_gridControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgFiles_gridControl_DragEnter);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.打开文件ToolStripMenuItem,
            this.打开文件夹ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.barButtonItem5});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 553);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(982, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(982, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.AccessibleName = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.打开文件ToolStripMenuItem.Caption = "打开文件";
            this.打开文件ToolStripMenuItem.Hint = null;
            this.打开文件ToolStripMenuItem.Id = 0;
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // 打开文件夹ToolStripMenuItem
            // 
            this.打开文件夹ToolStripMenuItem.AccessibleName = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.打开文件夹ToolStripMenuItem.Caption = "打开文件夹";
            this.打开文件夹ToolStripMenuItem.Hint = null;
            this.打开文件夹ToolStripMenuItem.Id = 1;
            this.打开文件夹ToolStripMenuItem.Name = "打开文件夹ToolStripMenuItem";
            this.打开文件夹ToolStripMenuItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.AccessibleName = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.导出ToolStripMenuItem.Caption = "导出";
            this.导出ToolStripMenuItem.Hint = null;
            this.导出ToolStripMenuItem.Id = 2;
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.AccessibleName = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.退出ToolStripMenuItem.Caption = "退出";
            this.退出ToolStripMenuItem.Hint = null;
            this.退出ToolStripMenuItem.Id = 3;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.AccessibleName = "文件ToolStripMenuItem";
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Caption = "菜单";
            this.barButtonItem5.DropDownControl = this.popupMenu1;
            this.barButtonItem5.Hint = null;
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.打开文件ToolStripMenuItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.打开文件夹ToolStripMenuItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.导出ToolStripMenuItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.退出ToolStripMenuItem)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // contextMenuStrip_LBoxWait
            // 
            this.contextMenuStrip_LBoxWait.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_LBoxWait.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.全选ToolStripMenuItem,
            this.反选ToolStripMenuItem});
            this.contextMenuStrip_LBoxWait.Name = "contextMenuStrip_LBoxWait";
            this.contextMenuStrip_LBoxWait.Size = new System.Drawing.Size(70, 70);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // 反选ToolStripMenuItem
            // 
            this.反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
            this.反选ToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(982, 30);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 25);
            this.toolStripStatusLabel1.Text = "处理进度：";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(333, 24);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 25);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtLog.Location = new System.Drawing.Point(2, 26);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(950, 322);
            this.txtLog.TabIndex = 0;
            this.txtLog.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 429);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "说明：多个规则从上至下依次匹配。";
            // 
            // dataGridRuleConfig
            // 
            this.dataGridRuleConfig.Appearance.FixedLine.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridRuleConfig.Appearance.FixedLine.Options.UseFont = true;
            this.dataGridRuleConfig.Appearance.HeaderPanel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridRuleConfig.Appearance.HeaderPanel.Options.UseFont = true;
            this.dataGridRuleConfig.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grid_RuleConfigID,
            this.grid_Name,
            this.grid_OldContent,
            this.grid_NewContent,
            this.grid_IsRegex_Text,
            this.grid_IsIgnoreCase_Text,
            this.grid_IsWholeMatch_Text,
            this.grid_IsFileName_Text,
            this.grid_IsFileContent_Text,
            this.grid_CreateTime,
            this.grid_UpdateTime});
            this.dataGridRuleConfig.GridControl = this.dgRuleConfig_gridControl;
            this.dataGridRuleConfig.Name = "dataGridRuleConfig";
            this.dataGridRuleConfig.OptionsBehavior.Editable = false;
            this.dataGridRuleConfig.OptionsCustomization.AllowFilter = false;
            this.dataGridRuleConfig.OptionsCustomization.AllowGroup = false;
            this.dataGridRuleConfig.OptionsCustomization.AllowSort = false;
            this.dataGridRuleConfig.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dataGridRuleConfig.OptionsView.ShowGroupPanel = false;
            // 
            // grid_RuleConfigID
            // 
            this.grid_RuleConfigID.AppearanceCell.Options.UseTextOptions = true;
            this.grid_RuleConfigID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_RuleConfigID.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_RuleConfigID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_RuleConfigID.Caption = "编号";
            this.grid_RuleConfigID.FieldName = "RuleConfigID";
            this.grid_RuleConfigID.MaxWidth = 60;
            this.grid_RuleConfigID.MinWidth = 60;
            this.grid_RuleConfigID.Name = "grid_RuleConfigID";
            this.grid_RuleConfigID.Visible = true;
            this.grid_RuleConfigID.VisibleIndex = 0;
            this.grid_RuleConfigID.Width = 60;
            // 
            // grid_Name
            // 
            this.grid_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_Name.Caption = "名称";
            this.grid_Name.FieldName = "Name";
            this.grid_Name.Name = "grid_Name";
            this.grid_Name.Visible = true;
            this.grid_Name.VisibleIndex = 1;
            // 
            // grid_OldContent
            // 
            this.grid_OldContent.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_OldContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_OldContent.Caption = "查找内容";
            this.grid_OldContent.FieldName = "OldContent";
            this.grid_OldContent.Name = "grid_OldContent";
            this.grid_OldContent.Visible = true;
            this.grid_OldContent.VisibleIndex = 2;
            // 
            // grid_NewContent
            // 
            this.grid_NewContent.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_NewContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_NewContent.Caption = "替换内容";
            this.grid_NewContent.FieldName = "NewContent";
            this.grid_NewContent.Name = "grid_NewContent";
            this.grid_NewContent.Visible = true;
            this.grid_NewContent.VisibleIndex = 3;
            // 
            // grid_IsRegex_Text
            // 
            this.grid_IsRegex_Text.AppearanceCell.Options.UseTextOptions = true;
            this.grid_IsRegex_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsRegex_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_IsRegex_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsRegex_Text.Caption = "是否为正则表达式";
            this.grid_IsRegex_Text.FieldName = "IsRegex_Text";
            this.grid_IsRegex_Text.Name = "grid_IsRegex_Text";
            this.grid_IsRegex_Text.Visible = true;
            this.grid_IsRegex_Text.VisibleIndex = 4;
            // 
            // grid_IsIgnoreCase_Text
            // 
            this.grid_IsIgnoreCase_Text.AppearanceCell.Options.UseTextOptions = true;
            this.grid_IsIgnoreCase_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsIgnoreCase_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_IsIgnoreCase_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsIgnoreCase_Text.Caption = "是否忽略大小写";
            this.grid_IsIgnoreCase_Text.FieldName = "IsIgnoreCase_Text";
            this.grid_IsIgnoreCase_Text.Name = "grid_IsIgnoreCase_Text";
            this.grid_IsIgnoreCase_Text.Visible = true;
            this.grid_IsIgnoreCase_Text.VisibleIndex = 5;
            // 
            // grid_IsWholeMatch_Text
            // 
            this.grid_IsWholeMatch_Text.AppearanceCell.Options.UseTextOptions = true;
            this.grid_IsWholeMatch_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsWholeMatch_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_IsWholeMatch_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsWholeMatch_Text.Caption = "是否整字匹配";
            this.grid_IsWholeMatch_Text.FieldName = "IsWholeMatch_Text";
            this.grid_IsWholeMatch_Text.Name = "grid_IsWholeMatch_Text";
            this.grid_IsWholeMatch_Text.Visible = true;
            this.grid_IsWholeMatch_Text.VisibleIndex = 6;
            // 
            // grid_IsFileName_Text
            // 
            this.grid_IsFileName_Text.AppearanceCell.Options.UseTextOptions = true;
            this.grid_IsFileName_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsFileName_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_IsFileName_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsFileName_Text.Caption = "是否匹配文件名";
            this.grid_IsFileName_Text.FieldName = "IsFileName_Text";
            this.grid_IsFileName_Text.Name = "grid_IsFileName_Text";
            this.grid_IsFileName_Text.Visible = true;
            this.grid_IsFileName_Text.VisibleIndex = 7;
            // 
            // grid_IsFileContent_Text
            // 
            this.grid_IsFileContent_Text.AppearanceCell.Options.UseTextOptions = true;
            this.grid_IsFileContent_Text.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsFileContent_Text.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_IsFileContent_Text.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_IsFileContent_Text.Caption = "是否匹配文件内容";
            this.grid_IsFileContent_Text.FieldName = "IsFileContent_Text";
            this.grid_IsFileContent_Text.Name = "grid_IsFileContent_Text";
            this.grid_IsFileContent_Text.Visible = true;
            this.grid_IsFileContent_Text.VisibleIndex = 8;
            // 
            // grid_CreateTime
            // 
            this.grid_CreateTime.AppearanceCell.Options.UseTextOptions = true;
            this.grid_CreateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_CreateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_CreateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_CreateTime.Caption = "创建时间";
            this.grid_CreateTime.FieldName = "CreateTime";
            this.grid_CreateTime.Name = "grid_CreateTime";
            this.grid_CreateTime.Visible = true;
            this.grid_CreateTime.VisibleIndex = 9;
            // 
            // grid_UpdateTime
            // 
            this.grid_UpdateTime.AppearanceCell.Options.UseTextOptions = true;
            this.grid_UpdateTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_UpdateTime.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_UpdateTime.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_UpdateTime.Caption = "更新时间";
            this.grid_UpdateTime.FieldName = "UpdateTime";
            this.grid_UpdateTime.Name = "grid_UpdateTime";
            this.grid_UpdateTime.Visible = true;
            this.grid_UpdateTime.VisibleIndex = 10;
            // 
            // dgRuleConfig_gridControl
            // 
            this.dgRuleConfig_gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRuleConfig_gridControl.Location = new System.Drawing.Point(3, 3);
            this.dgRuleConfig_gridControl.MainView = this.dataGridRuleConfig;
            this.dgRuleConfig_gridControl.MenuManager = this.barManager1;
            this.dgRuleConfig_gridControl.Name = "dgRuleConfig_gridControl";
            this.dgRuleConfig_gridControl.Size = new System.Drawing.Size(956, 405);
            this.dgRuleConfig_gridControl.TabIndex = 5;
            this.dgRuleConfig_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridRuleConfig});
            // 
            // btnSelectRule
            // 
            this.btnSelectRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectRule.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectRule.ImageOptions.Image")));
            this.btnSelectRule.Location = new System.Drawing.Point(831, 416);
            this.btnSelectRule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectRule.Name = "btnSelectRule";
            this.btnSelectRule.Size = new System.Drawing.Size(125, 43);
            this.btnSelectRule.TabIndex = 1;
            this.btnSelectRule.Text = "选择规则";
            this.btnSelectRule.Click += new System.EventHandler(this.btnSelectRule_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.Location = new System.Drawing.Point(152, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(596, 66);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "开 始 处 理";
            this.btnSave.EnabledChanged += new System.EventHandler(this.btnSave_EnabledChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtOutPutPath
            // 
            this.txtOutPutPath.Location = new System.Drawing.Point(117, 39);
            this.txtOutPutPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOutPutPath.Name = "txtOutPutPath";
            this.txtOutPutPath.Size = new System.Drawing.Size(346, 26);
            this.txtOutPutPath.TabIndex = 0;
            // 
            // btnOutPutPath
            // 
            this.btnOutPutPath.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOutPutPath.ImageOptions.Image")));
            this.btnOutPutPath.Location = new System.Drawing.Point(487, 35);
            this.btnOutPutPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutPutPath.Name = "btnOutPutPath";
            this.btnOutPutPath.Size = new System.Drawing.Size(99, 35);
            this.btnOutPutPath.TabIndex = 1;
            this.btnOutPutPath.Text = "浏览";
            this.btnOutPutPath.Click += new System.EventHandler(this.btnOutPutPath_Click);
            // 
            // btnOpenOutPath
            // 
            this.btnOpenOutPath.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenOutPath.ImageOptions.Image")));
            this.btnOpenOutPath.Location = new System.Drawing.Point(608, 35);
            this.btnOpenOutPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenOutPath.Name = "btnOpenOutPath";
            this.btnOpenOutPath.Size = new System.Drawing.Size(99, 35);
            this.btnOpenOutPath.TabIndex = 2;
            this.btnOpenOutPath.Text = "打开";
            this.btnOpenOutPath.Click += new System.EventHandler(this.btnOpenOutPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "输出目录：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件名前缀：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "文件名后缀：";
            // 
            // txtFileFirstName
            // 
            this.txtFileFirstName.Location = new System.Drawing.Point(117, 169);
            this.txtFileFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileFirstName.Name = "txtFileFirstName";
            this.txtFileFirstName.Size = new System.Drawing.Size(346, 26);
            this.txtFileFirstName.TabIndex = 6;
            // 
            // txtFileLastName
            // 
            this.txtFileLastName.Location = new System.Drawing.Point(587, 169);
            this.txtFileLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileLastName.Name = "txtFileLastName";
            this.txtFileLastName.Size = new System.Drawing.Size(346, 26);
            this.txtFileLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(114, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "若不指定输出目录，则在原文件上直接操作！";
            // 
            // ckExcelOptionIsKeepFormula
            // 
            this.ckExcelOptionIsKeepFormula.AutoSize = true;
            this.ckExcelOptionIsKeepFormula.Location = new System.Drawing.Point(455, 41);
            this.ckExcelOptionIsKeepFormula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckExcelOptionIsKeepFormula.Name = "ckExcelOptionIsKeepFormula";
            this.ckExcelOptionIsKeepFormula.Size = new System.Drawing.Size(375, 22);
            this.ckExcelOptionIsKeepFormula.TabIndex = 1;
            this.ckExcelOptionIsKeepFormula.Text = "保留单元格的公式（忽略替换，最后自动计算公式）";
            this.ckExcelOptionIsKeepFormula.UseVisualStyleBackColor = true;
            // 
            // ckExcelOptionIsKeepDataFormat
            // 
            this.ckExcelOptionIsKeepDataFormat.AutoSize = true;
            this.ckExcelOptionIsKeepDataFormat.Location = new System.Drawing.Point(15, 41);
            this.ckExcelOptionIsKeepDataFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckExcelOptionIsKeepDataFormat.Name = "ckExcelOptionIsKeepDataFormat";
            this.ckExcelOptionIsKeepDataFormat.Size = new System.Drawing.Size(390, 22);
            this.ckExcelOptionIsKeepDataFormat.TabIndex = 0;
            this.ckExcelOptionIsKeepDataFormat.Text = "保留数据格式，若新值无法转为该格式，则忽略该替换";
            this.ckExcelOptionIsKeepDataFormat.UseVisualStyleBackColor = true;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4});
            this.tabPane1.RegularSize = new System.Drawing.Size(982, 523);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(982, 523);
            this.tabPane1.TabIndex = 14;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "第一步，选择待处理文件";
            this.tabNavigationPage1.Controls.Add(this.btnReloadFileList);
            this.tabNavigationPage1.Controls.Add(this.btnClearFileList);
            this.tabNavigationPage1.Controls.Add(this.btnRemove);
            this.tabNavigationPage1.Controls.Add(this.dgFiles_gridControl);
            this.tabNavigationPage1.Controls.Add(this.btnExportWaitFile);
            this.tabNavigationPage1.Controls.Add(this.btnOpenFolderWaitFile);
            this.tabNavigationPage1.Controls.Add(this.btnOpenAWaitFile);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(960, 464);
            // 
            // btnReloadFileList
            // 
            this.btnReloadFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFileList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReloadFileList.ImageOptions.Image")));
            this.btnReloadFileList.Location = new System.Drawing.Point(68, 414);
            this.btnReloadFileList.Name = "btnReloadFileList";
            this.btnReloadFileList.Size = new System.Drawing.Size(143, 43);
            this.btnReloadFileList.TabIndex = 8;
            this.btnReloadFileList.Text = "重载列表文件";
            this.btnReloadFileList.Click += new System.EventHandler(this.btnReloadFileList_Click);
            // 
            // btnClearFileList
            // 
            this.btnClearFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFileList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearFileList.ImageOptions.Image")));
            this.btnClearFileList.Location = new System.Drawing.Point(658, 414);
            this.btnClearFileList.Name = "btnClearFileList";
            this.btnClearFileList.Size = new System.Drawing.Size(143, 43);
            this.btnClearFileList.TabIndex = 7;
            this.btnClearFileList.Text = "清空列表";
            this.btnClearFileList.Click += new System.EventHandler(this.btnClearFileList_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(513, 414);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 43);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "从列表中移除";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnExportWaitFile
            // 
            this.btnExportWaitFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportWaitFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportWaitFile.ImageOptions.Image")));
            this.btnExportWaitFile.Location = new System.Drawing.Point(805, 414);
            this.btnExportWaitFile.Name = "btnExportWaitFile";
            this.btnExportWaitFile.Size = new System.Drawing.Size(143, 43);
            this.btnExportWaitFile.TabIndex = 5;
            this.btnExportWaitFile.Text = "导出结果";
            this.btnExportWaitFile.Click += new System.EventHandler(this.btnExportWaitFile_Click);
            // 
            // btnOpenFolderWaitFile
            // 
            this.btnOpenFolderWaitFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolderWaitFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFolderWaitFile.ImageOptions.Image")));
            this.btnOpenFolderWaitFile.Location = new System.Drawing.Point(364, 414);
            this.btnOpenFolderWaitFile.Name = "btnOpenFolderWaitFile";
            this.btnOpenFolderWaitFile.Size = new System.Drawing.Size(143, 43);
            this.btnOpenFolderWaitFile.TabIndex = 4;
            this.btnOpenFolderWaitFile.Text = "添加文件夹";
            this.btnOpenFolderWaitFile.Click += new System.EventHandler(this.btnOpenFolderWaitFile_Click);
            // 
            // btnOpenAWaitFile
            // 
            this.btnOpenAWaitFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAWaitFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenAWaitFile.ImageOptions.Image")));
            this.btnOpenAWaitFile.Location = new System.Drawing.Point(217, 414);
            this.btnOpenAWaitFile.Name = "btnOpenAWaitFile";
            this.btnOpenAWaitFile.Size = new System.Drawing.Size(143, 43);
            this.btnOpenAWaitFile.TabIndex = 3;
            this.btnOpenAWaitFile.Text = "添加文件";
            this.btnOpenAWaitFile.Click += new System.EventHandler(this.btnOpenAWaitFile_Click);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "第二步，选择查找与替换处理规则";
            this.tabNavigationPage2.Controls.Add(this.dgRuleConfig_gridControl);
            this.tabNavigationPage2.Controls.Add(this.btnSelectRule);
            this.tabNavigationPage2.Controls.Add(this.label5);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(960, 464);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "第三步，设置输出选项";
            this.tabNavigationPage3.Controls.Add(this.groupControl4);
            this.tabNavigationPage3.Controls.Add(this.groupControl2);
            this.tabNavigationPage3.Controls.Add(this.groupControl1);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(960, 464);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.comboxExcelFileFormat);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.comboxWordFileFormat);
            this.groupControl4.Location = new System.Drawing.Point(3, 323);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(954, 83);
            this.groupControl4.TabIndex = 12;
            this.groupControl4.Text = "文件格式转换：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "将处理后的Excel文件转换为：";
            // 
            // comboxExcelFileFormat
            // 
            this.comboxExcelFileFormat.Location = new System.Drawing.Point(661, 35);
            this.comboxExcelFileFormat.Name = "comboxExcelFileFormat";
            this.comboxExcelFileFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboxExcelFileFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboxExcelFileFormat.Size = new System.Drawing.Size(110, 24);
            this.comboxExcelFileFormat.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "将处理后的Word文件转换为：";
            // 
            // comboxWordFileFormat
            // 
            this.comboxWordFileFormat.Location = new System.Drawing.Point(222, 36);
            this.comboxWordFileFormat.Name = "comboxWordFileFormat";
            this.comboxWordFileFormat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboxWordFileFormat.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboxWordFileFormat.Size = new System.Drawing.Size(110, 24);
            this.comboxWordFileFormat.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.ckExcelOptionIsKeepDataFormat);
            this.groupControl2.Controls.Add(this.ckExcelOptionIsKeepFormula);
            this.groupControl2.Location = new System.Drawing.Point(3, 229);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(954, 81);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "Excel处理设置：";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ckKeepDirectory);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.btnOpenOutPath);
            this.groupControl1.Controls.Add(this.txtOutPutPath);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtFileFirstName);
            this.groupControl1.Controls.Add(this.btnOutPutPath);
            this.groupControl1.Controls.Add(this.txtFileLastName);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(954, 213);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "基本设置：";
            // 
            // ckKeepDirectory
            // 
            this.ckKeepDirectory.AutoSize = true;
            this.ckKeepDirectory.Location = new System.Drawing.Point(117, 117);
            this.ckKeepDirectory.Name = "ckKeepDirectory";
            this.ckKeepDirectory.Size = new System.Drawing.Size(195, 22);
            this.ckKeepDirectory.TabIndex = 10;
            this.ckKeepDirectory.Text = "保持原文件路径层级结构";
            this.ckKeepDirectory.UseVisualStyleBackColor = true;
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "第四步，开始处理";
            this.tabNavigationPage4.Controls.Add(this.groupControl3);
            this.tabNavigationPage4.Controls.Add(this.btnSave);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(960, 464);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.txtLog);
            this.groupControl3.Location = new System.Drawing.Point(3, 111);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(954, 350);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "处理日志：";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Index";
            this.Text = "XCLWinKits——Windows软件工具箱   1.4.7，Copyright ©2018 by:XCL Email:x889@z01.com ";
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.contextMenuStrip_LBoxWait.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleConfig_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboxExcelFileFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboxWordFileFormat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tabNavigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_LBoxWait;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全选ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反选ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraGrid.Views.Grid.GridView dgFiles;
        private System.Windows.Forms.TextBox txtLog;
        private DevExpress.XtraEditors.SimpleButton btnSelectRule;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtOutPutPath;
        private DevExpress.XtraEditors.SimpleButton btnOutPutPath;
        private DevExpress.XtraEditors.SimpleButton btnOpenOutPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileFirstName;
        private System.Windows.Forms.TextBox txtFileLastName;
        private DevExpress.XtraGrid.Views.Grid.GridView dataGridRuleConfig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckExcelOptionIsKeepDataFormat;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_FileID;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_FileName;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_Path;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_ExtensionName;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_IsDone_Text;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_ProcessState_Text;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_ProcessDuration;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_ProcessBlockCount;
        private DevExpress.XtraGrid.Columns.GridColumn dgFiles_Remark;
        private System.Windows.Forms.CheckBox ckExcelOptionIsKeepFormula;
        private DevExpress.XtraGrid.Columns.GridColumn grid_RuleConfigID;
        private DevExpress.XtraGrid.Columns.GridColumn grid_Name;
        private DevExpress.XtraGrid.Columns.GridColumn grid_OldContent;
        private DevExpress.XtraGrid.Columns.GridColumn grid_NewContent;
        private DevExpress.XtraGrid.Columns.GridColumn grid_IsRegex_Text;
        private DevExpress.XtraGrid.Columns.GridColumn grid_IsIgnoreCase_Text;
        private DevExpress.XtraGrid.Columns.GridColumn grid_IsWholeMatch_Text;
        private DevExpress.XtraGrid.Columns.GridColumn grid_IsFileName_Text;
        private DevExpress.XtraGrid.Columns.GridColumn grid_IsFileContent_Text;
        private DevExpress.XtraGrid.Columns.GridColumn grid_CreateTime;
        private DevExpress.XtraGrid.Columns.GridColumn grid_UpdateTime;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem 打开文件ToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem 打开文件夹ToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem 导出ToolStripMenuItem;
        private DevExpress.XtraBars.BarButtonItem 退出ToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnExportWaitFile;
        private DevExpress.XtraEditors.SimpleButton btnOpenFolderWaitFile;
        private DevExpress.XtraEditors.SimpleButton btnOpenAWaitFile;
        private DevExpress.XtraGrid.GridControl dgFiles_gridControl;
        private DevExpress.XtraGrid.GridControl dgRuleConfig_gridControl;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit comboxWordFileFormat;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit comboxExcelFileFormat;
        private System.Windows.Forms.CheckBox ckKeepDirectory;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnClearFileList;
        private DevExpress.XtraEditors.SimpleButton btnReloadFileList;
    }
}

