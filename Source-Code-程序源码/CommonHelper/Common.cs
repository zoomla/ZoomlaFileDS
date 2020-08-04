using System;
using System.Text;

namespace CommonHelper
{
    public class Common
    {
        /// <summary>
        /// 写日志
        /// </summary>
        public static void WriteLog(string msg)
        {
            if (string.IsNullOrWhiteSpace(msg))
            {
                return;
            }
            var dtNow = DateTime.Now;
            msg = string.Format("{1}{1}{0}{1}{1}{2}", new string('=', 50), Environment.NewLine, msg.Trim());
            try
            {
                string dir = string.Format(@"{1}Log\{0:yyyy}\{0:MM}", dtNow, AppDomain.CurrentDomain.BaseDirectory);
                XCLNetTools.FileHandler.FileDirectory.MakeDirectory(dir);
                System.IO.File.AppendAllText(string.Format(@"{0}\{1:yyyyMMdd}.txt", dir, dtNow), msg);
            }
            catch { }
        }

        /// <summary>
        /// 写日志
        /// </summary>
        public static void WriteLog(Exception ex)
        {
            var str = new StringBuilder();
            str.AppendFormat("时间：{0}", DateTime.Now.ToString());
            str.Append(Environment.NewLine);
            str.AppendFormat("错误：{0}", ex.Message);
            str.Append(Environment.NewLine);
            str.AppendFormat("跟踪：{0}", ex.StackTrace);
            str.Append(Environment.NewLine);
            if (null != ex.InnerException)
            {
                str.AppendFormat("错误：{0}", ex.InnerException.Message);
                str.Append(Environment.NewLine);
                str.AppendFormat("跟踪：{0}", ex.InnerException.StackTrace);
                str.Append(Environment.NewLine);
            }
            CommonHelper.Common.WriteLog(str.ToString());
        }

        public static Aspose.Words.SaveFormat GetAsposeWordFormatEnum(string fileToFormatName)
        {
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.WordFileToFormatEnum.pdf.ToString()))
            {
                return Aspose.Words.SaveFormat.Pdf;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.WordFileToFormatEnum.html.ToString()))
            {
                return Aspose.Words.SaveFormat.Html;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.WordFileToFormatEnum.txt.ToString()))
            {
                return Aspose.Words.SaveFormat.Text;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.WordFileToFormatEnum.docx.ToString()))
            {
                return Aspose.Words.SaveFormat.Docx;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.WordFileToFormatEnum.doc.ToString()))
            {
                return Aspose.Words.SaveFormat.Doc;
            }
            return Aspose.Words.SaveFormat.Unknown;
        }

        public static Aspose.Cells.SaveFormat GetAsposeCellsFormatEnum(string fileToFormatName)
        {
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.ExcelFileToFormatEnum.pdf.ToString()))
            {
                return Aspose.Cells.SaveFormat.Pdf;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.ExcelFileToFormatEnum.html.ToString()))
            {
                return Aspose.Cells.SaveFormat.Html;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.ExcelFileToFormatEnum.xlsx.ToString()))
            {
                return Aspose.Cells.SaveFormat.Xlsx;
            }
            if (string.Equals(fileToFormatName, CommonHelper.CommonEnum.ExcelFileToFormatEnum.xls.ToString()))
            {
                return Aspose.Cells.SaveFormat.Excel97To2003;
            }
            return Aspose.Cells.SaveFormat.Unknown;
        }
    }
}