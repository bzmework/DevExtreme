namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies animation options.</summary>
	public class ChartAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how long the animation runs in milliseconds.</summary>
		[Generated]
		public ChartAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies how long the animation runs in milliseconds.</summary>
		[Generated]
		public ChartAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies the easing function of the animation.</summary>
		[Generated]
		public ChartAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>Enables the animation in the widget.</summary>
		[Generated]
		public ChartAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the animation in the widget.</summary>
		[Generated]
		public ChartAnimationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies how many series points the widget should have before the animation will be disabled.</summary>
		[Generated]
		public ChartAnimationBuilder MaxPointCountSupported(int value)
		{
			base.Options["maxPointCountSupported"] = value;
			return this;
		}

		/// <summary>Specifies how many series points the widget should have before the animation will be disabled.</summary>
		[Generated]
		public ChartAnimationBuilder MaxPointCountSupported(JS value)
		{
			base.Options["maxPointCountSupported"] = value;
			return this;
		}
	}
}
