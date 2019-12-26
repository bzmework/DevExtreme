namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 控件显示的项目数组。
	/// An array of items displayed by the widget.
	/// </summary>
	public class AccordionItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		[Generated]
		public AccordionItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 指定一个选项的名称。
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定插入控件项元素的html代码。
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// 指定插入控件项元素的html代码。
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// 指定要显示在面板标题中的图标。
		/// Specifies the icon to be displayed in the panel's title.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// 指定要显示在面板标题中的图标。
		/// Specifies the icon to be displayed in the panel's title.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// 指定仅用于呈现此项的项目模板。
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定仅用于呈现此项的项目模板。
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定仅用于呈现此项的项目模板。
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>
		/// 指定仅用于呈现此项的项目模板。
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件项显示的文本。
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件项显示的文本。
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件项标题显示的文本。
		/// Specifies text displayed for the widget item title.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件项标题显示的文本。
		/// Specifies text displayed for the widget item title.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否必须显示控件项。
		/// Specifies whether or not a widget item must be displayed.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否必须显示控件项。
		/// Specifies whether or not a widget item must be displayed.
		/// </summary>
		[Generated]
		public AccordionItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
