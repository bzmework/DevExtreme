namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// �첽�����Զ�����֤����
	/// ʹ���첽������з���������֤��
	/// A custom validation rule that is checked asynchronously. 
	/// Use async rules for server-side validation.
	/// </summary>
	public class AsyncRuleBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public AsyncRuleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// �������Ϊtrue�����ֵ��Ч�� 
		/// If set to true, empty values are valid.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>
		/// �������Ϊtrue�����ֵ��Ч�� 
		/// If set to true, empty values are valid.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>
		/// ָ�������ƻ�ʱ��ʾ����Ϣ�� 
		/// Specifies the message that is shown if the rule is broken.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>
		/// ָ�������ƻ�ʱ��ʾ����Ϣ�� 
		/// Specifies the message that is shown if the rule is broken.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>
		/// ָʾ�Ƿ�Ӧʼ��ΪĿ��ֵ�����򣬻����ֵ����ʱ�ż����� 
		/// Indicates whether the rule should always be checked for the target value or only when the value changes.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Reevaluate(bool value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>
		/// ָʾ�Ƿ�Ӧʼ��ΪĿ��ֵ�����򣬻����ֵ����ʱ�ż����� 
		/// Indicates whether the rule should always be checked for the target value or only when the value changes.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Reevaluate(JS value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>
		/// ��֤Ŀ��ֵ�ĺ����� 
		/// A function that validates the target value.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder ValidationCallback(string jsFunc)
		{
			AssignJS("validationCallback", jsFunc);
			return this;
		}

		/// <summary>
		/// ��֤Ŀ��ֵ�ĺ����� 
		/// A function that validates the target value.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder ValidationCallback(RazorBlock jsFunc)
		{
			return ValidationCallback(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
