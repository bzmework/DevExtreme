using System;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace DevExtreme.AspNet.Data {

    /// <summary>
    /// A class with properties that specify data processing settings.
    /// 具有指定数据处理设置的属性的类。
    /// </summary>
    public class DataSourceLoadOptionsBase {
        /// <summary>
        /// A global default value for the <see cref="StringToLower" /> property
        /// StringToLower属性的全局默认值
        /// </summary>
        public static bool? StringToLowerDefault { get; set; }

        /// <summary>
        /// A flag indicating whether the total number of data objects is required.
        /// 指示是否需要数据对象总数的标志。
        /// </summary>
        public bool RequireTotalCount { get; set; }

        /// <summary>
        /// A flag indicating whether the number of top-level groups is required.
        /// 指示是否需要顶级组数的标志。
        /// </summary>
        public bool RequireGroupCount { get; set; }

        /// <summary>
        /// A flag indicating whether the current query is made to get the total number of data objects.
        /// 指示是否进行当前查询以获取数据对象总数的标志。
        /// </summary>
        public bool IsCountQuery { get; set; }

        /// <summary>
        /// The number of data objects to be skipped from the start of the resulting set.
        /// 从结果集开始要跳过的数据对象数。
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// The number of data objects to be loaded.
        /// 要加载的数据对象数。
        /// </summary>
        public int Take { get; set; }

        /// <summary>
        /// A sort expression.
        /// 排序表达式。
        /// </summary>
        public SortingInfo[] Sort { get; set; }

        /// <summary>
        /// A group expression.
        /// 分组表达式。
        /// </summary>
        public GroupingInfo[] Group { get; set; }

        /// <summary>
        /// A filter expression.
        /// 筛选表达式。
        /// </summary>
        public IList Filter { get; set; }

        /// <summary>
        /// A total summary expression.
        /// 汇总表达式。
        /// </summary>
        public SummaryInfo[] TotalSummary { get; set; }

        /// <summary>
        /// A group summary expression.
        /// 分组汇总表达式。
        /// </summary>
        public SummaryInfo[] GroupSummary { get; set; }

        /// <summary>
        /// A select expression.
        /// 选择表达式。
        /// </summary>
        public string[] Select { get; set; }

        /// <summary>
        /// An array of data fields that limits the <see cref="Select" /> expression.
        /// The applied select expression is the intersection of <see cref="PreSelect" /> and <see cref="Select" />.
        /// 限制Select表达式的数据字段数组。
        /// 应用的select表达式是PreSelect和Select的交集
        /// </summary>
        public string[] PreSelect { get; set; }

        /// <summary>
        /// A flag that indicates whether the LINQ provider should execute the select expression.
        /// If set to false, the select operation is performed in memory.
        /// 指示LINQ提供程序是否应执行选择表达式的标志。
        /// 如果设置为false，则在内存中执行选择操作。
        /// </summary>
        public bool? RemoteSelect { get; set; }

        /// <summary>
        /// A flag that indicates whether the LINQ provider should execute grouping.
        /// If set to false, the entire dataset is loaded and grouped in memory.
        /// 指示LINQ提供程序是否应执行分组的标志。
        /// 如果设置为false，则会加载整个数据集并将其分组到内存中。
        /// </summary>
        public bool? RemoteGrouping { get; set; }

        /// <summary>
        /// An array of primary keys.
        /// 主键数组。
        /// </summary>
        public string[] PrimaryKey { get; set; }

        /// <summary>
        /// The data field to be used for sorting by default.
        /// 默认情况下用于排序的数据字段。
        /// </summary>
        public string DefaultSort { get; set; }

        /// <summary>
        /// A flag that indicates whether filter expressions should include a ToLower() call that makes string comparison case-insensitive.
        /// Defaults to true for LINQ to Objects, false for any other provider.
        /// 指示筛选器表达式是否应包含ToLower（）调用的标志，该调用使字符串比较不区分大小写。
        /// 对于LINQ to Objects，默认为true，对于任何其他提供程序，默认为false。
        /// </summary>
        public bool? StringToLower { get; set; }

        /// <summary>
        /// If this flag is enabled, keys and data are loaded via separate queries.
        /// This may result in a more efficient SQL execution plan.
        /// 如果启用此标志，则通过单独的查询加载键和数据。
        /// 这可能会导致更有效的SQL执行计划。
        /// </summary>
        public bool? PaginateViaPrimaryKey { get; set; }

#if DEBUG
        internal Action<Expression> ExpressionWatcher;
        internal bool UseEnumerableOnce;
        internal bool SuppressGuardNulls;
#endif
    }

}
