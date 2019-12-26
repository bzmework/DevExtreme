namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies animation options.</summary>
	public class LinearGaugeAnimationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeAnimationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Determines how long animation runs.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Duration(double value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Determines how long animation runs.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Duration(JS value)
		{
			base.Options["duration"] = value;
			return this;
		}

		/// <summary>Specifies the animation easing mode.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Easing(VizAnimationEasing value)
		{
			base.Options["easing"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public LinearGaugeAnimationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
