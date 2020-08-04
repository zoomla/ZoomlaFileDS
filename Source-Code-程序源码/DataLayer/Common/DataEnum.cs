namespace DataLayer.Common
{
    public class DataEnum
    {
        /// <summary>
        /// FileReplace_File 表的 ProcessState 字段枚举
        /// </summary>
        public enum FileReplace_File_ProcessStateEnum
        {
            等待处理 = 0,
            处理成功 = 1,
            无需处理 = 2,
            处理失败 = 3
        }
    }
}