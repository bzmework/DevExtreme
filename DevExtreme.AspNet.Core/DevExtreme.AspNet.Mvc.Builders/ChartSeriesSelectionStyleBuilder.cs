using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by the series when a user selects it.</summary>
	public class ChartSeriesSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series border (in area-like series) or the series point border (in bar-like and bubble series) when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Border(Action<ChartSeriesSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of the series in the selected state.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series in the selected state.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series line when the series is in the selected state. Applies only to line-like series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures hatching that applies when a user selects the series.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Hatching(Action<ChartSeriesSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the selected state.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured width of the series line when the series is in the selected state.</summary>
		[Generated]
		public ChartSeriesSelectionStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
