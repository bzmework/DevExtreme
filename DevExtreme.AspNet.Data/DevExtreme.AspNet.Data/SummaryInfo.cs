using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data {

    /// <summary>
    /// Represents a group or total summary definition.
    /// 表示组或汇总定义。
    /// </summary>
    public class SummaryInfo {
        /// <summary>
        /// The data field to be used for calculating the summary.
        /// 用于计算摘要的数据字段。
        /// </summary>
        public string Selector { get; set; }

        /// <summary>
        /// An aggregate function: "sum", "min", "max", "avg", or "count".
        /// 聚合函数：“sum”、“min”、“max”、“avg”或“count”。
        /// </summary>
        public string SummaryType { get; set; }
    }

}
