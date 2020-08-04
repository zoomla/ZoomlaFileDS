namespace CodingConvert
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
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox3 = new DevExpress.XtraEditors.GroupControl();
            this.btnDecode = new DevExpress.XtraEditors.SimpleButton();
            this.btnEncode = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.commboxCodingName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtInputString);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "编码前：";
            // 
            // txtInputString
            // 
            this.txtInputString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputString.Location = new System.Drawing.Point(2, 26);
            this.txtInputString.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputString.Multiline = true;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInputString.Size = new System.Drawing.Size(659, 158);
            this.txtInputString.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(17, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "编码后：";
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(2, 26);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(366, 167);
            this.txtResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnDecode);
            this.groupBox3.Controls.Add(this.btnEncode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.commboxCodingName);
            this.groupBox3.Location = new System.Drawing.Point(395, 205);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.Text = "操作：";
            // 
            // btnDecode
            // 
            this.btnDecode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDecode.ImageOptions.Image")));
            this.btnDecode.Location = new System.Drawing.Point(171, 125);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(100, 34);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "解码";
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEncode.ImageOptions.Image")));
            this.btnEncode.Location = new System.Drawing.Point(63, 125);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(100, 34);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "编码";
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "类型：";
            // 
            // commboxCodingName
            // 
            this.commboxCodingName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commboxCodingName.FormattingEnabled = true;
            this.commboxCodingName.Location = new System.Drawing.Point(63, 61);
            this.commboxCodingName.Margin = new System.Windows.Forms.Padding(4);
            this.commboxCodingName.Name = "commboxCodingName";
            this.commboxCodingName.Size = new System.Drawing.Size(208, 26);
            this.commboxCodingName.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(715, 455);
            this.Name = "Index";
            this.Text = "Index";
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.GroupControl groupBox2;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.TextBox txtResult;
        private DevExpress.XtraEditors.GroupControl groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox commboxCodingName;
        private DevExpress.XtraEditors.SimpleButton btnDecode;
        private DevExpress.XtraEditors.SimpleButton btnEncode;
    }
}