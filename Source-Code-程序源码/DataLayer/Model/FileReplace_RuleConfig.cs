using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    /// <summary>
    /// 规则配置
    /// </summary>
    public class FileReplace_RuleConfig
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        [Key]
        public int RuleConfigID { get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 查找内容
        /// </summary>
        public string OldContent { get; set; }

        /// <summary>
        /// 是否使用正则
        /// </summary>
        public bool IsRegex { get; set; }

        /// <summary>
        /// 是否忽略大小写
        /// </summary>
        public bool IsIgnoreCase { get; set; }

        /// <summary>
        /// 是否全字匹配
        /// </summary>
        public bool IsWholeMatch { get; set; }

        /// <summary>
        /// 是否查找文件名
        /// </summary>
        public bool IsFileName { get; set; }

        /// <summary>
        /// 是否查找文件内容
        /// </summary>
        public bool IsFileContent { get; set; }

        /// <summary>
        /// 要替换的值
        /// </summary>
        public string NewContent { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 个性时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}