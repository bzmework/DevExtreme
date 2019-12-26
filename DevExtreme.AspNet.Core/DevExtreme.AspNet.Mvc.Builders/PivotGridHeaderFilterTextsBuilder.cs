namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the texts of the popup menu's elements.</summary>
	public class PivotGridHeaderFilterTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridHeaderFilterTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the text of the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder Cancel(string value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies the text of the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder Cancel(JS value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies the name of the item that represents empty values in the popup menu.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder EmptyValue(string value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the name of the item that represents empty values in the popup menu.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder EmptyValue(JS value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the text of the button that applies a filter.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder Ok(string value)
		{
			base.Options["ok"] = value;
			return this;
		}

		/// <summary>Specifies the text of the button that applies a filter.</summary>
		[Generated]
		public PivotGridHeaderFilterTextsBuilder Ok(JS value)
		{
			base.Options["ok"] = value;
			return this;
		}
	}
}
