﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public class FileReplace_File
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [Key]
        public int FileID { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 完整路径
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// 扩展名（不带点）
        /// </summary>
        public string ExtensionName { get; set; }

        /// <summary>
        /// 是否已处理完成
        /// </summary>
        public bool IsDone { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        public int ProcessState { get; set; }

        /// <summary>
        /// 处理时长（s）
        /// </summary>
        public int ProcessDuration { get; set; }

        /// <summary>
        /// 处理个数
        /// </summary>
        public int ProcessBlockCount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}