using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace XCLWinKits
{
    internal static class Program
    {
        private static System.Threading.Mutex mutex;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            #region 设置默认字体、日期格式等

            var fontObj = new Font("微软雅黑", 9);
            DevExpress.Utils.AppearanceObject.DefaultFont = fontObj;
            WindowsFormsSettings.DefaultFont = fontObj;
            WindowsFormsSettings.DefaultMenuFont = fontObj;
            WindowsFormsSettings.DefaultPrintFont = fontObj;

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("zh-CHS");
            System.Globalization.DateTimeFormatInfo di = (System.Globalization.DateTimeFormatInfo)System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
            di.DateSeparator = "-";
            di.ShortDatePattern = "yyyy-MM-dd";
            ci.DateTimeFormat = di;
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            #endregion 设置默认字体、日期格式等

            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);

            mutex = new System.Threading.Mutex(true, "XCLWinKits");
            if (mutex.WaitOne(0, false))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Index());
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("当前程序已经在运行了，不能打开多个哦！", "系统提示");
                Application.Exit();
            }
        }
    }
}