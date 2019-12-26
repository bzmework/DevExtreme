namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify text for various elements of the popup menu.</summary>
	public class TreeListHeaderFilterTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListHeaderFilterTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder Cancel(string value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that closes the popup menu without applying a filter.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder Cancel(JS value)
		{
			base.Options["cancel"] = value;
			return this;
		}

		/// <summary>Specifies a name for the item that represents empty values in the popup menu.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder EmptyValue(string value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies a name for the item that represents empty values in the popup menu.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder EmptyValue(JS value)
		{
			base.Options["emptyValue"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that applies the specified filter.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder Ok(string value)
		{
			base.Options["ok"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that applies the specified filter.</summary>
		[Generated]
		public TreeListHeaderFilterTextsBuilder Ok(JS value)
		{
			base.Options["ok"] = value;
			return this;
		}
	}
}
