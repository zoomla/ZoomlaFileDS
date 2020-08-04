using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2ExcelDX.Common.Excel
{
    public class Sheet
    {
        public string Name { get; set; }
        public List<Column> Columns { get; set; }
        public DataTable DataSource { get; set; }
        public Sheet() { }
        public Sheet(string name, List<Column> columns, DataTable dataSource)
        {
            Name = name;
            Columns = columns;
            DataSource = dataSource;
        }
    }
    public class Sheet<T>
    {
        public string Name { get; set; }
        public List<Column> Columns { get; set; }
        public List<T> DataSource { get; set; }
        public Sheet(string name, List<Column> columns, List<T> dataSource)
        {
            Name = name;
            Columns = columns;
            DataSource = dataSource;
        }
    }
}
