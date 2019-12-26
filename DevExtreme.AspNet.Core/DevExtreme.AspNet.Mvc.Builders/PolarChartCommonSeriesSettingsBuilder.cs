using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options that are common for all series of the PolarChart widget.</summary>
	public class PolarChartCommonSeriesSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object that specifies configuration options for all series of the area type in the chart.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Area(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("area", configurator);
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>An object that specifies configuration options for all series of the 'bar' type in the chart.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Bar(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("bar", configurator);
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder BarPadding(double value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder BarPadding(JS value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for all bars in a series, measured in degrees. Takes precedence over the barPadding option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for all bars in a series, measured in degrees. Takes precedence over the barPadding option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>An object defining the series border configuration options.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Border(Action<PolarChartCommonSeriesSettingsBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies whether or not to close the chart by joining the end point with the first point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Closed(bool value)
		{
			base.Options["closed"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to close the chart by joining the end point with the first point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Closed(JS value)
		{
			base.Options["closed"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series' line.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the series elements to highlight when a series is hovered over.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder HoverMode(ChartSeriesHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder HoverStyle(Action<PolarChartCommonSeriesSettingsHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder IgnoreEmptyPoints(bool value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder IgnoreEmptyPoints(JS value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>An object defining the label configuration options.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Label(Action<PolarChartCommonSeriesSettingsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>An object that specifies configuration options for all series of the 'line' type in the chart.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Line(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("line", configurator);
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies the minimal length of a displayed bar in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder MinBarSize(double value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimal length of a displayed bar in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder MinBarSize(JS value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies opacity for a series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies opacity for a series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for points in line and area series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Point(Action<PolarChartCommonSeriesSettingsPointBuilder> configurator)
		{
			NestedOptions("point", configurator);
			return this;
		}

		/// <summary>An object that specifies configuration options for all series of the 'scatter' type in the chart.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Scatter(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("scatter", configurator);
			return this;
		}

		/// <summary>Specifies the series elements to highlight when the series is selected.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder SelectionMode(ChartSeriesSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a selected series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder SelectionStyle(Action<PolarChartCommonSeriesSettingsSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether or not to show the series in the chart's legend.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ShowInLegend(bool value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the series in the chart's legend.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ShowInLegend(JS value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies the name of the stack where the values of the 'stackedBar' series must be located.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Stack(string value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies the name of the stack where the values of the 'stackedBar' series must be located.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Stack(JS value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>An object that specifies configuration options for all series of the 'stackedBar' type in the chart.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Stackedbar(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedbar", configurator);
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Sets a series type.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Type(PolarChartSeriesType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Configures error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ValueErrorBar(Action<PolarChartCommonSeriesSettingsValueErrorBarBuilder> configurator)
		{
			NestedOptions("valueErrorBar", configurator);
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of a series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of a series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a line width.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a line width.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
