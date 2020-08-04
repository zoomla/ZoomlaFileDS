using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace MD5Tool
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInputString.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入待处理内容！", "系统提示");
                return;
            }
            List<string> lstStr = new List<string>();
            byte[] inputBytes = Encoding.Default.GetBytes(this.txtInputString.Text);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] outputBytes = md5.ComputeHash(inputBytes);
            string result = string.Empty;

            result = BitConverter.ToString(outputBytes, 4, 8).Replace("-", "");
            lstStr.Add(string.Format("16位大写：{0}", result.ToUpper()));
            lstStr.Add(string.Format("16位小写：{0}", result.ToLower()));

            result = BitConverter.ToString(outputBytes).Replace("-", "");
            lstStr.Add(string.Format("32位大写：{0}", result.ToUpper()));
            lstStr.Add(string.Format("32位小写：{0}", result.ToLower()));

            this.txtResult.Text = string.Join("\r\n\r\n", lstStr.ToArray());
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }
    }
}