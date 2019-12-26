using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 集合工厂
	/// </summary>
	/// <typeparam name="T">T限定在必须继承OptionsOwnerBuilder类和实现ICollectionItem接口的类</typeparam>
	public class CollectionFactory<T> : AbstractCollectionFactory where T : OptionsOwnerBuilder, ICollectionItem
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		public CollectionFactory(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 增加
		/// </summary>
		/// <returns></returns>
		public T Add()
		{
			T val = New.Options<T>(base.Context);
			Add(val);
			return val;
		}

		/// <summary>
		/// 增加
		/// </summary>
		/// <param name="configurator">配置器</param>
		/// <returns></returns>
		internal T Add(Action<IHtmlHelperAdapter, T> configurator)
		{
			T val = Add();
			configurator(base.Context.Html, val);
			return val;
		}
	}
}
