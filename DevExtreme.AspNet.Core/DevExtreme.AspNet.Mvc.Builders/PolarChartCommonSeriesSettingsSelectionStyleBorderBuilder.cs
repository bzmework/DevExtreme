namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a selected series.</summary>
	public class PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
