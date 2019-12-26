using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures toolbar items.</summary>
	public class PopupToolbarItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PopupToolbarItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PopupToolbarItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a toolbar item should be disabled.</summary>
		[Generated]
		public PopupToolbarItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a toolbar item should be disabled.</summary>
		[Generated]
		public PopupToolbarItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the toolbar item element.</summary>
		[Generated]
		public PopupToolbarItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the toolbar item element.</summary>
		[Generated]
		public PopupToolbarItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies a location for the item on the toolbar.</summary>
		[Generated]
		public PopupToolbarItemBuilder Location(ToolbarItemLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public PopupToolbarItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public PopupToolbarItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public PopupToolbarItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public PopupToolbarItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the toolbar item.</summary>
		[Generated]
		public PopupToolbarItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the toolbar item.</summary>
		[Generated]
		public PopupToolbarItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether the item is displayed on a top or bottom toolbar.</summary>
		[Generated]
		public PopupToolbarItemBuilder Toolbar(Toolbar value)
		{
			base.Options["toolbar"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public PopupToolbarItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public PopupToolbarItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A widget that presents a toolbar item.</summary>
		[Generated]
		public PopupToolbarItemBuilder Widget(Func<ToolbarItemFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "widget", "options");
			return this;
		}
	}
}
