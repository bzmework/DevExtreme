using DevExtreme.AspNet.Mvc.Builders;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ���󼯺Ϲ���
	/// </summary>
	public abstract class AbstractCollectionFactory
	{
		private ICollection<OptionsOwnerBuilder> _itemBuilders;

		/// <summary>
		/// �ؼ���ѡ��������
		/// </summary>
		protected OptionsOwnerContext Context
		{
			get;
			private set;
		}

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		protected AbstractCollectionFactory(OptionsOwnerContext context)
		{
			_itemBuilders = new List<OptionsOwnerBuilder>();
			Context = context;
		}

		/// <summary>
		/// ӵ���ߣ�˭ӵ�пؼ���
		/// </summary>
		/// <param name="item"></param>
		protected void Add(OptionsOwnerBuilder item)
		{
			(item as ICollectionItem).Index = _itemBuilders.Count;
			_itemBuilders.Add(item);
		}

		/// <summary>
		/// ��ӵ����ؼ���ѡ��������
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
		/// �Ѿ��и��ؼ���ѡ��������
		/// </summary>
		/// <param name="names"></param>
		/// <returns></returns>
		internal bool HasParentOwner(params string[] names)
		{
			return Context.Owner.HasParentOwner(names);
		}
	}
}
