using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a selected series.</summary>
	public class PolarChartSeriesSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Border(Action<PolarChartSeriesSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style for the line in a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a series is selected.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Hatching(Action<PolarChartSeriesSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the width of a line in a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of a line in a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
