namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the gauge's major ticks.</summary>
	public class CircularGaugeScaleTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeScaleTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether scale major ticks are visible or not.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale major ticks are visible or not.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
