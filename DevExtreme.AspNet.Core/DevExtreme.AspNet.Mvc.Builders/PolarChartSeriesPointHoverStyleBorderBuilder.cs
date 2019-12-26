namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a hovered point.</summary>
	public class PolarChartSeriesPointHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
