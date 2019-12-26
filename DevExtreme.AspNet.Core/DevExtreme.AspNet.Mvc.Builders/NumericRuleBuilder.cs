namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands that the validated field has a numeric value.</summary>
	public class NumericRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public NumericRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public NumericRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public NumericRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public NumericRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public NumericRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public NumericRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}
	}
}
