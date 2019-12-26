namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This article describes configuration options of an empty form item.</summary>
	public class FormEmptyItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormEmptyItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormEmptyItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormEmptyItemBuilder ColSpan(int value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormEmptyItemBuilder ColSpan(JS value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormEmptyItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormEmptyItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormEmptyItemBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormEmptyItemBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormEmptyItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormEmptyItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormEmptyItemBuilder VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormEmptyItemBuilder VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}
	}
}
