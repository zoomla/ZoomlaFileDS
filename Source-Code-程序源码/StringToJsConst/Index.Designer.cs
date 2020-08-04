namespace StringToJsConst
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
            this.groupBox1 = new DevExpress.XtraEditors.GroupControl();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.groupBox2 = new DevExpress.XtraEditors.GroupControl();
            this.txtNew = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtOld);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "原HTML字符串：";
            // 
            // txtOld
            // 
            this.txtOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOld.Location = new System.Drawing.Point(2, 21);
            this.txtOld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOld.Multiline = true;
            this.txtOld.Name = "txtOld";
            this.txtOld.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOld.Size = new System.Drawing.Size(497, 100);
            this.txtOld.TabIndex = 0;
            this.txtOld.TextChanged += new System.EventHandler(this.txtOld_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtNew);
            this.groupBox2.Location = new System.Drawing.Point(15, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.Text = "转换后的JavaScript常量：";
            // 
            // txtNew
            // 
            this.txtNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNew.Location = new System.Drawing.Point(2, 21);
            this.txtNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNew.Multiline = true;
            this.txtNew.Name = "txtNew";
            this.txtNew.ReadOnly = true;
            this.txtNew.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNew.Size = new System.Drawing.Size(496, 98);
            this.txtNew.TabIndex = 0;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(621, 386);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBox1;
        private DevExpress.XtraEditors.GroupControl groupBox2;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.TextBox txtNew;
    }
}