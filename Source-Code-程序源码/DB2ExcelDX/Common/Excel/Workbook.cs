using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.IO;
using System.Text;

namespace DB2ExcelDX.Common.Excel
{
    /// <summary>
    /// 工作薄
    /// </summary>
    public class Workbook : IDisposable
    {
        public HSSFWorkbook workbook;
        public XSSFWorkbook xSSFWorkbook;
        /// <summary>
        /// 表头格式
        /// </summary>
        /*private XSSFCellStyle HeadStyle
        {
            get
            {
                //HSSFCellStyle headStyle = (HSSFCellStyle)workbook.CreateCellStyle();
                XSSFCellStyle headStyle = (XSSFCellStyle)xSSFWorkbook.CreateCellStyle();
                headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                headStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                HSSFFont font = (HSSFFont)workbook.CreateFont();
                font.FontHeightInPoints = 10;
                font.Boldweight = 700;
                headStyle.SetFont(font);
                return headStyle;
            }
        }*/

        private XSSFCellStyle _dateStyle = null;
        /// <summary>
        /// 时间格式
        /// </summary>
        private XSSFCellStyle DateStyle
        {
            get
            {
                if (_dateStyle == null)
                {
                    XSSFCellStyle dateStyle = (XSSFCellStyle)xSSFWorkbook.CreateCellStyle();
                    XSSFDataFormat format = (XSSFDataFormat)xSSFWorkbook.CreateDataFormat();
                    dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");
                    _dateStyle = dateStyle;
                }
                return _dateStyle;
            }
        }

        private XSSFCellStyle _datetimeStyle = null;
        /// <summary>
        /// 时间格式
        /// </summary>
        private XSSFCellStyle DateTimeStyle
        {
            get
            {
                if (_datetimeStyle == null)
                {
                    XSSFCellStyle dateStyle = (XSSFCellStyle)xSSFWorkbook.CreateCellStyle();
                    XSSFDataFormat format = (XSSFDataFormat)xSSFWorkbook.CreateDataFormat();
                    dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd HH:MM:ss");
                    _datetimeStyle = dateStyle;
                }
                return _datetimeStyle;
            }
        }

        /// <summary>
        /// 实例一个工作薄
        /// </summary>
        public Workbook()
        {
            xSSFWorkbook = new XSSFWorkbook();
            workbook = new HSSFWorkbook();
            #region 右击文件 属性信息
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            dsi.Company = "";
            workbook.DocumentSummaryInformation = dsi;
            //xSSFWorkbook.summ

            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Author = ""; //填加xls文件作者信息
            si.ApplicationName = ""; //填加xls文件创建程序信息
            si.LastAuthor = ""; //填加xls文件最后保存者信息
            si.CreateDateTime = System.DateTime.Now;
            workbook.SummaryInformation = si;
            #endregion
        }

        /// <summary>
        /// 加载Excel文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public Workbook(string filePath)
        {
            using (FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                workbook = new HSSFWorkbook(file);
            }
        }

        /// <summary>
        /// 获取Sheet页的数据
        /// </summary>
        /// <param name="sheetIndex">Sheet页Index，从0开始</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(int sheetIndex = 0)
        {
            DataTable dt = new DataTable();

            HSSFSheet sheet = (HSSFSheet)workbook.GetSheetAt(sheetIndex);
            System.Collections.IEnumerator rows = sheet.GetRowEnumerator();

            HSSFRow headerRow = (HSSFRow)sheet.GetRow(0);
            int cellCount = headerRow.LastCellNum;

            for (int j = 0; j < cellCount; j++)
            {
                HSSFCell cell = (HSSFCell)headerRow.GetCell(j);
                dt.Columns.Add(cell.ToString());
            }

            for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
            {
                HSSFRow row = (HSSFRow)sheet.GetRow(i);
                if (row == null)
                    continue;
                DataRow dataRow = dt.NewRow();

                for (int j = row.FirstCellNum; j < cellCount; j++)
                {
                    ICell cell = row.GetCell(j);
                    if (cell != null)
                    {
                        if (cell.CellType == CellType.Numeric)
                        {
                            //NPOI中数字和日期都是NUMERIC类型的，这里对其进行判断是否是日期类型
                            if (HSSFDateUtil.IsCellDateFormatted(cell))//日期类型
                            {
                                dataRow[j] = cell.DateCellValue;
                            }
                            else//其他数字类型
                            {
                                dataRow[j] = cell.NumericCellValue;
                            }
                        }
                        else if (cell.CellType == CellType.Blank)//空数据类型
                        {
                            dataRow[j] = "";
                        }
                        else if (cell.CellType == CellType.Formula)//公式类型
                        {
                            HSSFFormulaEvaluator eva = new HSSFFormulaEvaluator(workbook);
                            dataRow[j] = eva.Evaluate(cell).StringValue;
                        }
                        else //其他类型都按字符串类型来处理
                        {
                            dataRow[j] = cell.StringCellValue;
                        }
                    }
                }

                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        /// <summary>
        /// 创建一个Sheet页
        /// </summary>
        /// <param name="Sheet">Sheet</param>
        public void CreateSheet(Sheet sheetInfo)
        {
            if (string.IsNullOrWhiteSpace(sheetInfo.Name)) sheetInfo.Name = "Sheet" + workbook.NumberOfSheets + 1;
             ISheet sheet = xSSFWorkbook.CreateSheet(sheetInfo.Name);
            //HSSFSheet sheet = (HSSFSheet)workbook.CreateSheet(sheetInfo.Name);

            int rowIndex = 0;

            #region 新建表，填充表头，填充列头，样式
            //HSSFRow headerRow = (HSSFRow)sheet.CreateRow(rowIndex);
            XSSFRow headerRow = (XSSFRow)sheet.CreateRow(rowIndex);
            headerRow.HeightInPoints = 20;
            var columIndex = 0;
            foreach (var column in sheetInfo.Columns)
            {
                headerRow.CreateCell(columIndex).SetCellValue(column.Name);
                //headerRow.GetCell(columIndex).CellStyle = HeadStyle;
                //设置列宽
                sheet.SetColumnWidth(columIndex, column.Width * 256);
                sheet.SetColumnHidden(columIndex, column.Hidden);
                columIndex++;
            }

            #endregion
            #region 填充内容
            rowIndex = 1;
            foreach (DataRow row in sheetInfo.DataSource.Rows)
            {
                //HSSFRow dataRow = (HSSFRow)sheet.CreateRow(rowIndex);
                XSSFRow dataRow = (XSSFRow)sheet.CreateRow(rowIndex);
                var columnIndex = 0;
                foreach (var column in sheetInfo.Columns)
                {
                    //HSSFCell newCell = (HSSFCell)dataRow.CreateCell(columnIndex);
                    XSSFCell newCell = (XSSFCell)dataRow.CreateCell(columnIndex);
                    if (!sheetInfo.DataSource.Columns.Contains(column.Code))
                    {
                        newCell.SetCellValue("");
                    }
                    else
                    {
                        string drValue = row[column.Code].ToString();

                        switch (column.DataType)
                        {
                            case ColumnDataType.String://字符串类型
                                newCell.SetCellValue(drValue);
                                break;
                            case ColumnDataType.Date://日期类型
                                System.DateTime dateV = DateTime.MinValue;
                                System.DateTime.TryParse(drValue, out dateV);
                                if (dateV != DateTime.MinValue)
                                    newCell.SetCellValue(dateV);
                                newCell.CellStyle = DateStyle;//格式化显示
                                break;
                            case ColumnDataType.DateTime://日期类型
                                System.DateTime datetimeV = DateTime.MinValue;
                                System.DateTime.TryParse(drValue, out datetimeV);
                                if (datetimeV != DateTime.MinValue)
                                    newCell.SetCellValue(datetimeV);
                                newCell.CellStyle = DateTimeStyle;//格式化显示
                                break;
                            case ColumnDataType.Bool://布尔型
                                bool boolV = false;
                                bool.TryParse(drValue, out boolV);
                                newCell.SetCellValue(boolV);
                                break;
                            case ColumnDataType.Int://整型
                                int intV = 0;
                                int.TryParse(drValue, out intV);
                                newCell.SetCellValue(intV);
                                break;
                            case ColumnDataType.Float://浮点型
                                double doubV = 0;
                                double.TryParse(drValue, out doubV);
                                newCell.SetCellValue(doubV);
                                break;
                            case ColumnDataType.Url:// 链接样式
                                newCell.SetCellValue(drValue);
                                var link = new XSSFHyperlink(HyperlinkType.Url);
                                link.Address = drValue;
                                newCell.Hyperlink = link;
                                newCell.CellStyle = DateStyle;//格式化显示
                                break;
                            case ColumnDataType.Other:
                            default:
                                newCell.SetCellValue(drValue);
                                break;
                        }
                    }
                    columnIndex++;
                }
                rowIndex++;
            }
            #endregion
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public void SaveAs(string filePath)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                ms.Flush();
                ms.Position = 0;

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] data = ms.ToArray();
                    fs.Write(data, 0, data.Length);
                    fs.Flush();
                }
            }
        }

        /// <summary>
        /// 获取Workbook的MemoryStream
        /// </summary>
        /// <returns></returns>
        public MemoryStream GetMemoryStream()
        {
            MemoryStream ms = new MemoryStream();
            xSSFWorkbook.Write(ms);
            return ms;
        }

        public void Dispose()
        {
            if (workbook != null)
                workbook.Close();
        }



        /// <summary>DataTable导出到Excel的MemoryStream
        /// </summary>
        /// <param name="dtSource">源DataTable</param>
        /// <param name="strHeaderText">表头文本</param>
        /*public static MemoryStream Export(DataTable dtSource, string strHeaderText)
        {
            var workbook = new HSSFWorkbook();
            var sheet = workbook.CreateSheet();

            #region 右击文件 属性信息
            {
                DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
                dsi.Company = "NPOI";
                workbook.DocumentSummaryInformation = dsi;

                SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
                si.Author = "SiBuMBG"; //填加xls文件作者信息
                si.ApplicationName = "SiBuMBG"; //填加xls文件创建程序信息
                si.LastAuthor = "SiBuMBG"; //填加xls文件最后保存者信息
                si.Comments = "SiBuMBG"; //填加xls文件作者信息
                si.Title = "SiBuMBG"; //填加xls文件标题信息
                si.Subject = "SiBuMBG";//填加文件主题信息
                si.CreateDateTime = DateTime.Now;
                workbook.SummaryInformation = si;
            }
            #endregion

            var dateStyle = workbook.CreateCellStyle();
            var format = workbook.CreateDataFormat();
            dateStyle.DataFormat = format.GetFormat("yyyy-mm-dd");

            //取得列宽
            int[] arrColWidth = new int[dtSource.Columns.Count];
            foreach (DataColumn item in dtSource.Columns)
            {
                arrColWidth[item.Ordinal] = Encoding.GetEncoding(936).GetBytes(item.ColumnName.ToString()).Length;
            }
            for (int i = 0; i < dtSource.Rows.Count; i++)
            {
                for (int j = 0; j < dtSource.Columns.Count; j++)
                {
                    int intTemp = Encoding.GetEncoding(936).GetBytes(dtSource.Rows[i][j].ToString()).Length;
                    if (intTemp > arrColWidth[j])
                    {
                        arrColWidth[j] = intTemp;
                    }
                }
            }
            int rowIndex = 0;
            foreach (DataRow row in dtSource.Rows)
            {
                #region 新建表，填充表头，填充列头，样式
                if (rowIndex == 65535 || rowIndex == 0)
                {
                    if (rowIndex != 0)
                    {
                        sheet = workbook.CreateSheet();
                    }

                    #region 表头及样式
                    {
                        if (!string.IsNullOrEmpty(strHeaderText))
                        {
                            var headerRow = sheet.CreateRow(0);
                            headerRow.HeightInPoints = 25;
                            headerRow.CreateCell(0).SetCellValue(strHeaderText);

                            var headStyle = workbook.CreateCellStyle();
                            headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center; //CellHorizontalAlignment.CENTER;

                            var font = workbook.CreateFont();
                            font.FontHeightInPoints = 20;
                            font.Boldweight = 700;
                            headStyle.SetFont(font);
                            headerRow.GetCell(0).CellStyle = headStyle;

                            var cellRangeAddress = new CellRangeAddress(0, 0, 0, dtSource.Columns.Count - 1);
                            sheet.AddMergedRegion(cellRangeAddress);
                        }
                    }
                    #endregion


                    #region 列头及样式
                    {
                        var headerRow = sheet.CreateRow(1);
                        var headStyle = workbook.CreateCellStyle();
                        headStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;

                        var font = workbook.CreateFont();
                        font.FontHeightInPoints = 10;
                        font.Boldweight = 700;
                        headStyle.SetFont(font);
                        foreach (DataColumn column in dtSource.Columns)
                        {
                            headerRow.CreateCell(column.Ordinal).SetCellValue(column.ColumnName);
                            headerRow.GetCell(column.Ordinal).CellStyle = headStyle;

                            //设置列宽
                            sheet.SetColumnWidth(column.Ordinal, (arrColWidth[column.Ordinal] + 1) * 256);
                        }
                        //headerRow.Dispose();
                    }
                    #endregion

                    rowIndex = 2;
                }
                #endregion

                #region 填充内容
                var dataRow = sheet.CreateRow(rowIndex);
                foreach (DataColumn column in dtSource.Columns)
                {
                    var newCell = dataRow.CreateCell(column.Ordinal);

                    string drValue = row[column].ToString();

                    switch (column.DataType.ToString())
                    {
                        case "System.String"://字符串类型
                            newCell.SetCellValue(drValue);
                            break;
                        case "System.DateTime"://日期类型
                            DateTime dateV;
                            DateTime.TryParse(drValue, out dateV);
                            newCell.SetCellValue(dateV);

                            newCell.CellStyle = dateStyle;//格式化显示
                            break;
                        case "System.Boolean"://布尔型
                            bool boolV = false;
                            bool.TryParse(drValue, out boolV);
                            newCell.SetCellValue(boolV);
                            break;
                        case "System.Int16"://整型
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            int intV = 0;
                            int.TryParse(drValue, out intV);
                            newCell.SetCellValue(intV);
                            break;
                        case "System.Decimal"://浮点型
                        case "System.Double":
                            double doubV = 0;
                            double.TryParse(drValue, out doubV);
                            newCell.SetCellValue(doubV);
                            break;
                        case "System.DBNull"://空值处理
                            newCell.SetCellValue("");
                            break;
                        default:
                            newCell.SetCellValue("");
                            break;
                    }

                }
                #endregion

                rowIndex++;
            }

            MemoryStream ms = new MemoryStream();
            workbook.Write(ms);
            ms.Flush();
            ms.Position = 0;

            workbook.Close();//一般只用写这一个就OK了，他会遍历并释放所有资源，但当前版本有问题所以只释放sheet
            return ms;
        }*/

    }
}
