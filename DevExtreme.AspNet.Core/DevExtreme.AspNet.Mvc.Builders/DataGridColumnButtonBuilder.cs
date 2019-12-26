namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Allows you to customize buttons in the editing column or create a custom command column. Applies only if the column's type is "buttons".</summary>
	public class DataGridColumnButtonBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DataGridColumnButtonBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the button.</summary>
		[Generated]
		public DataGridColumnButtonBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the button.</summary>
		[Generated]
		public DataGridColumnButtonBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies the text for the hint that appears when the button is hovered over or long-pressed.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies the text for the hint that appears when the button is hovered over or long-pressed.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies the button's icon.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the button's icon.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>The name used to identify a built-in button.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Name(GridColumnButtonName value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The name used to identify a built-in button.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The name used to identify a built-in button.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the button is clicked or tapped.</summary>
		[Generated]
		public DataGridColumnButtonBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the button is clicked or tapped.</summary>
		[Generated]
		public DataGridColumnButtonBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a custom button template.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom button template.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom button template.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom button template.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the button's text. Applies only if the button's icon is not specified.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the button's text. Applies only if the button's icon is not specified.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the button's visibility.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the button's visibility.</summary>
		[Generated]
		public DataGridColumnButtonBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
