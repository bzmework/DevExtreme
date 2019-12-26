using DevExtreme.AspNet.Mvc.Builders;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// 验证规则工厂
	/// </summary>
	public class ValidationRulesFactory : AbstractCollectionFactory
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件选项上下文</param>
		[Generated]
		public ValidationRulesFactory(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 一项要求有效场的验证规则具有价值。
		/// A validation rule that demands that a validated field has a value.
		/// </summary>
		[Generated]
		public RequiredRuleBuilder AddRequired()
		{
			RequiredRuleBuilder requiredRuleBuilder = new RequiredRuleBuilder(base.Context);
			requiredRuleBuilder.Option("type", "required");
			Add(requiredRuleBuilder);
			return requiredRuleBuilder;
		}

		/// <summary>
		/// 要求已验证字段具有数值的验证规则。
		/// A validation rule that demands that the validated field has a numeric value.
		/// </summary>
		[Generated]
		public NumericRuleBuilder AddNumeric()
		{
			NumericRuleBuilder numericRuleBuilder = new NumericRuleBuilder(base.Context);
			numericRuleBuilder.Option("type", "numeric");
			Add(numericRuleBuilder);
			return numericRuleBuilder;
		}

		/// <summary>
		/// 要求目标值在指定值范围内（包括范围的端点）的验证规则。 
		/// A validation rule that demands the target value be within the specified value range (including the range's end points).
		/// </summary>
		[Generated]
		public RangeRuleBuilder AddRange()
		{
			RangeRuleBuilder rangeRuleBuilder = new RangeRuleBuilder(base.Context);
			rangeRuleBuilder.Option("type", "range");
			Add(rangeRuleBuilder);
			return rangeRuleBuilder;
		}

		/// <summary>
		/// 要求目标值长度在指定值范围内（包括范围的端点）的验证规则。 
		/// A validation rule that demands the target value length be within the specified value range (including the range's end points).
		/// </summary>
		[Generated]
		public StringLengthRuleBuilder AddStringLength()
		{
			StringLengthRuleBuilder stringLengthRuleBuilder = new StringLengthRuleBuilder(base.Context);
			stringLengthRuleBuilder.Option("type", "stringLength");
			Add(stringLengthRuleBuilder);
			return stringLengthRuleBuilder;
		}

		/// <summary>
		/// 具有自定义验证逻辑的验证规则。 
		/// A validation rule with custom validation logic.
		/// </summary>
		[Generated]
		public CustomRuleBuilder AddCustom()
		{
			CustomRuleBuilder customRuleBuilder = new CustomRuleBuilder(base.Context);
			customRuleBuilder.Option("type", "custom");
			Add(customRuleBuilder);
			return customRuleBuilder;
		}

		/// <summary>
		/// 要求已验证编辑器具有等于指定表达式的值的验证规则。
		/// A validation rule that demands that a validated editor has a value that is equal to a specified expression.
		/// </summary>
		[Generated]
		public CompareRuleBuilder AddCompare()
		{
			CompareRuleBuilder compareRuleBuilder = new CompareRuleBuilder(base.Context);
			compareRuleBuilder.Option("type", "compare");
			Add(compareRuleBuilder);
			return compareRuleBuilder;
		}

		/// <summary>
		/// 要求验证字段与指定模式匹配的验证规则。
		/// A validation rule that demands that the validated field match a specified pattern.
		/// </summary>
		[Generated]
		public PatternRuleBuilder AddPattern()
		{
			PatternRuleBuilder patternRuleBuilder = new PatternRuleBuilder(base.Context);
			patternRuleBuilder.Option("type", "pattern");
			Add(patternRuleBuilder);
			return patternRuleBuilder;
		}

		/// <summary>
		/// 要求验证字段与电子邮件模式匹配的验证规则。 
		/// A validation rule that demands that the validated field match the Email pattern.
		/// </summary>
		[Generated]
		public EmailRuleBuilder AddEmail()
		{
			EmailRuleBuilder emailRuleBuilder = new EmailRuleBuilder(base.Context);
			emailRuleBuilder.Option("type", "email");
			Add(emailRuleBuilder);
			return emailRuleBuilder;
		}

		/// <summary>
		/// 异步检查的自定义验证规则。
		/// 使用异步规则进行服务器端验证。
		/// A custom validation rule that is checked asynchronously. 
		/// Use async rules for server-side validation.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder AddAsync()
		{
			AsyncRuleBuilder asyncRuleBuilder = new AsyncRuleBuilder(base.Context);
			asyncRuleBuilder.Option("type", "async");
			Add(asyncRuleBuilder);
			return asyncRuleBuilder;
		}
	}
}
