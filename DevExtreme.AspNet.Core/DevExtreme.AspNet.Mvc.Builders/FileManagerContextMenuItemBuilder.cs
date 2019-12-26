using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures context menu items' settings.</summary>
	public class FileManagerContextMenuItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FileManagerContextMenuItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a group separator is displayed over the item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder BeginGroup(bool value)
		{
			base.Options["beginGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether a group separator is displayed over the item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder BeginGroup(JS value)
		{
			base.Options["beginGroup"] = value;
			return this;
		}

		/// <summary>Specifies if a menu is closed when a user clicks the item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder CloseMenuOnClick(bool value)
		{
			base.Options["closeMenuOnClick"] = value;
			return this;
		}

		/// <summary>Specifies if a menu is closed when a user clicks the item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder CloseMenuOnClick(JS value)
		{
			base.Options["closeMenuOnClick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is disabled.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu item is disabled.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the menu item's icon.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the menu item's icon.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Holds an array of menu items.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Items(Action<CollectionFactory<ContextMenuItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies the context menu item's name.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Name(FileManagerContextMenuItem value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the context menu item's name.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the context menu item's name.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a user can select a menu item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Selectable(bool value)
		{
			base.Options["selectable"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a user can select a menu item.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Selectable(JS value)
		{
			base.Options["selectable"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the item is selected.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Selected(bool value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the item is selected.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Selected(JS value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the text inserted into the item element.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text inserted into the item element.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the context menu item's visibility.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the context menu item's visibility.</summary>
		[Generated]
		public FileManagerContextMenuItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
