namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the point border when a user pauses on the point.</summary>
	public class ChartSeriesPointHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the border visible when a user pauses on the series point.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the border visible when a user pauses on the series point.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
