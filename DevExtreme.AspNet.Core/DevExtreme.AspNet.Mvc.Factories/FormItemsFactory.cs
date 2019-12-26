using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Internals;
using System;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 表单项目集工厂
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
		/// 初始化
		/// </summary>
		/// <param name="context"></param>
		[Generated]
		public FormItemsFactory(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// 本文描述空表单项的配置选项。 
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
		/// 本文描述组表单项的配置选项。 
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
		/// 本文描述了一个简单表单项的配置选项。 
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
		/// 本文描述了选项卡式表单项的配置选项。 
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
		/// 配置按钮窗体项。 
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
