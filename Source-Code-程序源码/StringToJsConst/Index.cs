using System;
using System.Reflection;

namespace StringToJsConst
{
    public partial class Index : BaseForm.BaseFormClass
    {
        public Index()
        {
            InitializeComponent();
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {
            this.txtNew.Text = XCLNetTools.Javascript.Jscript.StringToConst(this.txtOld.Text);
        }

        private void Index_Load(object sender, EventArgs e)
        {

        }
    }
}