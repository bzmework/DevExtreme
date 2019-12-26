namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule with custom validation logic.</summary>
	public class CustomRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public CustomRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CustomRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the validationCallback should be called for null and undefined values.</summary>
		[Generated]
		public CustomRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the validationCallback should be called for null and undefined values.</summary>
		[Generated]
		public CustomRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public CustomRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public CustomRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Indicates whether the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public CustomRuleBuilder Reevaluate(bool value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>Indicates whether the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public CustomRuleBuilder Reevaluate(JS value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>A function that validates the target value.</summary>
		[Generated]
		public CustomRuleBuilder ValidationCallback(string jsFunc)
		{
			AssignJS("validationCallback", jsFunc);
			return this;
		}

		/// <summary>A function that validates the target value.</summary>
		[Generated]
		public CustomRuleBuilder ValidationCallback(RazorBlock jsFunc)
		{
			return ValidationCallback(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
