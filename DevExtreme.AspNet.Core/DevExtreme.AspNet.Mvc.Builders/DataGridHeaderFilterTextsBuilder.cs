namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify text for various elements of the popup menu.</summary>
	public class DataGridHeaderFilterTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridHeaderFilterTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder Cancel(string value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder Cancel(JS value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies a name for the item that represents empty values in the popup menu.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder EmptyValue(string value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies a name for the item that represents empty values in the popup menu.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder EmptyValue(JS value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that applies the specified filter.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder Ok(string value)
		{
			base.Options["ok"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that applies the specified filter.</summary>
		[Generated]
		public DataGridHeaderFilterTextsBuilder Ok(JS value)
		{
			base.Options["ok"] = value;
			return this;
		}
	}
}
