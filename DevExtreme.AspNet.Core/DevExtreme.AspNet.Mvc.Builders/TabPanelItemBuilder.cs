namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class TabPanelItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public TabPanelItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TabPanelItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a badge text for the tab.</summary>
		[Generated]
		public TabPanelItemBuilder Badge(string value)
		{
			base.Options["badge"] = value;
			return this;
		}

		/// <summary>Specifies a badge text for the tab.</summary>
		[Generated]
		public TabPanelItemBuilder Badge(JS value)
		{
			base.Options["badge"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TabPanelItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TabPanelItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TabPanelItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TabPanelItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed in the tab's title.</summary>
		[Generated]
		public TabPanelItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed in the tab's title.</summary>
		[Generated]
		public TabPanelItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies a template that should be used to render the tab for this item only.</summary>
		[Generated]
		public TabPanelItemBuilder TabTemplate(string templateContent)
		{
			AssignTemplate("tabTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render the tab for this item only.</summary>
		[Generated]
		public TabPanelItemBuilder TabTemplate(RazorBlock templateContent)
		{
			AssignTemplate("tabTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render the tab for this item only.</summary>
		[Generated]
		public TabPanelItemBuilder TabTemplate(TemplateName name)
		{
			AssignTemplate("tabTemplate", name);
			return this;
		}

		/// <summary>Specifies a template that should be used to render the tab for this item only.</summary>
		[Generated]
		public TabPanelItemBuilder TabTemplate(JS value)
		{
			base.Options["tabTemplate"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TabPanelItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TabPanelItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TabPanelItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TabPanelItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TabPanelItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TabPanelItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the item title text displayed on a corresponding tab.</summary>
		[Generated]
		public TabPanelItemBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the item title text displayed on a corresponding tab.</summary>
		[Generated]
		public TabPanelItemBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}
	}
}
