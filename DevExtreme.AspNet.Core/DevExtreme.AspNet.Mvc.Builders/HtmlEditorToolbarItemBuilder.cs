using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This section lists the data source fields that are used in a default template for toolbar items.</summary>
	public class HtmlEditorToolbarItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public HtmlEditorToolbarItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the predefined item that this object customizes or a format with multiple choices.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatName(HtmlEditorToolbarItem value)
		{
			base.Options["formatName"] = value;
			return this;
		}

		/// <summary>Specifies the predefined item that this object customizes or a format with multiple choices.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatName(string value)
		{
			base.Options["formatName"] = value;
			return this;
		}

		/// <summary>Specifies the predefined item that this object customizes or a format with multiple choices.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatName(JS value)
		{
			base.Options["formatName"] = value;
			return this;
		}

		/// <summary>Specifies values for a format with multiple choices. Should be used with the formatName.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatValues(IEnumerable<bool> value)
		{
			base.Options["formatValues"] = value;
			return this;
		}

		/// <summary>Specifies values for a format with multiple choices. Should be used with the formatName.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatValues(IEnumerable<double> value)
		{
			base.Options["formatValues"] = value;
			return this;
		}

		/// <summary>Specifies values for a format with multiple choices. Should be used with the formatName.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatValues(IEnumerable<string> value)
		{
			base.Options["formatValues"] = value;
			return this;
		}

		/// <summary>Specifies values for a format with multiple choices. Should be used with the formatName.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder FormatValues(JS value)
		{
			base.Options["formatValues"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies when to display an item in the toolbar's overflow menu.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder LocateInMenu(ToolbarItemLocateInMenuMode value)
		{
			base.Options["locateInMenu"] = value;
			return this;
		}

		/// <summary>Specifies a location for the item on the toolbar.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Location(ToolbarItemLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder MenuItemTemplate(string templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder MenuItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder MenuItemTemplate(TemplateName name)
		{
			AssignTemplate("menuItemTemplate", name);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder MenuItemTemplate(JS value)
		{
			base.Options["menuItemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies when to display the text for the widget item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder ShowText(ToolbarItemShowTextMode value)
		{
			base.Options["showText"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A widget that presents a toolbar item.</summary>
		[Generated]
		public HtmlEditorToolbarItemBuilder Widget(Func<ToolbarItemFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "widget", "options");
			return this;
		}
	}
}
