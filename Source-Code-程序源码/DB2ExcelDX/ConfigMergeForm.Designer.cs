namespace DB2ExcelDX
{
    partial class ConfigMergeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigMergeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cloudVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cloudScriptCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.localVersion = new System.Windows.Forms.Label();
            this.localScriptCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.autoMerge = new System.Windows.Forms.RadioButton();
            this.overwriteLocalFile = new System.Windows.Forms.RadioButton();
            this.doNothing = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "有配置文件可更新";
            // 
            // cloudVersion
            // 
            this.cloudVersion.AutoSize = true;
            this.cloudVersion.Location = new System.Drawing.Point(144, 59);
            this.cloudVersion.Name = "cloudVersion";
            this.cloudVersion.Size = new System.Drawing.Size(29, 12);
            this.cloudVersion.TabIndex = 1;
            this.cloudVersion.Text = "v1.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "云配置版本";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "云配置脚本数";
            // 
            // cloudScriptCount
            // 
            this.cloudScriptCount.AutoSize = true;
            this.cloudScriptCount.Location = new System.Drawing.Point(144, 80);
            this.cloudScriptCount.Name = "cloudScriptCount";
            this.cloudScriptCount.Size = new System.Drawing.Size(29, 12);
            this.cloudScriptCount.TabIndex = 1;
            this.cloudScriptCount.Text = "12条";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "本地配置版本";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "本地配置脚本数";
            // 
            // localVersion
            // 
            this.localVersion.AutoSize = true;
            this.localVersion.Location = new System.Drawing.Point(323, 59);
            this.localVersion.Name = "localVersion";
            this.localVersion.Size = new System.Drawing.Size(29, 12);
            this.localVersion.TabIndex = 1;
            this.localVersion.Text = "v1.1";
            // 
            // localScriptCount
            // 
            this.localScriptCount.AutoSize = true;
            this.localScriptCount.Location = new System.Drawing.Point(323, 80);
            this.localScriptCount.Name = "localScriptCount";
            this.localScriptCount.Size = new System.Drawing.Size(29, 12);
            this.localScriptCount.TabIndex = 1;
            this.localScriptCount.Text = "12条";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.autoMerge);
            this.groupBox1.Controls.Add(this.overwriteLocalFile);
            this.groupBox1.Controls.Add(this.doNothing);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(44, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autoMerge
            // 
            this.autoMerge.AutoSize = true;
            this.autoMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoMerge.Location = new System.Drawing.Point(218, 20);
            this.autoMerge.Name = "autoMerge";
            this.autoMerge.Size = new System.Drawing.Size(71, 16);
            this.autoMerge.TabIndex = 0;
            this.autoMerge.TabStop = true;
            this.autoMerge.Text = "智能合并";
            this.toolTip1.SetToolTip(this.autoMerge, "根据如下规则进行合并:\r\n             1. 如果云端数据源和本地数据源同源(ip,user,pwd 均一致),则将云端数据源覆盖本地数据源\r\n   " +
        "          2. 如果云端数据源和本地数据源同id,则将本地数据源id更换,于此数据源关联的脚本同样操作\r\n             3. 如果云端的脚" +
        "本和本地脚本重名,则本地脚本重命名,重命名规则为  原名+随机数字");
            this.autoMerge.UseVisualStyleBackColor = true;
            // 
            // overwriteLocalFile
            // 
            this.overwriteLocalFile.AutoSize = true;
            this.overwriteLocalFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.overwriteLocalFile.Location = new System.Drawing.Point(105, 21);
            this.overwriteLocalFile.Name = "overwriteLocalFile";
            this.overwriteLocalFile.Size = new System.Drawing.Size(95, 16);
            this.overwriteLocalFile.TabIndex = 0;
            this.overwriteLocalFile.TabStop = true;
            this.overwriteLocalFile.Text = "覆盖本地文件";
            this.toolTip1.SetToolTip(this.overwriteLocalFile, "使用最新的云端配置文件,本地的进程将完全删除!");
            this.overwriteLocalFile.UseVisualStyleBackColor = true;
            // 
            // doNothing
            // 
            this.doNothing.AutoSize = true;
            this.doNothing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doNothing.Location = new System.Drawing.Point(16, 21);
            this.doNothing.Name = "doNothing";
            this.doNothing.Size = new System.Drawing.Size(71, 16);
            this.doNothing.TabIndex = 0;
            this.doNothing.TabStop = true;
            this.doNothing.Text = "暂不更新";
            this.toolTip1.SetToolTip(this.doNothing, "暂时忽略本次更新,继续使用以前的配置");
            this.doNothing.UseVisualStyleBackColor = true;
            // 
            // ConfigMergeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 227);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.localScriptCount);
            this.Controls.Add(this.localVersion);
            this.Controls.Add(this.cloudScriptCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cloudVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigMergeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置中心";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cloudVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cloudScriptCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label localVersion;
        private System.Windows.Forms.Label localScriptCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton autoMerge;
        private System.Windows.Forms.RadioButton overwriteLocalFile;
        private System.Windows.Forms.RadioButton doNothing;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Button button1;
    }
}