using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a button form item.</summary>
	public class FormButtonItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormButtonItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormButtonItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Obsolete("Use horizontalAlignment instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public FormButtonItemBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Configures the button.</summary>
		[Generated]
		public FormButtonItemBuilder ButtonOptions(Action<ButtonBuilder> configurator)
		{
			NestedOptions("buttonOptions", configurator);
			return this;
		}

		/// <summary>Specifies how many columns the item spans.</summary>
		[Generated]
		public FormButtonItemBuilder ColSpan(int value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies how many columns the item spans.</summary>
		[Generated]
		public FormButtonItemBuilder ColSpan(JS value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public FormButtonItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public FormButtonItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies the button's horizontal alignment.</summary>
		[Generated]
		public FormButtonItemBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the item's identifier.</summary>
		[Generated]
		public FormButtonItemBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the item's identifier.</summary>
		[Generated]
		public FormButtonItemBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the button's vertical alignment.</summary>
		[Generated]
		public FormButtonItemBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies whether the item is visible.</summary>
		[Generated]
		public FormButtonItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the item is visible.</summary>
		[Generated]
		public FormButtonItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the item's position regarding other items in a group, tab, or the whole widget.</summary>
		[Generated]
		public FormButtonItemBuilder VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the item's position regarding other items in a group, tab, or the whole widget.</summary>
		[Generated]
		public FormButtonItemBuilder VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}
	}
}
