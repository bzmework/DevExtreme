using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for points in line and area series.</summary>
	public class PolarChartCommonSeriesSettingsPointBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies border options for points in the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Border(Action<PolarChartCommonSeriesSettingsPointBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the points color.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the points color.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies what series points to highlight when a point is hovered over.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder HoverMode(ChartPointInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder HoverStyle(Action<PolarChartCommonSeriesSettingsPointHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Image(Action<PolarChartCommonSeriesSettingsPointImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Specifies what series points to highlight when a point is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder SelectionMode(ChartPointInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a selected point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder SelectionStyle(Action<PolarChartCommonSeriesSettingsPointSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies the point diameter in pixels for those series that represent data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the point diameter in pixels for those series that represent data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies a symbol for presenting points of the line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Symbol(VizPointSymbol value)
		{
			base.Options["symbol"] = value;
			return this;
		}

		/// <summary>Specifies the points visibility for a line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the points visibility for a line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
