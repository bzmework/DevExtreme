using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This article describes configuration options of a tabbed form item.</summary>
	public class FormTabbedItemBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormTabbedItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> ColSpan(int value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> ColSpan(JS value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Holds a configuration object for the TabPanel widget used to display the current form item.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> TabPanelOptions(Action<TabPanelBuilder> configurator)
		{
			NestedOptions("tabPanelOptions", configurator);
			return this;
		}

		/// <summary>An array of tab configuration objects.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Tabs(Action<CollectionFactory<FormTabBuilder<T>>> configurator)
		{
			Collection("tabs", configurator);
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormTabbedItemBuilder<T> VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}
	}
}
