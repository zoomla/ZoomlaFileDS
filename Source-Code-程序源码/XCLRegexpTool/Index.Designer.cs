namespace XCLRegexpTool
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.txtInputRegexp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReplaceResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new DevExpress.XtraEditors.GroupControl();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.groupBox4 = new DevExpress.XtraEditors.GroupControl();
            this.ckMutipLine = new System.Windows.Forms.CheckBox();
            this.ckIgnoreCase = new System.Windows.Forms.CheckBox();
            this.ckAnyTime = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new DevExpress.XtraEditors.GroupControl();
            this.txtReplaceString = new System.Windows.Forms.TextBox();
            this.groupBox6 = new DevExpress.XtraEditors.GroupControl();
            this.txtFindResult = new System.Windows.Forms.TextBox();
            this.lbMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInputRegexp);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "请输入正则表达式：";
            // 
            // txtInputRegexp
            // 
            this.txtInputRegexp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputRegexp.Location = new System.Drawing.Point(2, 26);
            this.txtInputRegexp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputRegexp.Multiline = true;
            this.txtInputRegexp.Name = "txtInputRegexp";
            this.txtInputRegexp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputRegexp.Size = new System.Drawing.Size(567, 46);
            this.txtInputRegexp.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(464, 362);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "替换后的结果：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.txtReplaceResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.06061F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(510, 156);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtReplaceResult
            // 
            this.txtReplaceResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplaceResult.Location = new System.Drawing.Point(4, 5);
            this.txtReplaceResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReplaceResult.Multiline = true;
            this.txtReplaceResult.Name = "txtReplaceResult";
            this.txtReplaceResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceResult.Size = new System.Drawing.Size(357, 146);
            this.txtReplaceResult.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(369, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 146);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(13, 87);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "导出结果";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOK
            // 
            this.btnOK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.ImageOptions.Image")));
            this.btnOK.Location = new System.Drawing.Point(13, 22);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 42);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "执行";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtInputString);
            this.groupBox3.Location = new System.Drawing.Point(12, 100);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "待处理文本：";
            // 
            // txtInputString
            // 
            this.txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputString.Location = new System.Drawing.Point(2, 26);
            this.txtInputString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputString.Size = new System.Drawing.Size(962, 84);
            this.txtInputString.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ckMutipLine);
            this.groupBox4.Controls.Add(this.ckIgnoreCase);
            this.groupBox4.Controls.Add(this.ckAnyTime);
            this.groupBox4.Location = new System.Drawing.Point(591, 18);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(387, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.Text = "选项：";
            // 
            // ckMutipLine
            // 
            this.ckMutipLine.AutoSize = true;
            this.ckMutipLine.Location = new System.Drawing.Point(236, 34);
            this.ckMutipLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckMutipLine.Name = "ckMutipLine";
            this.ckMutipLine.Size = new System.Drawing.Size(90, 22);
            this.ckMutipLine.TabIndex = 8;
            this.ckMutipLine.Text = "多行匹配";
            this.ckMutipLine.UseVisualStyleBackColor = true;
            // 
            // ckIgnoreCase
            // 
            this.ckIgnoreCase.AutoSize = true;
            this.ckIgnoreCase.Location = new System.Drawing.Point(116, 34);
            this.ckIgnoreCase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckIgnoreCase.Name = "ckIgnoreCase";
            this.ckIgnoreCase.Size = new System.Drawing.Size(105, 22);
            this.ckIgnoreCase.TabIndex = 7;
            this.ckIgnoreCase.Text = "忽略大小写";
            this.ckIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // ckAnyTime
            // 
            this.ckAnyTime.AutoSize = true;
            this.ckAnyTime.Location = new System.Drawing.Point(25, 34);
            this.ckAnyTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckAnyTime.Name = "ckAnyTime";
            this.ckAnyTime.Size = new System.Drawing.Size(90, 22);
            this.ckAnyTime.TabIndex = 5;
            this.ckAnyTime.Text = "实时匹配";
            this.ckAnyTime.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtReplaceString);
            this.groupBox5.Location = new System.Drawing.Point(12, 221);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(966, 113);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.Text = "将匹配到的结果替换为：";
            // 
            // txtReplaceString
            // 
            this.txtReplaceString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplaceString.Location = new System.Drawing.Point(2, 26);
            this.txtReplaceString.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReplaceString.Multiline = true;
            this.txtReplaceString.Name = "txtReplaceString";
            this.txtReplaceString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReplaceString.Size = new System.Drawing.Size(962, 85);
            this.txtReplaceString.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.txtFindResult);
            this.groupBox6.Location = new System.Drawing.Point(12, 362);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(444, 184);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.Text = "匹配项：";
            // 
            // txtFindResult
            // 
            this.txtFindResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindResult.Location = new System.Drawing.Point(2, 26);
            this.txtFindResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindResult.Multiline = true;
            this.txtFindResult.Name = "txtFindResult";
            this.txtFindResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFindResult.Size = new System.Drawing.Size(440, 156);
            this.txtFindResult.TabIndex = 0;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(16, 339);
            this.lbMsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(44, 18);
            this.lbMsg.TabIndex = 6;
            this.lbMsg.Text = "label1";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Index";
            this.Text = "XCLWinKits——Windows软件工具箱   1.4.7，Copyright ©2018 by:XCL Email:x889@z01.com ";
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox4)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox5)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox6)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.GroupControl groupBox2;
        private System.Windows.Forms.TextBox txtInputRegexp;
        private DevExpress.XtraEditors.GroupControl groupBox3;
        private System.Windows.Forms.TextBox txtInputString;
        private DevExpress.XtraEditors.GroupControl groupBox4;
        private System.Windows.Forms.CheckBox ckAnyTime;
        private DevExpress.XtraEditors.GroupControl groupBox5;
        private System.Windows.Forms.TextBox txtReplaceString;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtReplaceResult;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupBox6;
        private System.Windows.Forms.TextBox txtFindResult;
        private System.Windows.Forms.Label lbMsg;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private System.Windows.Forms.CheckBox ckIgnoreCase;
        private System.Windows.Forms.CheckBox ckMutipLine;
    }
}