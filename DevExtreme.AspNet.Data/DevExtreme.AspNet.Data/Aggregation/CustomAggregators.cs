using DevExtreme.AspNet.Data.Helpers;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Data.Aggregation {
    /// <summary>
    /// Provides methods that manipulate custom aggregators.
    /// 提供操作自定义聚合器的方法。
    /// </summary>
    public static class CustomAggregators {
        private static readonly Dictionary<string, Type> _aggregatorTypes = new Dictionary<string, Type>();

        /// <summary>
        /// Registers a custom aggregator.
        /// 注册自定义聚合器。
        /// </summary>
        /// <param name="summaryType">
        /// The aggregator's string identifier.
        /// 聚合器的字符串标识符。
        /// </param>
        /// <param name="aggregatorType">
        /// The aggregator's type declaration without the generic type parameter T.
        /// 不带泛型类型参数T的聚合器的类型声明。
        /// </param>
        public static void RegisterAggregator(string summaryType, Type aggregatorType) {
            _aggregatorTypes[summaryType] = aggregatorType;
        }

        internal static Aggregator<T> CreateAggregator<T>(string summaryType, IAccessor<T> accessor) {
            if (_aggregatorTypes.TryGetValue(summaryType, out var aggregatorType)) {
                var genericAggregatorType = aggregatorType.MakeGenericType(typeof(T));
                return (Aggregator<T>)Activator.CreateInstance(genericAggregatorType, accessor);
            }

            return null;
        }

        internal static bool IsRegistered(string summaryType) {
            return _aggregatorTypes.ContainsKey(summaryType);
        }

#if DEBUG
        internal static void Clear() {
            _aggregatorTypes.Clear();
        }
#endif
    }
}
