using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class UserSetting
    {
        /// <summary>
        /// 用户配置ID
        /// </summary>
        [Key]
        public int UserSettingID { get; set; }

        /// <summary>
        /// FileReplace 配置项
        /// </summary>
        public string FileReplaceSetting { get; set; }
    }

    [Serializable]
    public class FileReplaceSetting
    {
        /// <summary>
        /// 已选规则
        /// </summary>
        public List<int> RuleConfigIds { get; set; }

        /// <summary>
        /// 输出目录
        /// </summary>
        public string OutPutPath { get; set; }

        /// <summary>
        /// 是否保持原文件路径格式
        /// </summary>
        public bool? IsKeepDirectory { get; set; }

        /// <summary>
        /// 前缀名
        /// </summary>
        public string PrefixName { get; set; }

        /// <summary>
        /// 后缀名
        /// </summary>
        public string SuffixName { get; set; }

        /// <summary>
        /// 是否保留excel原数据格式
        /// </summary>
        public bool? IsKeepDataFormat { get; set; }

        /// <summary>
        /// 是否保留excel单元格中的公式
        /// </summary>
        public bool? IsKeepFormula { get; set; }

        /// <summary>
        /// 最近一次的打开待处理文件的文件夹路径
        /// </summary>
        public string LastOpenFolderPath { get; set; }
    }
}