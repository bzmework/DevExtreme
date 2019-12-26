using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ����Ŀ������
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class FormItemsFactory<T> : AbstractCollectionFactory
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="configurator"></param>
		/// <returns></returns>
		internal FormSimpleItemBuilder AddSimple(Action<IHtmlHelperAdapter, FormSimpleItemBuilder> configurator)
		{
			FormSimpleItemBuilder formSimpleItemBuilder = AddSimple();
			configurator(base.Context.Html, formSimpleItemBuilder);
			return formSimpleItemBuilder;
		}

		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context"></param>
		[Generated]
		public FormItemsFactory(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// ���������ձ��������ѡ� 
		/// This article describes configuration options of an empty form item.
		/// </summary>
		[Generated]
		public FormEmptyItemBuilder AddEmpty()
		{
			FormEmptyItemBuilder formEmptyItemBuilder = new FormEmptyItemBuilder(base.Context);
			formEmptyItemBuilder.Option("itemType", "empty");
			Add(formEmptyItemBuilder);
			return formEmptyItemBuilder;
		}

		/// <summary>
		/// ������������������ѡ� 
		/// This article describes configuration options of a group form item.
		/// </summary>
		[Generated]
		public FormGroupItemBuilder<T> AddGroup()
		{
			FormGroupItemBuilder<T> formGroupItemBuilder = new FormGroupItemBuilder<T>(base.Context);
			formGroupItemBuilder.Option("itemType", "group");
			Add(formGroupItemBuilder);
			return formGroupItemBuilder;
		}

		/// <summary>
		/// ����������һ���򵥱��������ѡ� 
		/// This article describes configuration options of a simple form item.
		/// </summary>
		[Generated]
		public FormSimpleItemBuilder AddSimple()
		{
			FormSimpleItemBuilder formSimpleItemBuilder = new FormSimpleItemBuilder(base.Context);
			formSimpleItemBuilder.Option("itemType", "simple");
			Add(formSimpleItemBuilder);
			return formSimpleItemBuilder;
		}

		/// <summary>
		/// ����������ѡ�ʽ���������ѡ� 
		/// This article describes configuration options of a tabbed form item.
		/// </summary>
		[Generated]
		public FormTabbedItemBuilder<T> AddTabbed()
		{
			FormTabbedItemBuilder<T> formTabbedItemBuilder = new FormTabbedItemBuilder<T>(base.Context);
			formTabbedItemBuilder.Option("itemType", "tabbed");
			Add(formTabbedItemBuilder);
			return formTabbedItemBuilder;
		}

		/// <summary>
		/// ���ð�ť����� 
		/// Configures a button form item.
		/// </summary>
		[Generated]
		public FormButtonItemBuilder AddButton()
		{
			FormButtonItemBuilder formButtonItemBuilder = new FormButtonItemBuilder(base.Context);
			formButtonItemBuilder.Option("itemType", "button");
			Add(formButtonItemBuilder);
			return formButtonItemBuilder;
		}
	}
}
