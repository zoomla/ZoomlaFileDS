using System;
using System.Reflection;

namespace CodingConvert
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        private void InitData()
        {
            var codingLst = XCLNetTools.Enum.EnumHelper.GetEnumFieldModelList(typeof(CommonHelper.CommonEnum.CodingEnum));
            this.commboxCodingName.DisplayMember = "Text";
            this.commboxCodingName.ValueMember = "Description";
            this.commboxCodingName.DataSource = codingLst;
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInputString.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入要编码的内容！", "系统提示");
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_Escape.ToString())
            {
                this.txtResult.Text = Microsoft.JScript.GlobalObject.escape(this.txtInputString.Text);
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_EncodeURI.ToString())
            {
                this.txtResult.Text = Microsoft.JScript.GlobalObject.encodeURI(this.txtInputString.Text);
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_EncodeURIComponent.ToString())
            {
                this.txtResult.Text = Microsoft.JScript.GlobalObject.encodeURIComponent(this.txtInputString.Text);
                return;
            }

            this.txtResult.Text = this.GetCodeString(this.txtInputString.Text, true);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtResult.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入要解码的内容！", "系统提示");
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_Escape.ToString())
            {
                this.txtInputString.Text = Microsoft.JScript.GlobalObject.unescape(this.txtResult.Text);
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_EncodeURI.ToString())
            {
                this.txtInputString.Text = Microsoft.JScript.GlobalObject.decodeURI(this.txtResult.Text);
                return;
            }
            if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.JS_EncodeURIComponent.ToString())
            {
                this.txtInputString.Text = Microsoft.JScript.GlobalObject.decodeURIComponent(this.txtResult.Text);
                return;
            }
            this.txtInputString.Text = this.GetCodeString(this.txtResult.Text, false);
        }

        private string GetCodeString(string str, bool isEncode)
        {
            if (isEncode)
            {
                this.txtResult.Text = string.Empty;
            }
            else
            {
                this.txtInputString.Text = string.Empty;
            }
            string strResult = string.Empty;
            try
            {
                if (this.commboxCodingName.Text == CommonHelper.CommonEnum.CodingEnum.Unicode.ToString())
                {
                    strResult = isEncode ? XCLNetTools.Encode.Unicode.UnicodeEncode(str) : XCLNetTools.Encode.Unicode.UnicodeDecode(str);
                }
            }
            catch
            {
                strResult = "处理失败！";
            }
            return strResult;
        }
    }
}