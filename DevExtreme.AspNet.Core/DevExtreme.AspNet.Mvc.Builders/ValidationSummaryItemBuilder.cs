namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of items displayed by the widget.</summary>
	public class ValidationSummaryItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ValidationSummaryItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a widget item should be disabled.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Html(string value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies html code inserted into the widget item element.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Html(JS value)
		{
			base.Options["html"] = value;
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies an item template that should be used to render this item only.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed for the widget item.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a widget item must be displayed.</summary>
		[Generated]
		public ValidationSummaryItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
