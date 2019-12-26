using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ���Ϲ���
	/// </summary>
	/// <typeparam name="T">T�޶��ڱ���̳�OptionsOwnerBuilder���ʵ��ICollectionItem�ӿڵ���</typeparam>
	public class CollectionFactory<T> : AbstractCollectionFactory where T : OptionsOwnerBuilder, ICollectionItem
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ���ѡ��������</param>
		public CollectionFactory(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// ����
		/// </summary>
		/// <returns></returns>
		public T Add()
		{
			T val = New.Options<T>(base.Context);
			Add(val);
			return val;
		}

		/// <summary>
		/// ����
		/// </summary>
		/// <param name="configurator">������</param>
		/// <returns></returns>
		internal T Add(Action<IHtmlHelperAdapter, T> configurator)
		{
			T val = Add();
			configurator(base.Context.Html, val);
			return val;
		}
	}
}
