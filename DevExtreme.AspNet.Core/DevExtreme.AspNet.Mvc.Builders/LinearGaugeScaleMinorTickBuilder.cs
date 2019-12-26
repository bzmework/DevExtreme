namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the gauge's minor ticks.</summary>
	public class LinearGaugeScaleMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeScaleMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
