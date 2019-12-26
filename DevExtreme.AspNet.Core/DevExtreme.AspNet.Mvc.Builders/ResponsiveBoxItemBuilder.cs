using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class ResponsiveBoxItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ResponsiveBoxItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies the item location and size against the widget grid.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Location(Action<CollectionFactory<ResponsiveBoxItemsLocationBuilder>> configurator)
		{
			Collection("location", configurator);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ResponsiveBoxItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
