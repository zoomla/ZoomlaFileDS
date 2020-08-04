using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIP
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
            this.InitData();
        }

        public void InitData()
        {
            this.txtInnerIP.ReadOnly = true;
            this.txtPubIP.ReadOnly = true;
            this.txtPubAddr.ReadOnly = true;
            this.txtInnerIP.Text = XCLNetTools.Common.IPHelper.GetLocalIP();
            var pubIpModel = XCLNetTools.Common.IPHelper.GetIPFromPublicWeb();
            this.txtPubIP.Text = pubIpModel.IP;
            this.txtPubAddr.Text = pubIpModel.Address;
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}