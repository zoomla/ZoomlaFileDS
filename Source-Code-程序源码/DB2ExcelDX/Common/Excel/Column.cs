using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2ExcelDX.Common.Excel
{
    public class Column
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public ColumnDataType DataType { get; set; }
        public int Width { get; set; }
        public bool Hidden { get; set; }
        public Column() { }
        public Column(string code, string name, ColumnDataType dataType, int width, bool hidden = false)
        {
            Code = code;
            Name = name;
            DataType = dataType;
            Width = width;
            Hidden = hidden;
        }
    }
}
