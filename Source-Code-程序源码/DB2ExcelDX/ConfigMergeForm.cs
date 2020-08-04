using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2ExcelDX
{
    public partial class ConfigMergeForm : Form
    {
        private int result = 1;
        public ConfigMergeForm()
        {
            InitializeComponent();
            this.doNothing.Checked = true;
        }
        public ConfigMergeForm(int localCount,int cloudCount,string localV,string cloudV)
        {
            InitializeComponent();
            this.doNothing.Checked = true;
            this.localScriptCount.Text = localCount.ToString();
            this.cloudScriptCount.Text = cloudCount.ToString();
            this.localVersion.Text = localV;
            this.cloudVersion.Text = cloudV;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.doNothing.Checked)
                result= 1;
            else if (this.overwriteLocalFile.Checked)
                result= 2;
            else
                result= 3;
            this.Close();
        }
        public int show()
        {
            this.ShowDialog();
            return result;
        }

    }
}
