namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
	public class ChartSeriesBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a dash style for the series border (in area-like series) or for the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a pixel-measured width for the series border (in area-like series) or for the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
