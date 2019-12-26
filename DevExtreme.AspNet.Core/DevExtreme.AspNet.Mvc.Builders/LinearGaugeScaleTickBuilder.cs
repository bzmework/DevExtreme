namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the gauge's major ticks.</summary>
	public class LinearGaugeScaleTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeScaleTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether scale major ticks are visible or not.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale major ticks are visible or not.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
