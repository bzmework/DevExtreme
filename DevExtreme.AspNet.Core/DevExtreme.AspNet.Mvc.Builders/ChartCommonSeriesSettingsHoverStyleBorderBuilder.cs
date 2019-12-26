namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
	public class ChartCommonSeriesSettingsHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a dash style for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user points to the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
