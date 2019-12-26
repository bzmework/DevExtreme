namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands that the validated field match the Email pattern.</summary>
	public class EmailRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public EmailRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public EmailRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public EmailRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public EmailRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public EmailRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public EmailRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}
	}
}
