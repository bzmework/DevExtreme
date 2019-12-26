namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies border options for point labels.</summary>
	public class PolarChartCommonSeriesSettingsLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Indicates whether borders are visible in point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether borders are visible in point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
