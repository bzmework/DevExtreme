namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the series border configuration options.</summary>
	public class PieChartCommonSeriesSettingsBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the border of a series point.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
