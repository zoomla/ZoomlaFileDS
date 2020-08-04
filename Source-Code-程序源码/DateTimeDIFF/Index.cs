using System;
using System.Collections.Generic;
using System.Reflection;

namespace DateTimeDIFF
{
    public partial class Index : BaseForm.BaseFormClass
    {
        private const long oneYearMilliseconds = 365 * 24 * 3600 * 1000L;//一年的毫秒数
        private const long oneMonthMilliseconds = 30 * 24 * 3600 * 1000L;//一个月的毫秒数
        private const long oneDayMilliseconds = 24 * 3600 * 1000L;//一天的毫秒数
        private const long oneHourMilliseconds = 3600 * 1000L;//一小时的毫秒数

        public Index()
        {
            InitializeComponent();

            this.txtStartTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            this.txtEndTime.Text = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now.AddDays(7));
        }

        private void Process()
        {
            var start = XCLNetTools.Common.DataTypeConvert.ToDateTimeNull(this.txtStartTime.Text);
            var end = XCLNetTools.Common.DataTypeConvert.ToDateTimeNull(this.txtEndTime.Text);
            if (!start.HasValue)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入有效格式的开始时间！", "系统提示");
                return;
            }
            if (!end.HasValue)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请输入有效格式的结束时间！", "系统提示");
                return;
            }

            var resultLst = new List<string>();
            var timeSpan = end.Value.Subtract(start.Value);
            var totalMilliseconds = timeSpan.TotalMilliseconds;
            var longTotalMilliseconds = (long)totalMilliseconds;

            //总毫秒数
            resultLst.Add(string.Format("总毫秒数：{0}", totalMilliseconds));

            //总秒数
            resultLst.Add(string.Format("总秒数：{0}", timeSpan.TotalSeconds));

            //总分数
            resultLst.Add(string.Format("总分数：{0}", timeSpan.TotalMinutes));

            //总小时数
            resultLst.Add(string.Format("总小时数：{0}", timeSpan.TotalHours));

            //总天数
            resultLst.Add(string.Format("总天数：{0}", timeSpan.TotalDays));

            //总月数
            resultLst.Add(string.Format("总月数：{0}", timeSpan.TotalDays / 30.0));

            //总年数
            resultLst.Add(string.Format("总年数：{0}", timeSpan.TotalDays / 365.0));

            //xx年xx月xx天xx小时xx分xx秒xx毫秒
            resultLst.Add(string.Format("间隔：{0}年{1}个月{2}天{3}小时{4}分钟{5}秒{6}毫秒",
                longTotalMilliseconds / oneYearMilliseconds,
                (longTotalMilliseconds % oneYearMilliseconds) / oneMonthMilliseconds,
                (longTotalMilliseconds % oneYearMilliseconds % oneMonthMilliseconds) / oneDayMilliseconds,
                (longTotalMilliseconds % oneYearMilliseconds % oneMonthMilliseconds % oneDayMilliseconds) / oneHourMilliseconds,
                 (longTotalMilliseconds % oneYearMilliseconds % oneMonthMilliseconds % oneDayMilliseconds % oneHourMilliseconds) / 60000,
                 (longTotalMilliseconds % oneYearMilliseconds % oneMonthMilliseconds % oneDayMilliseconds % oneHourMilliseconds % 60000) / 1000,
                 longTotalMilliseconds % oneYearMilliseconds % oneMonthMilliseconds % oneDayMilliseconds % oneHourMilliseconds % 60000 % 1000
                ));

            this.txtResult.Text = string.Join(Environment.NewLine + Environment.NewLine, resultLst.ToArray());
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            this.Process();
        }

        public override string SubAssemblyName
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Name;
            }
        }
    }
}