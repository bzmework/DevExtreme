using DevExtreme.AspNet.Mvc.Builders;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 抽象集合工厂
	/// </summary>
	public abstract class AbstractCollectionFactory
	{
		private ICollection<OptionsOwnerBuilder> _itemBuilders;

		/// <summary>
		/// 控件可选项上下文
		/// </summary>
		protected OptionsOwnerContext Context
		{
			get;
			private set;
		}

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		protected AbstractCollectionFactory(OptionsOwnerContext context)
		{
			_itemBuilders = new List<OptionsOwnerBuilder>();
			Context = context;
		}

		/// <summary>
		/// 拥有者，谁拥有控件。
		/// </summary>
		/// <param name="item"></param>
		protected void Add(OptionsOwnerBuilder item)
		{
			(item as ICollectionItem).Index = _itemBuilders.Count;
			_itemBuilders.Add(item);
		}

		/// <summary>
		/// 添加到父控件可选项上下文
		/// </summary>
		/// <param name="parentOptions"></param>
		protected internal virtual void AttachToParent(IDictionary<string, object> parentOptions)
		{
			foreach (OptionsOwnerBuilder itemBuilder in _itemBuilders)
			{
				itemBuilder.AttachCollectionItemToParent(parentOptions);
			}
		}

		/// <summary>
		/// 已经有父控件可选项上下文
		/// </summary>
		/// <param name="names"></param>
		/// <returns></returns>
		internal bool HasParentOwner(params string[] names)
		{
			return Context.Owner.HasParentOwner(names);
		}
	}
}
