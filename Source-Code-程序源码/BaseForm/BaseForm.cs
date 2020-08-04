using System;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BaseForm
{
    public class BaseFormClass : DevExpress.XtraEditors.XtraForm
    {
        private string _getRemark = string.Empty;

        public BaseFormClass()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 说明信息
        /// </summary>
        private string GetRemark
        {
            get
            {
                if (string.IsNullOrEmpty(this._getRemark))
                {
                    StringBuilder str = new StringBuilder();
                    Assembly asm = Assembly.GetExecutingAssembly();
                    System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(asm.Location);
                    string subName = string.Empty;
                    if (!string.IsNullOrEmpty(this.SubAssemblyName))
                    {
                        subName = string.Format("【{0}】", CommonHelper.ConfigHelper.GetCategoryNameInfo(this.SubAssemblyName));
                    }
                    str.AppendFormat("{0} {1}  {2}，{3} ", fvi.FileDescription, subName, fvi.FileVersion, fvi.LegalCopyright);
                    this._getRemark = str.ToString();
                }
                return this._getRemark;
            }
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormClass));
            this.SuspendLayout();
            // 
            // BaseFormClass
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2010 Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "BaseFormClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BaseFormClass_Load);
            this.ResumeLayout(false);

        }

        private void BaseFormClass_Load(object sender, EventArgs e)
        {
            this.Text = this.GetRemark;
            this.LoopControls(this);
        }

        /// <summary>
        /// 子窗体名字
        /// </summary>
        public virtual string SubAssemblyName
        {
            get;
            set;
        }

        private void LoopControls(Control parent)
        {
            if (parent.Controls.Count > 0)
            {
                foreach (Control m in parent.Controls)
                {
                    if (m is TextBox)
                    {
                        TextBox tbox = (TextBox)m;
                        tbox.KeyDown += new KeyEventHandler(CommonHelper.CommonEvent.SetTextBoxSelectAllEvent);
                        if (tbox.MaxLength == Int16.MaxValue)
                        {
                            tbox.MaxLength = int.MaxValue;
                        }
                    }
                    if (m.HasChildren)
                    {
                        this.LoopControls(m);
                    }
                }
            }
        }
    }
}