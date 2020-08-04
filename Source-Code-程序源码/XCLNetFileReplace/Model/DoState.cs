using System;

namespace XCLNetFileReplace.Model
{
    public class DoState
    {
        /// <summary>
        /// 总数
        /// </summary>
        public int SumCount { get; set; }

        /// <summary>
        /// 当前已处理数
        /// </summary>
        public int CurrentCount
        {
            get
            {
                return this.SuccessCount + this.FailCount + this.IgnoreCount;
            }
        }

        /// <summary>
        /// 成功数
        /// </summary>
        public int SuccessCount { get; set; }

        /// <summary>
        /// 失败数
        /// </summary>
        public int FailCount { get; set; }

        /// <summary>
        /// 无需处理数
        /// </summary>
        public int IgnoreCount { get; set; }

        /// <summary>
        /// 已处理数百分比（处理进度）
        /// 如：99.5
        /// </summary>
        public decimal DoPercent
        {
            get
            {
                decimal d = 0;
                if (this.SumCount > 0)
                {
                    d = Math.Round((decimal)(1.0 * this.CurrentCount / this.SumCount) * 100, 1);
                }
                return d;
            }
        }

        public override string ToString()
        {
            return string.Format("已完成{0}%，{1}成功，{2}失败，{3}无需处理，已处理[{4}]个文件，共[{5}]个文件", this.DoPercent, this.SuccessCount, this.FailCount, this.IgnoreCount, this.CurrentCount, this.SumCount); ;
        }
    }
}