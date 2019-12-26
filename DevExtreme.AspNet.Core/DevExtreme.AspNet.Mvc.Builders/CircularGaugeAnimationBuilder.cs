namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies animation options.</summary>
	public class CircularGaugeAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Determines how long animation runs.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Determines how long animation runs.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies the animation easing mode.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public CircularGaugeAnimationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
