using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DevExtreme.AspNet.Data {

    /// <summary>
    /// Provides static methods for loading data from collections that implement the
    /// <see cref="System.Collections.Generic.IEnumerable{T}"/> or <see cref="System.Linq.IQueryable{T}"/> interface.
    /// 提供从实现System.Collections.Generic.IEnumerable{T}或System.Linq.IQueryable{T}的集合加载数据的静态方法
    /// </summary>
    public class DataSourceLoader {

        /// <summary>
        /// Loads data from a collection that implements the <see cref="System.Collections.Generic.IEnumerable{T}"/> interface.
        /// 从实现System.Collections.Generic.IEnumerable{T}接口的集合加载数据。
        /// </summary>
        /// <typeparam name="T">
        /// The type of objects in the collection.
        /// 集合中对象的类型。
        /// </typeparam>
        /// <param name="source">
        /// A collection that implements the <see cref="System.Collections.Generic.IEnumerable{T}"/> interface.
        /// 实现System.Collections.Generic.IEnumerable{T}接口的集合。
        /// </param>
        /// <param name="options">
        /// Data processing settings when loading data.
        /// 加载数据时的数据处理设置。
        /// </param>
        /// <returns>The load result.</returns>
        public static LoadResult Load<T>(IEnumerable<T> source, DataSourceLoadOptionsBase options) {
            return Load(source.AsQueryable(), options);
        }

        /// <summary>
        /// Loads data from a collection that implements the <see cref="System.Linq.IQueryable{T}"/> interface.
        /// 从实现T接口的集合加载数据。
        /// </summary>
        /// <typeparam name="T">
        /// The type of objects in the collection.
        /// 集合中对象的类型。
        /// </typeparam>
        /// <param name="source">
        /// A collection that implements the <see cref="System.Linq.IQueryable{T}"/> interface.
        /// 实现System.Linq.IQueryable接口的集合。
        /// </param>
        /// <param name="options">
        /// Data processing settings when loading data.
        /// 加载数据时的数据处理设置。
        /// </param>
        /// <returns>
        /// The load result.
        /// 加载结果。
        /// </returns>
        public static LoadResult Load<T>(IQueryable<T> source, DataSourceLoadOptionsBase options) {
            return LoadAsync(source, options, CancellationToken.None, true).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously loads data from a collection that implements the <see cref="System.Linq.IQueryable{T}"/> interface.
        /// 从实现System.Linq.IQueryable接口的集合异步加载数据。
        /// </summary>
        /// <typeparam name="T">
        /// The type of objects in the collection.
        /// 集合中对象的类型。
        /// </typeparam>
        /// <param name="source">
        /// A collection that implements the <see cref="System.Linq.IQueryable{T}"/> interface.
        /// 实现System.Linq.IQueryable{T}接口的集合。
        /// </param>
        /// <param name="options">
        /// Data processing settings when loading data.
        /// 加载数据时的数据处理设置。
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="System.Threading.CancellationToken"/> object that delivers a cancellation notice to the running operation.
        /// 向正在运行的操作发送取消通知的System.Threading.CancellationToken对象。 
        /// </param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task{TResult}"/> object that represents the asynchronous operation.
        /// The task result contains the load result.
        /// 表示异步操作的System.Threading.Tasks.Task{TResult}对象。任务结果包含加载结果。
        /// </returns>
        public static Task<LoadResult> LoadAsync<T>(IQueryable<T> source, DataSourceLoadOptionsBase options, CancellationToken cancellationToken = default(CancellationToken)) {
            return LoadAsync(source, options, cancellationToken, false);
        }

        static Task<LoadResult> LoadAsync<T>(IQueryable<T> source, DataSourceLoadOptionsBase options, CancellationToken ct, bool sync) {
            return new DataSourceLoaderImpl<T>(source, options, ct, sync).LoadAsync();
        }

    }

}
