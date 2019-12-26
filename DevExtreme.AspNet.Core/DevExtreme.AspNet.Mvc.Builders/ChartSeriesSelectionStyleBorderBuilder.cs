namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
	public class ChartSeriesSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a dash style for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
