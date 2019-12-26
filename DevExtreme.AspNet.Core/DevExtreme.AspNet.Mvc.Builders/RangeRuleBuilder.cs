using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A validation rule that demands the target value be within the specified value range (including the range's end points).</summary>
	public class RangeRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public RangeRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public RangeRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>If set to true, empty values are valid.</summary>
		[Generated]
		public RangeRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public RangeRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown if the rule is broken.</summary>
		[Generated]
		public RangeRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value allowed for the validated value.</summary>
		[Generated]
		public RangeRuleBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Indicates whether the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public RangeRuleBuilder Reevaluate(bool value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>Indicates whether the rule should be always checked for the target value or only when the target value changes.</summary>
		[Generated]
		public RangeRuleBuilder Reevaluate(JS value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}
	}
}
