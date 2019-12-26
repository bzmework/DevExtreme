using DevExtreme.AspNet.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data.Aggregation {

    /// <summary>
    /// Represents a data aggregator.
    /// 表示数据聚合器。
    /// </summary>
    /// <typeparam name="T">
    /// The type of the data items to be aggregated.
    /// 要聚合的数据项的类型。
    /// </typeparam>
    public abstract class Aggregator<T>
    {
        /// <summary>
        /// Allows reading data item properties.
        /// 允许读取数据项属性。
        /// </summary>
        protected IAccessor<T> Accessor { get; private set; }

        /// <summary>
        /// Initializes a new Aggregator class instance with an object that allows reading data item properties.
        /// 使用允许读取数据项属性的对象初始化新的聚合器类实例。
        /// </summary>
        /// <param name="accessor">An object that allows reading data item properties.</param>
        protected Aggregator(IAccessor<T> accessor) {
            Accessor = accessor;
        }

        /// <summary>
        /// A callback invoked once for each data item.
        /// 为每个数据项调用一次的回调。
        /// </summary>
        /// <param name="container">
        /// A data item.
        /// 数据项。
        /// </param>
        /// <param name="selector">
        /// The name or path to the property whose value should be aggregated.
        /// 应聚合其值的属性的名称或路径。
        /// </param>
        public abstract void Step(T container, string selector);

        /// <summary>
        /// A callback invoked at the aggregation's final stage.
        /// 在聚合的最后阶段调用的回调。
        /// </summary>
        /// <returns>
        /// The result of the aggregation.
        /// 聚合的结果。
        /// </returns>
        public abstract object Finish();
    }

}
