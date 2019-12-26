namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
	public class ChartCommonSeriesSettingsSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a dash style for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
