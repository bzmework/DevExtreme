namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the gauge's minor ticks.</summary>
	public class CircularGaugeScaleMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeScaleMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
