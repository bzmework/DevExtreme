using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class BoxItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public BoxItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BoxItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the base size of an item element along the main direction.</summary>
		[Generated]
		public BoxItemBuilder BaseSize(Mode value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>Specifies the base size of an item element along the main direction.</summary>
		[Generated]
		public BoxItemBuilder BaseSize(double value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>Specifies the base size of an item element along the main direction.</summary>
		[Generated]
		public BoxItemBuilder BaseSize(JS value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>Holds a Box configuration object for the item.</summary>
		[Generated]
		public BoxItemBuilder Box(Action<BoxBuilder> configurator)
		{
			NestedOptions("box", configurator);
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public BoxItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public BoxItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public BoxItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public BoxItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies the ratio value used to count the item element size along the main direction.</summary>
		[Generated]
		public BoxItemBuilder Ratio(double value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>Specifies the ratio value used to count the item element size along the main direction.</summary>
		[Generated]
		public BoxItemBuilder Ratio(JS value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>A factor that defines how much an item shrinks relative to the rest of the items in the container.</summary>
		[Generated]
		public BoxItemBuilder Shrink(double value)
		{
			base.Options["shrink"] = value;
			return this;
		}

		/// <summary>A factor that defines how much an item shrinks relative to the rest of the items in the container.</summary>
		[Generated]
		public BoxItemBuilder Shrink(JS value)
		{
			base.Options["shrink"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public BoxItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public BoxItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public BoxItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public BoxItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public BoxItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public BoxItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public BoxItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public BoxItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
