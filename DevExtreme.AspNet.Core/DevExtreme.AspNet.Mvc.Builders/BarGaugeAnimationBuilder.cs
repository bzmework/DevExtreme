namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// ָ������ѡ� 
	/// Specifies animation options.
	/// </summary>
	public class BarGaugeAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// ������ָ��ѡ� 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// ȷ���������е�ʱ�䡣 
		/// Determines how long animation runs.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>
		/// ȷ���������е�ʱ�䡣 
		/// Determines how long animation runs.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>
		/// ָ����������ģʽ�� 
		/// Specifies the animation easing mode.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>
		/// ָʾ�Ƿ����ö����� 
		/// Indicates whether or not animation is enabled.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>
		/// ָʾ�Ƿ����ö����� 
		/// Indicates whether or not animation is enabled.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
