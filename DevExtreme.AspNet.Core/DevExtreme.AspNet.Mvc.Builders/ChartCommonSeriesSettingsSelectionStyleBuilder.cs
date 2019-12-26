using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series when a user selects it.</summary>
	public class ChartCommonSeriesSettingsSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Border(Action<ChartCommonSeriesSettingsSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of the series in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series line when the series is in the selected state. Applies only to line-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures hatching that applies when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Hatching(Action<ChartCommonSeriesSettingsSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
