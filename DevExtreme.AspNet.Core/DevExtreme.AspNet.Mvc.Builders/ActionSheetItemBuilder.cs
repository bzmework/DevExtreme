namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 控件显示的项目数组。 
	/// An array of items displayed by the widget.
	/// </summary>
	public class ActionSheetItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ActionSheetItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应禁用控件项。 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定要在"操作表"按钮上显示的图标。 
		/// Specifies the icon to be displayed on the action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// 指定要在"操作表"按钮上显示的图标。 
		/// Specifies the icon to be displayed on the action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// 为表示给定操作表按钮的按钮引发的单击事件的处理程序。 
		/// A handler for the click event raised for the button representing the given action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 为表示给定操作表按钮的按钮引发的单击事件的处理程序。 
		/// A handler for the click event raised for the button representing the given action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>
		/// 指定应仅用于呈现此项的项目模板。 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>
		/// 指定为控件项显示的文本。 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定为控件项显示的文本。 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// 指定表示操作表项的按钮的类型。 
		/// Specifies the type of the button that represents an action sheet item.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Type(ButtonType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
