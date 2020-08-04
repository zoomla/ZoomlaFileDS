namespace XCLNetFileReplace
{
    partial class RuleConfigSelectBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RuleConfigSelectBox));
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
            this.btnSelectAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectNone = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectInverse = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewContent = new System.Windows.Forms.TextBox();
            this.ckIsRegex = new System.Windows.Forms.CheckBox();
            this.ckIsFileContent = new System.Windows.Forms.CheckBox();
            this.ckIsIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckIsFileName = new System.Windows.Forms.CheckBox();
            this.ckIsWholeMatch = new System.Windows.Forms.CheckBox();
            this.txtOldContent = new System.Windows.Forms.TextBox();
            this.txtRuleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.btnInput = new DevExpress.XtraEditors.SimpleButton();
            this.btnRuleOutput = new DevExpress.XtraEditors.SimpleButton();
            this.tabRuleConfig = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabPageAdd = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabPageSelectRule = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleConfig_gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRuleConfig)).BeginInit();
            this.tabRuleConfig.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tabPageSelectRule.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRuleConfig
            // 
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
            this.dataGridRuleConfig.OptionsCustomization.AllowGroup = false;
            this.dataGridRuleConfig.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.dataGridRuleConfig.OptionsSelection.MultiSelect = true;
            this.dataGridRuleConfig.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
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
            this.grid_RuleConfigID.Name = "grid_RuleConfigID";
            this.grid_RuleConfigID.Visible = true;
            this.grid_RuleConfigID.VisibleIndex = 1;
            // 
            // grid_Name
            // 
            this.grid_Name.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_Name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_Name.Caption = "名称";
            this.grid_Name.FieldName = "Name";
            this.grid_Name.Name = "grid_Name";
            this.grid_Name.Visible = true;
            this.grid_Name.VisibleIndex = 2;
            // 
            // grid_OldContent
            // 
            this.grid_OldContent.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_OldContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_OldContent.Caption = "查找内容";
            this.grid_OldContent.FieldName = "OldContent";
            this.grid_OldContent.Name = "grid_OldContent";
            this.grid_OldContent.Visible = true;
            this.grid_OldContent.VisibleIndex = 3;
            // 
            // grid_NewContent
            // 
            this.grid_NewContent.AppearanceHeader.Options.UseTextOptions = true;
            this.grid_NewContent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grid_NewContent.Caption = "替换内容";
            this.grid_NewContent.FieldName = "NewContent";
            this.grid_NewContent.Name = "grid_NewContent";
            this.grid_NewContent.Visible = true;
            this.grid_NewContent.VisibleIndex = 4;
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
            this.grid_IsRegex_Text.VisibleIndex = 5;
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
            this.grid_IsIgnoreCase_Text.VisibleIndex = 6;
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
            this.grid_IsWholeMatch_Text.VisibleIndex = 7;
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
            this.grid_IsFileName_Text.VisibleIndex = 8;
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
            this.grid_IsFileContent_Text.VisibleIndex = 9;
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
            this.grid_CreateTime.VisibleIndex = 10;
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
            this.grid_UpdateTime.VisibleIndex = 11;
            // 
            // dgRuleConfig_gridControl
            // 
            this.dgRuleConfig_gridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRuleConfig_gridControl.Location = new System.Drawing.Point(3, 3);
            this.dgRuleConfig_gridControl.MainView = this.dataGridRuleConfig;
            this.dgRuleConfig_gridControl.Name = "dgRuleConfig_gridControl";
            this.dgRuleConfig_gridControl.Size = new System.Drawing.Size(1211, 500);
            this.dgRuleConfig_gridControl.TabIndex = 13;
            this.dgRuleConfig_gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dataGridRuleConfig});
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAll.ImageOptions.Image")));
            this.btnSelectAll.Location = new System.Drawing.Point(790, 522);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(100, 35);
            this.btnSelectAll.TabIndex = 3;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectNone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectNone.ImageOptions.Image")));
            this.btnSelectNone.Location = new System.Drawing.Point(1006, 522);
            this.btnSelectNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(100, 35);
            this.btnSelectNone.TabIndex = 4;
            this.btnSelectNone.Text = "全不选";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectInverse
            // 
            this.btnSelectInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectInverse.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectInverse.ImageOptions.Image")));
            this.btnSelectInverse.Location = new System.Drawing.Point(898, 522);
            this.btnSelectInverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectInverse.Name = "btnSelectInverse";
            this.btnSelectInverse.Size = new System.Drawing.Size(100, 35);
            this.btnSelectInverse.TabIndex = 5;
            this.btnSelectInverse.Text = "反选";
            this.btnSelectInverse.Click += new System.EventHandler(this.btnSelectInverse_Click);
            // 
            // btnSelectOK
            // 
            this.btnSelectOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectOK.ImageOptions.Image")));
            this.btnSelectOK.Location = new System.Drawing.Point(1114, 522);
            this.btnSelectOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectOK.Name = "btnSelectOK";
            this.btnSelectOK.Size = new System.Drawing.Size(100, 35);
            this.btnSelectOK.TabIndex = 6;
            this.btnSelectOK.Text = "选好了";
            this.btnSelectOK.Click += new System.EventHandler(this.btnSelectOK_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(4, 522);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加新规则";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(132, 522);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "修改规则";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.Image")));
            this.btnDel.Location = new System.Drawing.Point(260, 522);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 35);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "删除规则";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(1084, 510);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 47);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存规则";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "规则ID：";
            // 
            // txtNewContent
            // 
            this.txtNewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewContent.Location = new System.Drawing.Point(2, 26);
            this.txtNewContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewContent.Multiline = true;
            this.txtNewContent.Name = "txtNewContent";
            this.txtNewContent.Size = new System.Drawing.Size(1208, 186);
            this.txtNewContent.TabIndex = 0;
            // 
            // ckIsRegex
            // 
            this.ckIsRegex.AutoSize = true;
            this.ckIsRegex.Location = new System.Drawing.Point(10, 159);
            this.ckIsRegex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsRegex.Name = "ckIsRegex";
            this.ckIsRegex.Size = new System.Drawing.Size(105, 22);
            this.ckIsRegex.TabIndex = 12;
            this.ckIsRegex.Text = "正则表达式";
            this.ckIsRegex.UseVisualStyleBackColor = true;
            this.ckIsRegex.CheckedChanged += new System.EventHandler(this.ckIsRegex_CheckedChanged);
            // 
            // ckIsFileContent
            // 
            this.ckIsFileContent.AutoSize = true;
            this.ckIsFileContent.Location = new System.Drawing.Point(492, 159);
            this.ckIsFileContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsFileContent.Name = "ckIsFileContent";
            this.ckIsFileContent.Size = new System.Drawing.Size(90, 22);
            this.ckIsFileContent.TabIndex = 16;
            this.ckIsFileContent.Text = "文件内容";
            this.ckIsFileContent.UseVisualStyleBackColor = true;
            this.ckIsFileContent.CheckedChanged += new System.EventHandler(this.ckIsFileContent_CheckedChanged);
            // 
            // ckIsIgnoreCase
            // 
            this.ckIsIgnoreCase.AutoSize = true;
            this.ckIsIgnoreCase.Location = new System.Drawing.Point(132, 159);
            this.ckIsIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsIgnoreCase.Name = "ckIsIgnoreCase";
            this.ckIsIgnoreCase.Size = new System.Drawing.Size(105, 22);
            this.ckIsIgnoreCase.TabIndex = 13;
            this.ckIsIgnoreCase.Text = "忽略大小写";
            this.ckIsIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ckIsFileName
            // 
            this.ckIsFileName.AutoSize = true;
            this.ckIsFileName.Location = new System.Drawing.Point(370, 159);
            this.ckIsFileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsFileName.Name = "ckIsFileName";
            this.ckIsFileName.Size = new System.Drawing.Size(75, 22);
            this.ckIsFileName.TabIndex = 15;
            this.ckIsFileName.Text = "文件名";
            this.ckIsFileName.UseVisualStyleBackColor = true;
            this.ckIsFileName.CheckedChanged += new System.EventHandler(this.ckIsFileName_CheckedChanged);
            // 
            // ckIsWholeMatch
            // 
            this.ckIsWholeMatch.AutoSize = true;
            this.ckIsWholeMatch.Location = new System.Drawing.Point(253, 159);
            this.ckIsWholeMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIsWholeMatch.Name = "ckIsWholeMatch";
            this.ckIsWholeMatch.Size = new System.Drawing.Size(90, 22);
            this.ckIsWholeMatch.TabIndex = 14;
            this.ckIsWholeMatch.Text = "整字匹配";
            this.ckIsWholeMatch.UseVisualStyleBackColor = true;
            this.ckIsWholeMatch.CheckedChanged += new System.EventHandler(this.ckIsWholeMatch_CheckedChanged);
            // 
            // txtOldContent
            // 
            this.txtOldContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldContent.Location = new System.Drawing.Point(2, 22);
            this.txtOldContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOldContent.Multiline = true;
            this.txtOldContent.Name = "txtOldContent";
            this.txtOldContent.Size = new System.Drawing.Size(1208, 127);
            this.txtOldContent.TabIndex = 0;
            // 
            // txtRuleID
            // 
            this.txtRuleID.Enabled = false;
            this.txtRuleID.Location = new System.Drawing.Point(433, 20);
            this.txtRuleID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleID.Name = "txtRuleID";
            this.txtRuleID.Size = new System.Drawing.Size(132, 26);
            this.txtRuleID.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "规则名：";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Location = new System.Drawing.Point(92, 20);
            this.txtRuleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(220, 26);
            this.txtRuleName.TabIndex = 4;
            // 
            // btnInput
            // 
            this.btnInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnInput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInput.ImageOptions.Image")));
            this.btnInput.Location = new System.Drawing.Point(516, 522);
            this.btnInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(120, 35);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "导入规则";
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnRuleOutput
            // 
            this.btnRuleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRuleOutput.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRuleOutput.ImageOptions.Image")));
            this.btnRuleOutput.Location = new System.Drawing.Point(388, 522);
            this.btnRuleOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRuleOutput.Name = "btnRuleOutput";
            this.btnRuleOutput.Size = new System.Drawing.Size(120, 35);
            this.btnRuleOutput.TabIndex = 10;
            this.btnRuleOutput.Text = "导出规则";
            this.btnRuleOutput.Click += new System.EventHandler(this.btnRuleOutput_Click);
            // 
            // tabRuleConfig
            // 
            this.tabRuleConfig.Controls.Add(this.tabPageAdd);
            this.tabRuleConfig.Controls.Add(this.tabPageSelectRule);
            this.tabRuleConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRuleConfig.Location = new System.Drawing.Point(0, 0);
            this.tabRuleConfig.Name = "tabRuleConfig";
            this.tabRuleConfig.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabPageSelectRule,
            this.tabPageAdd});
            this.tabRuleConfig.RegularSize = new System.Drawing.Size(1240, 645);
            this.tabRuleConfig.SelectedPage = this.tabPageSelectRule;
            this.tabRuleConfig.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.tabRuleConfig.Size = new System.Drawing.Size(1240, 645);
            this.tabRuleConfig.TabIndex = 11;
            this.tabRuleConfig.Text = "tabPane1";
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Caption = "添加或修改规则";
            this.tabPageAdd.Controls.Add(this.groupControl2);
            this.tabPageAdd.Controls.Add(this.groupControl1);
            this.tabPageAdd.Controls.Add(this.btnSave);
            this.tabPageAdd.Controls.Add(this.label2);
            this.tabPageAdd.Controls.Add(this.label1);
            this.tabPageAdd.Controls.Add(this.txtRuleName);
            this.tabPageAdd.Controls.Add(this.txtRuleID);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Size = new System.Drawing.Size(1218, 586);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtNewContent);
            this.groupControl2.Location = new System.Drawing.Point(3, 273);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1212, 214);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "替换内容：";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ckIsRegex);
            this.groupControl1.Controls.Add(this.ckIsFileContent);
            this.groupControl1.Controls.Add(this.txtOldContent);
            this.groupControl1.Controls.Add(this.ckIsIgnoreCase);
            this.groupControl1.Controls.Add(this.ckIsWholeMatch);
            this.groupControl1.Controls.Add(this.ckIsFileName);
            this.groupControl1.Location = new System.Drawing.Point(3, 74);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1210, 193);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "查找内容：";
            // 
            // tabPageSelectRule
            // 
            this.tabPageSelectRule.Caption = "选择规则";
            this.tabPageSelectRule.Controls.Add(this.btnInput);
            this.tabPageSelectRule.Controls.Add(this.dgRuleConfig_gridControl);
            this.tabPageSelectRule.Controls.Add(this.btnRuleOutput);
            this.tabPageSelectRule.Controls.Add(this.btnUpdate);
            this.tabPageSelectRule.Controls.Add(this.btnDel);
            this.tabPageSelectRule.Controls.Add(this.btnSelectInverse);
            this.tabPageSelectRule.Controls.Add(this.btnSelectOK);
            this.tabPageSelectRule.Controls.Add(this.btnSelectAll);
            this.tabPageSelectRule.Controls.Add(this.btnSelectNone);
            this.tabPageSelectRule.Controls.Add(this.btnAdd);
            this.tabPageSelectRule.Name = "tabPageSelectRule";
            this.tabPageSelectRule.Size = new System.Drawing.Size(1218, 586);
            // 
            // RuleConfigSelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 645);
            this.Controls.Add(this.tabRuleConfig);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1255, 691);
            this.Name = "RuleConfigSelectBox";
            this.Text = "RuleConfigSelectBox";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RuleConfigSelectBox_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRuleConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRuleConfig_gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabRuleConfig)).EndInit();
            this.tabRuleConfig.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.tabPageSelectRule.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void DataGridRuleConfig_AsyncCompleted(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView dataGridRuleConfig;
        private DevExpress.XtraEditors.SimpleButton btnSelectAll;
        private DevExpress.XtraEditors.SimpleButton btnSelectNone;
        private DevExpress.XtraEditors.SimpleButton btnSelectInverse;
        private DevExpress.XtraEditors.SimpleButton btnSelectOK;
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
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuleName;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private System.Windows.Forms.TextBox txtNewContent;
        private System.Windows.Forms.CheckBox ckIsFileContent;
        private System.Windows.Forms.CheckBox ckIsFileName;
        private System.Windows.Forms.CheckBox ckIsWholeMatch;
        private System.Windows.Forms.CheckBox ckIsIgnoreCase;
        private System.Windows.Forms.CheckBox ckIsRegex;
        private System.Windows.Forms.TextBox txtOldContent;
        private DevExpress.XtraEditors.SimpleButton btnRuleOutput;
        private DevExpress.XtraEditors.SimpleButton btnInput;
        private DevExpress.XtraBars.Navigation.TabPane tabRuleConfig;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageAdd;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPageSelectRule;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgRuleConfig_gridControl;
    }
}