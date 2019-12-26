namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 指定动画选项。 
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
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 确定动画运行的时间。 
		/// Determines how long animation runs.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>
		/// 确定动画运行的时间。 
		/// Determines how long animation runs.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>
		/// 指定动画缓和模式。 
		/// Specifies the animation easing mode.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>
		/// 指示是否启用动画。 
		/// Indicates whether or not animation is enabled.
		/// </summary>
		[Generated]
		public BarGaugeAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>
		/// 指示是否启用动画。 
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
