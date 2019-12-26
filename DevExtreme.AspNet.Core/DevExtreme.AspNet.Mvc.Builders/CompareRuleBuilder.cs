namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands that a validated editor has a value that is equal to a specified expression.</summary>
	public class CompareRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public CompareRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CompareRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the function whose return value is used for comparison with the validated value.</summary>
		[Generated]
		public CompareRuleBuilder ComparisonTarget(string jsFunc)
		{
			AssignJS("comparisonTarget", jsFunc);
			return this;
		}

		/// <summary>Specifies the function whose return value is used for comparison with the validated value.</summary>
		[Generated]
		public CompareRuleBuilder ComparisonTarget(RazorBlock jsFunc)
		{
			return ComparisonTarget(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the operator to be used for comparing the validated value with the target.</summary>
		[Generated]
		public CompareRuleBuilder ComparisonType(ComparisonOperator value)
		{
			base.Options["comparisonType"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public CompareRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public CompareRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public CompareRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public CompareRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public CompareRuleBuilder Reevaluate(bool value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public CompareRuleBuilder Reevaluate(JS value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}
	}
}
