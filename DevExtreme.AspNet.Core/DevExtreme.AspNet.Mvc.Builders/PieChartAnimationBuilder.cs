namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies animation options.</summary>
	public class PieChartAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how long the animation runs in milliseconds.</summary>
		[Generated]
		public PieChartAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies how long the animation runs in milliseconds.</summary>
		[Generated]
		public PieChartAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies the easing function of the animation.</summary>
		[Generated]
		public PieChartAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>Enables the animation in the widget.</summary>
		[Generated]
		public PieChartAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the animation in the widget.</summary>
		[Generated]
		public PieChartAnimationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies how many series points the widget should have before the animation will be disabled.</summary>
		[Generated]
		public PieChartAnimationBuilder MaxPointCountSupported(int value)
		{
			base.Options["maxPointCountSupported"] = value;
			return this;
		}

		/// <summary>Specifies how many series points the widget should have before the animation will be disabled.</summary>
		[Generated]
		public PieChartAnimationBuilder MaxPointCountSupported(JS value)
		{
			base.Options["maxPointCountSupported"] = value;
			return this;
		}
	}
}
