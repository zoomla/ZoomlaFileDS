using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB2ExcelDX
{
    public enum DBType
    {
        String,
        Date,
        DateTime,
        Boolean,
        Int32,
        Double,
        URL,
        Other,
        Decimal
    }

    public enum ExcelType
    {
        String,
        Date,
        DateTime,
        Bool,
        Int,
        Float,
        Url,
        Other,
    }

    public enum ComboName
    {
        普通文本,
        日期,
        日期和时间,
        真假,
        整型,
        浮点型,
        超链接,
        其他,
        小数型
    }
}
