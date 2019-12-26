using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for PolarChart widget series.</summary>
	public class PolarChartSeriesBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PolarChartSeriesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PolarChartSeriesBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PolarChartSeriesBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public PolarChartSeriesBuilder BarPadding(double value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public PolarChartSeriesBuilder BarPadding(JS value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for all bars in a series, measured in degrees. Takes precedence over the barPadding option.</summary>
		[Generated]
		public PolarChartSeriesBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for all bars in a series, measured in degrees. Takes precedence over the barPadding option.</summary>
		[Generated]
		public PolarChartSeriesBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>An object defining the series border configuration options.</summary>
		[Generated]
		public PolarChartSeriesBuilder Border(Action<PolarChartSeriesBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies whether or not to close the chart by joining the end point with the first point.</summary>
		[Generated]
		public PolarChartSeriesBuilder Closed(bool value)
		{
			base.Options["closed"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to close the chart by joining the end point with the first point.</summary>
		[Generated]
		public PolarChartSeriesBuilder Closed(JS value)
		{
			base.Options["closed"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PolarChartSeriesBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PolarChartSeriesBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series' line.</summary>
		[Generated]
		public PolarChartSeriesBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the series elements to highlight when a series is hovered over.</summary>
		[Generated]
		public PolarChartSeriesBuilder HoverMode(ChartSeriesHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered series.</summary>
		[Generated]
		public PolarChartSeriesBuilder HoverStyle(Action<PolarChartSeriesHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public PolarChartSeriesBuilder IgnoreEmptyPoints(bool value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public PolarChartSeriesBuilder IgnoreEmptyPoints(JS value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>An object defining the label configuration options.</summary>
		[Generated]
		public PolarChartSeriesBuilder Label(Action<PolarChartSeriesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PolarChartSeriesBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PolarChartSeriesBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies the minimal length of a displayed bar in pixels.</summary>
		[Generated]
		public PolarChartSeriesBuilder MinBarSize(double value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimal length of a displayed bar in pixels.</summary>
		[Generated]
		public PolarChartSeriesBuilder MinBarSize(JS value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies opacity for a series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies opacity for a series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for points in line and area series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Point(Action<PolarChartSeriesPointBuilder> configurator)
		{
			NestedOptions("point", configurator);
			return this;
		}

		/// <summary>Specifies the series elements to highlight when the series is selected.</summary>
		[Generated]
		public PolarChartSeriesBuilder SelectionMode(ChartSeriesSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a selected series.</summary>
		[Generated]
		public PolarChartSeriesBuilder SelectionStyle(Action<PolarChartSeriesSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether or not to show the series in the chart's legend.</summary>
		[Generated]
		public PolarChartSeriesBuilder ShowInLegend(bool value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the series in the chart's legend.</summary>
		[Generated]
		public PolarChartSeriesBuilder ShowInLegend(JS value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies the name of the stack where the values of the 'stackedBar' series must be located.</summary>
		[Generated]
		public PolarChartSeriesBuilder Stack(string value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies the name of the stack where the values of the 'stackedBar' series must be located.</summary>
		[Generated]
		public PolarChartSeriesBuilder Stack(JS value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies data about a series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Tag(object value)
		{
			base.Options["tag"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PolarChartSeriesBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PolarChartSeriesBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Sets the series type.</summary>
		[Generated]
		public PolarChartSeriesBuilder Type(PolarChartSeriesType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Configures error bars.</summary>
		[Generated]
		public PolarChartSeriesBuilder ValueErrorBar(Action<PolarChartSeriesValueErrorBarBuilder> configurator)
		{
			NestedOptions("valueErrorBar", configurator);
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PolarChartSeriesBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PolarChartSeriesBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of a series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of a series.</summary>
		[Generated]
		public PolarChartSeriesBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a line width.</summary>
		[Generated]
		public PolarChartSeriesBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a line width.</summary>
		[Generated]
		public PolarChartSeriesBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
