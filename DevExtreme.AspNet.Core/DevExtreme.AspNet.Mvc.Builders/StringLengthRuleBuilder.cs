namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands the target value length be within the specified value range (including the range's end points).</summary>
	public class StringLengthRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public StringLengthRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public StringLengthRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public StringLengthRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public StringLengthRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the maximum length allowed for the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum length allowed for the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public StringLengthRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public StringLengthRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length allowed for the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length allowed for the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to remove the Space characters from the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Trim(bool value)
		{
			base.Options["trim"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to remove the Space characters from the validated value.</summary>
		[Generated]
		public StringLengthRuleBuilder Trim(JS value)
		{
			base.Options["trim"] = value;
			return this;
		}
	}
}
