using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class ToolbarItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ToolbarItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ToolbarItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public ToolbarItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public ToolbarItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ToolbarItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ToolbarItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ToolbarItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ToolbarItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies when to display an item in the toolbar's overflow menu.</summary>
		[Generated]
		public ToolbarItemBuilder LocateInMenu(ToolbarItemLocateInMenuMode value)
		{
			base.Options["locateInMenu"] = value;
			return this;
		}

		/// <summary>Specifies a location for the item on the toolbar.</summary>
		[Generated]
		public ToolbarItemBuilder Location(ToolbarItemLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public ToolbarItemBuilder MenuItemTemplate(string templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public ToolbarItemBuilder MenuItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public ToolbarItemBuilder MenuItemTemplate(TemplateName name)
		{
			AssignTemplate("menuItemTemplate", name);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public ToolbarItemBuilder MenuItemTemplate(JS value)
		{
			base.Options["menuItemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies when to display the text for the widget item.</summary>
		[Generated]
		public ToolbarItemBuilder ShowText(ToolbarItemShowTextMode value)
		{
			base.Options["showText"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ToolbarItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ToolbarItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ToolbarItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ToolbarItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ToolbarItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ToolbarItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ToolbarItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ToolbarItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A widget that presents a toolbar item.</summary>
		[Generated]
		public ToolbarItemBuilder Widget(Func<ToolbarItemFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "widget", "options");
			return this;
		}
	}
}
