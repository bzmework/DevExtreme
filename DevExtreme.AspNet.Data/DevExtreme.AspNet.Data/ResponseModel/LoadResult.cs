using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data.ResponseModel {

    /// <summary>
    /// Represents a load result.
    /// 表示加载结果。
    /// </summary>
    public class LoadResult {
        /// <summary>
        /// A resulting dataset.
        /// 结果数据集。
        /// </summary>
        public IEnumerable data { get; set; }

        /// <summary>
        /// The total number of data objects in the resulting dataset.
        /// 结果数据集中的数据对象总数。
        /// </summary>
        [DefaultValue(-1), JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int totalCount { get; set; } = -1;

        /// <summary>
        /// The number of top-level groups in the resulting dataset.
        /// 结果数据集中顶级组的数目。
        /// </summary>
        [DefaultValue(-1), JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int groupCount { get; set; } = -1;

        /// <summary>
        /// Total summary calculation results.
        /// 汇总计算结果。
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object[] summary { get; set; }
    }

}
