namespace DB2ExcelDX
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSourceGroup = new System.Windows.Forms.GroupBox();
            this.btnConnectTest = new System.Windows.Forms.Button();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveScript = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnSqlTest = new System.Windows.Forms.Button();
            this.sqlBox = new System.Windows.Forms.TextBox();
            this.stepControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataFormatTable = new System.Windows.Forms.DataGridView();
            this.state = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.savedScriptGroup = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.scriptList = new System.Windows.Forms.ComboBox();
            this.btnLoadScript = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.dataSourceGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.stepControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFormatTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.savedScriptGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSourceGroup
            // 
            this.dataSourceGroup.Controls.Add(this.btnConnectTest);
            this.dataSourceGroup.Controls.Add(this.pwdBox);
            this.dataSourceGroup.Controls.Add(this.userBox);
            this.dataSourceGroup.Controls.Add(this.ipBox);
            this.dataSourceGroup.Controls.Add(this.label3);
            this.dataSourceGroup.Controls.Add(this.label2);
            this.dataSourceGroup.Controls.Add(this.label1);
            this.dataSourceGroup.Location = new System.Drawing.Point(18, 15);
            this.dataSourceGroup.Name = "dataSourceGroup";
            this.dataSourceGroup.Size = new System.Drawing.Size(237, 175);
            this.dataSourceGroup.TabIndex = 0;
            this.dataSourceGroup.TabStop = false;
            this.dataSourceGroup.Text = "数据源";
            // 
            // btnConnectTest
            // 
            this.btnConnectTest.Location = new System.Drawing.Point(106, 129);
            this.btnConnectTest.Name = "btnConnectTest";
            this.btnConnectTest.Size = new System.Drawing.Size(98, 33);
            this.btnConnectTest.TabIndex = 3;
            this.btnConnectTest.Text = "建立连接";
            this.btnConnectTest.UseVisualStyleBackColor = true;
            this.btnConnectTest.Click += new System.EventHandler(this.btnConnectTest_Click);
            // 
            // pwdBox
            // 
            this.pwdBox.Location = new System.Drawing.Point(67, 101);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(137, 22);
            this.pwdBox.TabIndex = 2;
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(67, 62);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(137, 22);
            this.userBox.TabIndex = 1;
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(67, 27);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(137, 22);
            this.ipBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "登录名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 126);
            this.label4.TabIndex = 4;
            this.label4.Text = "1. 首先设置数据源,设置完成后 测试连接 按钮,\r\n    测试通过后进行下一步\r\n\r\n2. 选择可导出的数据库\r\n\r\n3. 编辑脚本(需要一定的数据库基础)," +
    "\r\n    完成后点击测试脚本按钮\r\n\r\n4. 脚本测试通过后,点击保存按钮";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(18, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库";
            // 
            // dbList
            // 
            this.dbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbList.Enabled = false;
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(118, 32);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(165, 22);
            this.dbList.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "可导出的数据库";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveScript);
            this.groupBox2.Controls.Add(this.btnNextStep);
            this.groupBox2.Controls.Add(this.btnSqlTest);
            this.groupBox2.Controls.Add(this.sqlBox);
            this.groupBox2.Location = new System.Drawing.Point(18, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "sql脚本";
            // 
            // btnSaveScript
            // 
            this.btnSaveScript.Location = new System.Drawing.Point(487, 128);
            this.btnSaveScript.Name = "btnSaveScript";
            this.btnSaveScript.Size = new System.Drawing.Size(98, 33);
            this.btnSaveScript.TabIndex = 9;
            this.btnSaveScript.Text = "保存脚本";
            this.btnSaveScript.UseVisualStyleBackColor = true;
            this.btnSaveScript.Click += new System.EventHandler(this.btnSaveScript_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(6, 128);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(98, 33);
            this.btnNextStep.TabIndex = 7;
            this.btnNextStep.Text = "返回";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnSqlTest
            // 
            this.btnSqlTest.Location = new System.Drawing.Point(353, 128);
            this.btnSqlTest.Name = "btnSqlTest";
            this.btnSqlTest.Size = new System.Drawing.Size(98, 33);
            this.btnSqlTest.TabIndex = 6;
            this.btnSqlTest.Text = "测试脚本";
            this.btnSqlTest.UseVisualStyleBackColor = true;
            this.btnSqlTest.Click += new System.EventHandler(this.btnSqlTest_Click);
            // 
            // sqlBox
            // 
            this.sqlBox.Location = new System.Drawing.Point(6, 21);
            this.sqlBox.Multiline = true;
            this.sqlBox.Name = "sqlBox";
            this.sqlBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlBox.Size = new System.Drawing.Size(579, 75);
            this.sqlBox.TabIndex = 5;
            // 
            // stepControl
            // 
            this.stepControl.Controls.Add(this.tabPage1);
            this.stepControl.Controls.Add(this.tabPage2);
            this.stepControl.Controls.Add(this.tabPage3);
            this.stepControl.Location = new System.Drawing.Point(12, 12);
            this.stepControl.Name = "stepControl";
            this.stepControl.SelectedIndex = 0;
            this.stepControl.Size = new System.Drawing.Size(653, 504);
            this.stepControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.dataSourceGroup);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(645, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "自定义脚本";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(332, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 175);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "使用提示";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(645, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置数据格式";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataFormatTable);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(17, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 441);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据格式";
            // 
            // dataFormatTable
            // 
            this.dataFormatTable.AllowUserToAddRows = false;
            this.dataFormatTable.AllowUserToDeleteRows = false;
            this.dataFormatTable.AllowUserToResizeColumns = false;
            this.dataFormatTable.AllowUserToResizeRows = false;
            this.dataFormatTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataFormatTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFormatTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataFormatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFormatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.state,
            this.name,
            this.type,
            this.width,
            this.columnName});
            this.dataFormatTable.Location = new System.Drawing.Point(6, 21);
            this.dataFormatTable.Name = "dataFormatTable";
            this.dataFormatTable.RowHeadersVisible = false;
            this.dataFormatTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataFormatTable.RowTemplate.Height = 23;
            this.dataFormatTable.Size = new System.Drawing.Size(594, 351);
            this.dataFormatTable.TabIndex = 0;
            this.dataFormatTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFormatTable_CellContentClick);
            // 
            // state
            // 
            this.state.HeaderText = "选中状态";
            this.state.Name = "state";
            // 
            // name
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.name.DefaultCellStyle = dataGridViewCellStyle22;
            this.name.HeaderText = "默认名称";
            this.name.Name = "name";
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // type
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.type.DefaultCellStyle = dataGridViewCellStyle23;
            this.type.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.type.HeaderText = "默认类型";
            this.type.Name = "type";
            // 
            // width
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.width.DefaultCellStyle = dataGridViewCellStyle24;
            this.width.HeaderText = "默认宽度";
            this.width.Name = "width";
            this.width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnName
            // 
            this.columnName.HeaderText = "数据库列名";
            this.columnName.Name = "columnName";
            this.columnName.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(502, 387);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 33);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.savedScriptGroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(645, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "脚本列表";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.savePathLabel);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(131, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 157);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "使用帮助";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(270, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "这里";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 14);
            this.label10.TabIndex = 0;
            this.label10.Text = "3. 如果您有其他的网络数据源可以导入,请点击";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "2. 如果内置脚本不能满足需求的话,可以自定义脚本";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 14);
            this.label7.TabIndex = 0;
            this.label7.Text = "1.  工具内置了部分脚本";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(131, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 81);
            this.panel1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(8, 0);
            this.linkLabel1.Location = new System.Drawing.Point(229, 60);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 19);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.Text = "https://www.z01.com";
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("逐浪小霞硬楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "逐浪DBA数据大师";
            // 
            // savedScriptGroup
            // 
            this.savedScriptGroup.Controls.Add(this.label9);
            this.savedScriptGroup.Controls.Add(this.button3);
            this.savedScriptGroup.Controls.Add(this.scriptList);
            this.savedScriptGroup.Controls.Add(this.btnLoadScript);
            this.savedScriptGroup.Location = new System.Drawing.Point(131, 137);
            this.savedScriptGroup.Name = "savedScriptGroup";
            this.savedScriptGroup.Size = new System.Drawing.Size(374, 121);
            this.savedScriptGroup.TabIndex = 4;
            this.savedScriptGroup.TabStop = false;
            this.savedScriptGroup.Text = "可操作数据进程:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(158, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "X";
            this.toolTip1.SetToolTip(this.label9, "删除此进程");
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(296, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "配置中心";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // scriptList
            // 
            this.scriptList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scriptList.FormattingEnabled = true;
            this.scriptList.Location = new System.Drawing.Point(22, 47);
            this.scriptList.Name = "scriptList";
            this.scriptList.Size = new System.Drawing.Size(130, 22);
            this.scriptList.TabIndex = 7;
            // 
            // btnLoadScript
            // 
            this.btnLoadScript.Location = new System.Drawing.Point(183, 42);
            this.btnLoadScript.Name = "btnLoadScript";
            this.btnLoadScript.Size = new System.Drawing.Size(98, 33);
            this.btnLoadScript.TabIndex = 8;
            this.btnLoadScript.Text = "开始操作";
            this.btnLoadScript.UseVisualStyleBackColor = true;
            this.btnLoadScript.Click += new System.EventHandler(this.btnLoadScript_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 14);
            this.label12.TabIndex = 3;
            this.label12.Text = " 4. 当前保存路径为";
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePathLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.savePathLabel.Location = new System.Drawing.Point(128, 111);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(132, 14);
            this.savePathLabel.TabIndex = 4;
            this.savePathLabel.Text = "D:\\数据导出   点击更改";
            this.toolTip1.SetToolTip(this.savePathLabel, "点击更改默认保存路径");
            this.savePathLabel.Click += new System.EventHandler(this.label13_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 607);
            this.Controls.Add(this.stepControl);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Index";
            this.Text = "数据库导出工具";
            this.Load += new System.EventHandler(this.Index_Load);
            this.dataSourceGroup.ResumeLayout(false);
            this.dataSourceGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.stepControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataFormatTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.savedScriptGroup.ResumeLayout(false);
            this.savedScriptGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dataSourceGroup;
        private System.Windows.Forms.Button btnConnectTest;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox dbList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox sqlBox;
        private System.Windows.Forms.Button btnSqlTest;
        private System.Windows.Forms.TabControl stepControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveScript;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataFormatTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox savedScriptGroup;
        private System.Windows.Forms.ComboBox scriptList;
        private System.Windows.Forms.Button btnLoadScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label label12;
    }
}

