using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a selected series.</summary>
	public class PolarChartCommonSeriesSettingsSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Border(Action<PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style for the line in a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a series is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Hatching(Action<PolarChartCommonSeriesSettingsSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the width of a line in a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of a line in a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
