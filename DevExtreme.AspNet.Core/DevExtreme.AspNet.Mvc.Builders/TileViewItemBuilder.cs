namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class TileViewItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public TileViewItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TileViewItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TileViewItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public TileViewItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies a multiplier for the baseItemHeight option value (for the purpose of obtaining the actual item height).</summary>
		[Generated]
		public TileViewItemBuilder HeightRatio(double value)
		{
			base.Options["heightRatio"] = value;
			return this;
		}

		/// <summary>Specifies a multiplier for the baseItemHeight option value (for the purpose of obtaining the actual item height).</summary>
		[Generated]
		public TileViewItemBuilder HeightRatio(JS value)
		{
			base.Options["heightRatio"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TileViewItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public TileViewItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TileViewItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TileViewItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TileViewItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public TileViewItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TileViewItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public TileViewItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public TileViewItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public TileViewItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a multiplier for the baseItemWidth option value (for the purpose of obtaining the actual item width).</summary>
		[Generated]
		public TileViewItemBuilder WidthRatio(double value)
		{
			base.Options["widthRatio"] = value;
			return this;
		}

		/// <summary>Specifies a multiplier for the baseItemWidth option value (for the purpose of obtaining the actual item width).</summary>
		[Generated]
		public TileViewItemBuilder WidthRatio(JS value)
		{
			base.Options["widthRatio"] = value;
			return this;
		}
	}
}
