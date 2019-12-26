namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands that a validated field has a value.</summary>
	public class RequiredRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public RequiredRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RequiredRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public RequiredRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public RequiredRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Indicates whether to remove the Space characters from the validated value.</summary>
		[Generated]
		public RequiredRuleBuilder Trim(bool value)
		{
			base.Options["trim"] = value;
			return this;
		}

		/// <summary>Indicates whether to remove the Space characters from the validated value.</summary>
		[Generated]
		public RequiredRuleBuilder Trim(JS value)
		{
			base.Options["trim"] = value;
			return this;
		}
	}
}
