namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class GalleryItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public GalleryItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GalleryItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public GalleryItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public GalleryItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public GalleryItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public GalleryItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies the text passed to the alt attribute of the image markup element.</summary>
		[Generated]
		public GalleryItemBuilder ImageAlt(string value)
		{
			base.Options["imageAlt"] = value;
			return this;
		}

		/// <summary>Specifies the text passed to the alt attribute of the image markup element.</summary>
		[Generated]
		public GalleryItemBuilder ImageAlt(JS value)
		{
			base.Options["imageAlt"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image displayed by the item.</summary>
		[Generated]
		public GalleryItemBuilder ImageSrc(string value)
		{
			base.Options["imageSrc"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image displayed by the item.</summary>
		[Generated]
		public GalleryItemBuilder ImageSrc(JS value)
		{
			base.Options["imageSrc"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public GalleryItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public GalleryItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public GalleryItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public GalleryItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public GalleryItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public GalleryItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
