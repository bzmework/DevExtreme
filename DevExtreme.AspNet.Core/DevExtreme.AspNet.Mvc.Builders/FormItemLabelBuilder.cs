namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for the form item label.</summary>
	public class FormItemLabelBuilder : OptionsOwnerBuilder
	{
		protected override bool IsMergable => true;

		[Generated]
		public FormItemLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormItemLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the label's horizontal alignment.</summary>
		[Generated]
		public FormItemLabelBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies the location of a label against the editor.</summary>
		[Generated]
		public FormItemLabelBuilder Location(FormLabelLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a colon is displayed at the end of the current label.</summary>
		[Generated]
		public FormItemLabelBuilder ShowColon(bool value)
		{
			base.Options["showColon"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a colon is displayed at the end of the current label.</summary>
		[Generated]
		public FormItemLabelBuilder ShowColon(JS value)
		{
			base.Options["showColon"] = value;
			return this;
		}

		/// <summary>Specifies the label text.</summary>
		[Generated]
		public FormItemLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the label text.</summary>
		[Generated]
		public FormItemLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the label is visible.</summary>
		[Generated]
		public FormItemLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the label is visible.</summary>
		[Generated]
		public FormItemLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
