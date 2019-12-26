using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for Chart widget series.</summary>
	public class ChartSeriesBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartSeriesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures data aggregation for the series.</summary>
		[Generated]
		public ChartSeriesBuilder Aggregation(Action<ChartSeriesAggregationBuilder> configurator)
		{
			NestedOptions("aggregation", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for series points.</summary>
		[Generated]
		public ChartSeriesBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for series points.</summary>
		[Generated]
		public ChartSeriesBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Binds the series to a value axis.</summary>
		[Generated]
		public ChartSeriesBuilder Axis(string value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Binds the series to a value axis.</summary>
		[Generated]
		public ChartSeriesBuilder Axis(JS value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Allows you to group bar series so that bars with the same argument overlap.</summary>
		[Generated]
		public ChartSeriesBuilder BarOverlapGroup(string value)
		{
			base.Options["barOverlapGroup"] = value;
			return this;
		}

		/// <summary>Allows you to group bar series so that bars with the same argument overlap.</summary>
		[Generated]
		public ChartSeriesBuilder BarOverlapGroup(JS value)
		{
			base.Options["barOverlapGroup"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public ChartSeriesBuilder BarPadding(double value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public ChartSeriesBuilder BarPadding(JS value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for all bars in a series, measured in pixels. Takes precedence over the barPadding option.</summary>
		[Generated]
		public ChartSeriesBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for all bars in a series, measured in pixels. Takes precedence over the barPadding option.</summary>
		[Generated]
		public ChartSeriesBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Configures the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartSeriesBuilder Border(Action<ChartSeriesBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides close values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder CloseValueField(string value)
		{
			base.Options["closeValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides close values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder CloseValueField(JS value)
		{
			base.Options["closeValueField"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series.</summary>
		[Generated]
		public ChartSeriesBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series.</summary>
		[Generated]
		public ChartSeriesBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes bars look rounded. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes bars look rounded. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series line. Applies only to line-like series.</summary>
		[Generated]
		public ChartSeriesBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies which data source field provides high values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides high values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user points to a series.</summary>
		[Generated]
		public ChartSeriesBuilder HoverMode(ChartSeriesHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series when a user points to it.</summary>
		[Generated]
		public ChartSeriesBuilder HoverStyle(Action<ChartSeriesHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public ChartSeriesBuilder IgnoreEmptyPoints(bool value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public ChartSeriesBuilder IgnoreEmptyPoints(JS value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies a filling color for the body of a series point that visualizes a non-reduced value. Applies only to candlestick series.</summary>
		[Generated]
		public ChartSeriesBuilder InnerColor(string value)
		{
			base.Options["innerColor"] = value;
			return this;
		}

		/// <summary>Specifies a filling color for the body of a series point that visualizes a non-reduced value. Applies only to candlestick series.</summary>
		[Generated]
		public ChartSeriesBuilder InnerColor(JS value)
		{
			base.Options["innerColor"] = value;
			return this;
		}

		/// <summary>Configures point labels.</summary>
		[Generated]
		public ChartSeriesBuilder Label(Action<ChartSeriesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides low values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides low values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies a limit for the number of point labels.</summary>
		[Generated]
		public ChartSeriesBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies a limit for the number of point labels.</summary>
		[Generated]
		public ChartSeriesBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies the minimal possible height (or length if the chart is rotated) of a bar in pixels. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesBuilder MinBarSize(double value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimal possible height (or length if the chart is rotated) of a bar in pixels. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesBuilder MinBarSize(JS value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public ChartSeriesBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public ChartSeriesBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the series should be.</summary>
		[Generated]
		public ChartSeriesBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the series should be.</summary>
		[Generated]
		public ChartSeriesBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides open values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder OpenValueField(string value)
		{
			base.Options["openValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides open values for points of a financial series.</summary>
		[Generated]
		public ChartSeriesBuilder OpenValueField(JS value)
		{
			base.Options["openValueField"] = value;
			return this;
		}

		/// <summary>Specifies which pane the series should belong to. Accepts the name of the pane.</summary>
		[Generated]
		public ChartSeriesBuilder Pane(string value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Specifies which pane the series should belong to. Accepts the name of the pane.</summary>
		[Generated]
		public ChartSeriesBuilder Pane(JS value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Configures series points in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartSeriesBuilder Point(Action<ChartSeriesPointBuilder> configurator)
		{
			NestedOptions("point", configurator);
			return this;
		}

		/// <summary>Coupled with the rangeValue2Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartSeriesBuilder RangeValue1Field(string value)
		{
			base.Options["rangeValue1Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue2Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartSeriesBuilder RangeValue1Field(JS value)
		{
			base.Options["rangeValue1Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue1Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartSeriesBuilder RangeValue2Field(string value)
		{
			base.Options["rangeValue2Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue1Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartSeriesBuilder RangeValue2Field(JS value)
		{
			base.Options["rangeValue2Field"] = value;
			return this;
		}

		/// <summary>Specifies reduction options for financial series.</summary>
		[Generated]
		public ChartSeriesBuilder Reduction(Action<ChartSeriesReductionBuilder> configurator)
		{
			NestedOptions("reduction", configurator);
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user selects a series.</summary>
		[Generated]
		public ChartSeriesBuilder SelectionMode(ChartSeriesSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series when a user selects it.</summary>
		[Generated]
		public ChartSeriesBuilder SelectionStyle(Action<ChartSeriesSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether to show the series in the legend or not.</summary>
		[Generated]
		public ChartSeriesBuilder ShowInLegend(bool value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the series in the legend or not.</summary>
		[Generated]
		public ChartSeriesBuilder ShowInLegend(JS value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides size values for bubbles. Required by and applies only to bubble series.</summary>
		[Generated]
		public ChartSeriesBuilder SizeField(string value)
		{
			base.Options["sizeField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides size values for bubbles. Required by and applies only to bubble series.</summary>
		[Generated]
		public ChartSeriesBuilder SizeField(JS value)
		{
			base.Options["sizeField"] = value;
			return this;
		}

		/// <summary>Specifies which stack the series should belongs to. Applies only to stacked bar and full-stacked bar series.</summary>
		[Generated]
		public ChartSeriesBuilder Stack(string value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies which stack the series should belongs to. Applies only to stacked bar and full-stacked bar series.</summary>
		[Generated]
		public ChartSeriesBuilder Stack(JS value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies data about a series.</summary>
		[Generated]
		public ChartSeriesBuilder Tag(object value)
		{
			base.Options["tag"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides auxiliary data for series points.</summary>
		[Generated]
		public ChartSeriesBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides auxiliary data for series points.</summary>
		[Generated]
		public ChartSeriesBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Sets the series type.</summary>
		[Generated]
		public ChartSeriesBuilder Type(SeriesType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Configures error bars.</summary>
		[Generated]
		public ChartSeriesBuilder ValueErrorBar(Action<ChartSeriesValueErrorBarBuilder> configurator)
		{
			NestedOptions("valueErrorBar", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides values for series points.</summary>
		[Generated]
		public ChartSeriesBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides values for series points.</summary>
		[Generated]
		public ChartSeriesBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies whether the series is visible or not.</summary>
		[Generated]
		public ChartSeriesBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the series is visible or not.</summary>
		[Generated]
		public ChartSeriesBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the series line in pixels. Applies only to line-like series.</summary>
		[Generated]
		public ChartSeriesBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the series line in pixels. Applies only to line-like series.</summary>
		[Generated]
		public ChartSeriesBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
