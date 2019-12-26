namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// �ؼ���ʾ����Ŀ���顣 
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
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ���ÿؼ�� 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ�Ӧ���ÿؼ�� 
		/// Specifies whether a widget item should be disabled.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����뵽�ؼ���Ԫ���е�html���롣 
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// ָ�����뵽�ؼ���Ԫ���е�html���롣 
		/// Specifies html code inserted into the widget item element.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>
		/// ָ��Ӧ�����ڳ��ִ������Ŀģ�塣 
		/// Specifies an item template that should be used to render this item only.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ϊ�ؼ�����ʾ���ı��� 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// ָ��Ϊ�ؼ�����ʾ���ı��� 
		/// Specifies text displayed for the widget item.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ������ʾ�ؼ�� 
		/// Specifies whether or not a widget item must be displayed.
		/// </summary>
		[Generated]
		public AutocompleteItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// ָ���Ƿ������ʾ�ؼ�� 
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
