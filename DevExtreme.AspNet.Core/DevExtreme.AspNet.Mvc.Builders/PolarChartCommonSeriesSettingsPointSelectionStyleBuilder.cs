using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a selected point.</summary>
	public class PolarChartCommonSeriesSettingsPointSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Border(Action<PolarChartCommonSeriesSettingsPointSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a point when it is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a point when it is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a selected point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a selected point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointSelectionStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
