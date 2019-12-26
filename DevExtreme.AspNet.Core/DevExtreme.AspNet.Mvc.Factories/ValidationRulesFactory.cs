using DevExtreme.AspNet.Mvc.Builders;

namespace DevExtreme.AspNet.Mvc.Factories
{
	/// <summary>
	/// ��֤���򹤳�
	/// </summary>
	public class ValidationRulesFactory : AbstractCollectionFactory
	{
		/// <summary>
		/// ��ʼ��
		/// </summary>
		/// <param name="context">�ؼ�ѡ��������</param>
		[Generated]
		public ValidationRulesFactory(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// һ��Ҫ����Ч������֤������м�ֵ��
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
		/// Ҫ������֤�ֶξ�����ֵ����֤����
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
		/// Ҫ��Ŀ��ֵ��ָ��ֵ��Χ�ڣ�������Χ�Ķ˵㣩����֤���� 
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
		/// Ҫ��Ŀ��ֵ������ָ��ֵ��Χ�ڣ�������Χ�Ķ˵㣩����֤���� 
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
		/// �����Զ�����֤�߼�����֤���� 
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
		/// Ҫ������֤�༭�����е���ָ�����ʽ��ֵ����֤����
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
		/// Ҫ����֤�ֶ���ָ��ģʽƥ�����֤����
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
		/// Ҫ����֤�ֶ�������ʼ�ģʽƥ�����֤���� 
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
		/// �첽�����Զ�����֤����
		/// ʹ���첽������з���������֤��
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
