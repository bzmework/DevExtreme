using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the toolbar item.</summary>
	public class FileManagerToolbarItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FileManagerToolbarItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies when to display an item in the toolbar's overflow menu.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder LocateInMenu(ToolbarItemLocateInMenuMode value)
		{
			base.Options["locateInMenu"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's location.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Location(ToolbarItemLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder MenuItemTemplate(string templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder MenuItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder MenuItemTemplate(TemplateName name)
		{
			AssignTemplate("menuItemTemplate", name);
			return this;
		}

		/// <summary>Specifies a template that should be used to render a menu item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder MenuItemTemplate(JS value)
		{
			base.Options["menuItemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's name.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Name(FileManagerToolbarItem value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's name.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's name.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies when to display the text for the widget item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder ShowText(ToolbarItemShowTextMode value)
		{
			base.Options["showText"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's visibility.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the toolbar item's visibility.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A widget that presents a toolbar item.</summary>
		[Generated]
		public FileManagerToolbarItemBuilder Widget(Func<ToolbarItemFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "widget", "options");
			return this;
		}
	}
}
