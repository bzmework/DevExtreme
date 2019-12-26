using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a hovered point.</summary>
	public class PolarChartSeriesPointHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Border(Action<PolarChartSeriesPointHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a point when it is hovered over.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a point when it is hovered over.</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a hovered point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a hovered point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointHoverStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
