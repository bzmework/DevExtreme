using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This section lists the data source fields that are used in a default item template.</summary>
	public class TreeViewItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public TreeViewItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeViewItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TreeViewItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TreeViewItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item is displayed expanded.</summary>
		[Generated]
		public TreeViewItemBuilder Expanded(bool value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item is displayed expanded.</summary>
		[Generated]
		public TreeViewItemBuilder Expanded(JS value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item has children.</summary>
		[Generated]
		public TreeViewItemBuilder HasItems(bool value)
		{
			base.Options["hasItems"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item has children.</summary>
		[Generated]
		public TreeViewItemBuilder HasItems(JS value)
		{
			base.Options["hasItems"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TreeViewItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TreeViewItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies the tree view item's icon.</summary>
		[Generated]
		public TreeViewItemBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the tree view item's icon.</summary>
		[Generated]
		public TreeViewItemBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Holds an array of tree view items.</summary>
		[Generated]
		public TreeViewItemBuilder Items(Action<CollectionFactory<TreeViewItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Holds the key of the parent item.</summary>
		[Generated]
		public TreeViewItemBuilder ParentId(double value)
		{
			base.Options["parentId"] = value;
			return this;
		}

		/// <summary>Holds the key of the parent item.</summary>
		[Generated]
		public TreeViewItemBuilder ParentId(string value)
		{
			base.Options["parentId"] = value;
			return this;
		}

		/// <summary>Holds the key of the parent item.</summary>
		[Generated]
		public TreeViewItemBuilder ParentId(JS value)
		{
			base.Options["parentId"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item is displayed selected.</summary>
		[Generated]
		public TreeViewItemBuilder Selected(bool value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the tree view item is displayed selected.</summary>
		[Generated]
		public TreeViewItemBuilder Selected(JS value)
		{
			base.Options["selected"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TreeViewItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TreeViewItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TreeViewItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TreeViewItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TreeViewItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TreeViewItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public TreeViewItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public TreeViewItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
