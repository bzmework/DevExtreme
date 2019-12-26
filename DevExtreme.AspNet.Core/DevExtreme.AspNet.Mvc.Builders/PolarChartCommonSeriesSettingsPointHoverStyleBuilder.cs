using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a hovered point.</summary>
	public class PolarChartCommonSeriesSettingsPointHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Border(Action<PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a point when it is hovered over.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a point when it is hovered over.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a hovered point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a hovered point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
