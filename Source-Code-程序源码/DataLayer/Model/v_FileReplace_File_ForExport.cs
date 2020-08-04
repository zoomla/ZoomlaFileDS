using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    /// <summary>
    /// v_FileReplace_File_ForExport:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class v_FileReplace_File_ForExport
    {
        public v_FileReplace_File_ForExport()
        { }

        [Key]
        public int 编号
        {
            get; set;
        }

        public string 文件名
        {
            get; set;
        }

        public string 路径
        {
            get; set;
        }

        public string 扩展名
        {
            get; set;
        }

        public string 是否已处理
        {
            get; set;
        }

        public string 处理结果
        {
            get; set;
        }

        public int 处理用时_秒
        {
            get; set;
        }

        public int 处理数量
        {
            get; set;
        }

        public string 备注
        {
            get; set;
        }
    }
}