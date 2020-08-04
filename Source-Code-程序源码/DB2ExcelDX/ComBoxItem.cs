using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB2ExcelDX
{
    class ComBoxItem
    {
        private Image img;
        private string text;

        public ComBoxItem()
        {
        }

        public ComBoxItem(string text)
        {
            this.text = text;
        }

        public ComBoxItem(Image img, string text)
        {
            this.img = img;
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }

        public Image Img { get => img; set => img = value; }
        public string Text { get => text; set => text = value; }
    }
}
