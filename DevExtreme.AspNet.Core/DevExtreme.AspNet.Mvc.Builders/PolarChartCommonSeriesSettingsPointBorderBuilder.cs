namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies border options for points in the line and area series.</summary>
	public class PolarChartCommonSeriesSettingsPointBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for points in the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for points in the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets border visibility for points in the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for points in the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for points in the line or area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for points in the line or area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
