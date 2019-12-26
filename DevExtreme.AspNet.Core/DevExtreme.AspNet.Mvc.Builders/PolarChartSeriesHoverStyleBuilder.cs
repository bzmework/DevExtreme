using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a hovered series.</summary>
	public class PolarChartSeriesHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a hovered series.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Border(Action<PolarChartSeriesHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a series when it is hovered over.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a series when it is hovered over.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style for the line in a hovered series.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a series is hovered over.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Hatching(Action<PolarChartSeriesHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the width of a line in a hovered series.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of a line in a hovered series.</summary>
		[Generated]
		public PolarChartSeriesHoverStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
