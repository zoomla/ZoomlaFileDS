using System;
using System.Reflection;

namespace CommonEncrypt
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
            var encryptLst = XCLNetTools.Enum.EnumHelper.GetList(typeof(CommonHelper.CommonEnum.EncryptEnum));
            this.comboxEncryptType.DisplayMember = "Text";
            this.comboxEncryptType.ValueMember = "Text";
            this.comboxEncryptType.DataSource = encryptLst;
            this.comboxEncryptType_SelectedIndexChanged(this.comboxEncryptType, null);
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtInput.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入明文！", "系统提示");
                return;
            }
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            this.txtResult.Text = this.GetResult(type, this.txtInput.Text, true);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtResult.Text))
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入密文！", "系统提示");
                return;
            }
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            this.txtInput.Text = this.GetResult(type, this.txtResult.Text, false);
        }

        private string GetResult(CommonHelper.CommonEnum.EncryptEnum encryptEnum, string str, bool isEncrypt)
        {
            string result = string.Empty;
            try
            {
                switch (encryptEnum)
                {
                    case CommonHelper.CommonEnum.EncryptEnum.AES:
                        XCLNetTools.Encrypt.AESEncrypt aes = new XCLNetTools.Encrypt.AESEncrypt(this.ckContainKey.Checked);
                        if (string.IsNullOrEmpty(this.txtKey.Text))
                        {
                            result = isEncrypt ? aes.Encrypt(this.txtInput.Text) : aes.Decrypt(this.txtResult.Text);
                        }
                        else
                        {
                            result = isEncrypt ? aes.Encrypt(this.txtInput.Text, this.txtKey.Text) : aes.Decrypt(this.txtResult.Text, this.txtKey.Text);
                        }
                        break;

                    case CommonHelper.CommonEnum.EncryptEnum.Base64:
                        result = isEncrypt ? XCLNetTools.Encode.Base64.Base64Code(str) : XCLNetTools.Encode.Base64.Base64Decode(str);
                        break;

                    case CommonHelper.CommonEnum.EncryptEnum.DES:
                        if (string.IsNullOrEmpty(this.txtKey.Text))
                        {
                            result = isEncrypt ? XCLNetTools.Encrypt.DESEncrypt.Encrypt(this.txtInput.Text) : XCLNetTools.Encrypt.DESEncrypt.Decrypt(this.txtResult.Text);
                        }
                        else
                        {
                            result = isEncrypt ? XCLNetTools.Encrypt.DESEncrypt.Encrypt(this.txtInput.Text, this.txtKey.Text) : XCLNetTools.Encrypt.DESEncrypt.Decrypt(this.txtResult.Text, this.txtKey.Text);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                result = "处理失败！"+ex.Message;
            }
            return result;
        }

        private void comboxEncryptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (CommonHelper.CommonEnum.EncryptEnum)Enum.Parse(typeof(CommonHelper.CommonEnum.EncryptEnum), this.comboxEncryptType.Text);
            switch (type)
            {
                case CommonHelper.CommonEnum.EncryptEnum.AES:
                    this.txtKey.Enabled = true;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = true;
                    break;

                case CommonHelper.CommonEnum.EncryptEnum.DES:
                    this.txtKey.Enabled = true;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = false;
                    break;

                default:
                    this.txtKey.Text = "";
                    this.txtKey.Enabled = false;
                    this.ckContainKey.Checked = false;
                    this.ckContainKey.Enabled = false;
                    break;
            }
        }
    }
}