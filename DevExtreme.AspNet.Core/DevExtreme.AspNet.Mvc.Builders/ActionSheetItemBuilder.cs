namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// �ؼ���ʾ����Ŀ���顣 
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
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ���ÿؼ�� 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ���ÿؼ�� 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ��"������"��ť����ʾ��ͼ�ꡣ 
		/// Specifies the icon to be displayed on the action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ҫ��"������"��ť����ʾ��ͼ�ꡣ 
		/// Specifies the icon to be displayed on the action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>
		/// Ϊ��ʾ����������ť�İ�ť�����ĵ����¼��Ĵ������ 
		/// A handler for the click event raised for the button representing the given action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>
		/// Ϊ��ʾ����������ť�İ�ť�����ĵ����¼��Ĵ������ 
		/// A handler for the click event raised for the button representing the given action sheet button.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ϊ�ؼ�����ʾ���ı��� 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ϊ�ؼ�����ʾ���ı��� 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public ActionSheetItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// ָ����ʾ��������İ�ť�����͡� 
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
