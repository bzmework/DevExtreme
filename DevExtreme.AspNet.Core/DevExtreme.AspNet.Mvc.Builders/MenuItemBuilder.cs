using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This section lists the data source fields that are used in a default item template.</summary>
	public class MenuItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public MenuItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a group separator is displayed over the item.</summary>
		[Generated]
		public MenuItemBuilder BeginGroup(bool value)
		{
			base.Options["beginGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether a group separator is displayed over the item.</summary>
		[Generated]
		public MenuItemBuilder BeginGroup(JS value)
		{
			base.Options["beginGroup"] = value;
			return this;
		}

		/// <summary>Specifies if a menu is closed when a user clicks the item.</summary>
		[Generated]
		public MenuItemBuilder CloseMenuOnClick(bool value)
		{
			base.Options["closeMenuOnClick"] = value;
			return this;
		}

		/// <summary>Specifies if a menu is closed when a user clicks the item.</summary>
		[Generated]
		public MenuItemBuilder CloseMenuOnClick(JS value)
		{
			base.Options["closeMenuOnClick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is disabled.</summary>
		[Generated]
		public MenuItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is disabled.</summary>
		[Generated]
		public MenuItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the menu item's icon.</summary>
		[Generated]
		public MenuItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the menu item's icon.</summary>
		[Generated]
		public MenuItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Holds an array of menu items.</summary>
		[Generated]
		public MenuItemBuilder Items(Action<CollectionFactory<MenuItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies whether or not a user can select a menu item.</summary>
		[Generated]
		public MenuItemBuilder Selectable(bool value)
		{
			base.Options["selectable"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a user can select a menu item.</summary>
		[Generated]
		public MenuItemBuilder Selectable(JS value)
		{
			base.Options["selectable"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the item is selected.</summary>
		[Generated]
		public MenuItemBuilder Selected(bool value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the item is selected.</summary>
		[Generated]
		public MenuItemBuilder Selected(JS value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public MenuItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public MenuItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public MenuItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public MenuItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the text inserted into the item element.</summary>
		[Generated]
		public MenuItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text inserted into the item element.</summary>
		[Generated]
		public MenuItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is visible.</summary>
		[Generated]
		public MenuItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is visible.</summary>
		[Generated]
		public MenuItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
