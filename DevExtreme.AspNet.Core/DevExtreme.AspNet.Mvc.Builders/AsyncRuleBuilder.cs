namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 异步检查的自定义验证规则。
	/// 使用异步规则进行服务器端验证。
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
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 如果设置为true，则空值有效。 
		/// If set to true, empty values are valid.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder IgnoreEmptyValue(bool value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>
		/// 如果设置为true，则空值有效。 
		/// If set to true, empty values are valid.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder IgnoreEmptyValue(JS value)
		{
			base.Options["ignoreEmptyValue"] = value;
			return this;
		}

		/// <summary>
		/// 指定规则被破坏时显示的消息。 
		/// Specifies the message that is shown if the rule is broken.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>
		/// 指定规则被破坏时显示的消息。 
		/// Specifies the message that is shown if the rule is broken.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>
		/// 指示是否应始终为目标值检查规则，或仅当值更改时才检查规则。 
		/// Indicates whether the rule should always be checked for the target value or only when the value changes.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Reevaluate(bool value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>
		/// 指示是否应始终为目标值检查规则，或仅当值更改时才检查规则。 
		/// Indicates whether the rule should always be checked for the target value or only when the value changes.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder Reevaluate(JS value)
		{
			base.Options["reevaluate"] = value;
			return this;
		}

		/// <summary>
		/// 验证目标值的函数。 
		/// A function that validates the target value.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder ValidationCallback(string jsFunc)
		{
			AssignJS("validationCallback", jsFunc);
			return this;
		}

		/// <summary>
		/// 验证目标值的函数。 
		/// A function that validates the target value.
		/// </summary>
		[Generated]
		public AsyncRuleBuilder ValidationCallback(RazorBlock jsFunc)
		{
			return ValidationCallback(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
