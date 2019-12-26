namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a hovered series.</summary>
	public class PolarChartCommonSeriesSettingsHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets a border visibility for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border visibility for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
