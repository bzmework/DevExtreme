namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 控件显示的项目数组。 
	/// An array of items displayed by the widget.
	/// </summary>
	public class AutocompleteItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public AutocompleteItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定插入到控件项元素中的html代码。 
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// 指定插入到控件项元素中的html代码。 
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>
		/// 指定为控件项显示的文本。 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定为控件项显示的文本。 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否必须显示控件项。 
		/// Specifies whether or not a widget item must be displayed.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否必须显示控件项。 
		/// Specifies whether or not a widget item must be displayed.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
