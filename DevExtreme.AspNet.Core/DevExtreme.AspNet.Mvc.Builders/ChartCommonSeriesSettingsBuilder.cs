using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies settings common for all series in the chart.</summary>
	public class ChartCommonSeriesSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures data aggregation for the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Aggregation(Action<ChartCommonSeriesSettingsAggregationBuilder> configurator)
		{
			NestedOptions("aggregation", configurator);
			return this;
		}

		/// <summary>Defines common settings for all area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Area(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("area", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Binds the series to a value axis.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Axis(string value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Binds the series to a value axis.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Axis(JS value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Defines common settings for all bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Bar(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("bar", configurator);
			return this;
		}

		/// <summary>Allows you to group bar series so that bars with the same argument overlap.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarOverlapGroup(string value)
		{
			base.Options["barOverlapGroup"] = value;
			return this;
		}

		/// <summary>Allows you to group bar series so that bars with the same argument overlap.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarOverlapGroup(JS value)
		{
			base.Options["barOverlapGroup"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarPadding(double value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of all bars in a series using relative units. Ignored if the barWidth option is set.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarPadding(JS value)
		{
			base.Options["barPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for all bars in a series, measured in pixels. Takes precedence over the barPadding option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for all bars in a series, measured in pixels. Takes precedence over the barPadding option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Configures the series border (in area-like series) or the series point border (in bar-like and bubble series).</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Border(Action<ChartCommonSeriesSettingsBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Defines common settings for all bubble series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Bubble(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("bubble", configurator);
			return this;
		}

		/// <summary>Defines common settings for all candlestick series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Candlestick(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("candlestick", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides close values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder CloseValueField(string value)
		{
			base.Options["closeValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides close values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder CloseValueField(JS value)
		{
			base.Options["closeValueField"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes bars look rounded. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes bars look rounded. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the series line. Applies only to line-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Defines common settings for all full-stacked area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Fullstackedarea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("fullstackedarea", configurator);
			return this;
		}

		/// <summary>Defines common settings for all full-stacked bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Fullstackedbar(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("fullstackedbar", configurator);
			return this;
		}

		/// <summary>Defines common settings for all full-stacked line series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Fullstackedline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("fullstackedline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all full-stacked spline series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Fullstackedspline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("fullstackedspline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all full-stacked spline area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Fullstackedsplinearea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("fullstackedsplinearea", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides high values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides high values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user points to a series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder HoverMode(ChartSeriesHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series when a user points to it.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder HoverStyle(Action<ChartCommonSeriesSettingsHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder IgnoreEmptyPoints(bool value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies whether the series should ignore null data points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder IgnoreEmptyPoints(JS value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies a filling color for the body of a series point that visualizes a non-reduced value. Applies only to candlestick series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder InnerColor(string value)
		{
			base.Options["innerColor"] = value;
			return this;
		}

		/// <summary>Specifies a filling color for the body of a series point that visualizes a non-reduced value. Applies only to candlestick series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder InnerColor(JS value)
		{
			base.Options["innerColor"] = value;
			return this;
		}

		/// <summary>Configures point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Label(Action<ChartCommonSeriesSettingsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Defines common settings for all line series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Line(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("line", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides low values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides low values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies a limit for the number of point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies a limit for the number of point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies the minimal possible height (or length if the chart is rotated) of a bar in pixels. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder MinBarSize(double value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies the minimal possible height (or length if the chart is rotated) of a bar in pixels. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder MinBarSize(JS value)
		{
			base.Options["minBarSize"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the series should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the series should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides open values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder OpenValueField(string value)
		{
			base.Options["openValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides open values for points of a financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder OpenValueField(JS value)
		{
			base.Options["openValueField"] = value;
			return this;
		}

		/// <summary>Specifies which pane the series should belong to. Accepts the name of the pane.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Pane(string value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Specifies which pane the series should belong to. Accepts the name of the pane.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Pane(JS value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Configures series points in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Point(Action<ChartCommonSeriesSettingsPointBuilder> configurator)
		{
			NestedOptions("point", configurator);
			return this;
		}

		/// <summary>Defines common settings for all range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Rangearea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("rangearea", configurator);
			return this;
		}

		/// <summary>Defines common settings for all range bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Rangebar(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("rangebar", configurator);
			return this;
		}

		/// <summary>Coupled with the rangeValue2Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder RangeValue1Field(string value)
		{
			base.Options["rangeValue1Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue2Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder RangeValue1Field(JS value)
		{
			base.Options["rangeValue1Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue1Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder RangeValue2Field(string value)
		{
			base.Options["rangeValue2Field"] = value;
			return this;
		}

		/// <summary>Coupled with the rangeValue1Field option, specifies which data source field provides values for a range-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder RangeValue2Field(JS value)
		{
			base.Options["rangeValue2Field"] = value;
			return this;
		}

		/// <summary>Specifies reduction options for financial series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Reduction(Action<ChartCommonSeriesSettingsReductionBuilder> configurator)
		{
			NestedOptions("reduction", configurator);
			return this;
		}

		/// <summary>Defines common settings for all scatter series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Scatter(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("scatter", configurator);
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user selects a series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder SelectionMode(ChartSeriesSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by the series when a user selects it.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder SelectionStyle(Action<ChartCommonSeriesSettingsSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether to show the series in the legend or not.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ShowInLegend(bool value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the series in the legend or not.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ShowInLegend(JS value)
		{
			base.Options["showInLegend"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides size values for bubbles. Required by and applies only to bubble series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder SizeField(string value)
		{
			base.Options["sizeField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides size values for bubbles. Required by and applies only to bubble series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder SizeField(JS value)
		{
			base.Options["sizeField"] = value;
			return this;
		}

		/// <summary>Defines common settings for all spline series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Spline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("spline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all spline area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Splinearea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("splinearea", configurator);
			return this;
		}

		/// <summary>Specifies which stack the series should belongs to. Applies only to stacked bar and full-stacked bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stack(string value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Specifies which stack the series should belongs to. Applies only to stacked bar and full-stacked bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stack(JS value)
		{
			base.Options["stack"] = value;
			return this;
		}

		/// <summary>Defines common settings for all stacked area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stackedarea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedarea", configurator);
			return this;
		}

		/// <summary>Defines common settings for all stacked bar series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stackedbar(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedbar", configurator);
			return this;
		}

		/// <summary>Defines common settings for all stacked line series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stackedline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all stacked spline series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stackedspline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedspline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all stacked spline area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stackedsplinearea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stackedsplinearea", configurator);
			return this;
		}

		/// <summary>Defines common settings for all step area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Steparea(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("steparea", configurator);
			return this;
		}

		/// <summary>Defines common settings for all step line series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stepline(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stepline", configurator);
			return this;
		}

		/// <summary>Defines common settings for all stock series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Stock(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("stock", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides auxiliary data for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides auxiliary data for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the type of the series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Type(SeriesType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Configures error bars.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ValueErrorBar(Action<ChartCommonSeriesSettingsValueErrorBarBuilder> configurator)
		{
			NestedOptions("valueErrorBar", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides values for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides values for series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies whether the series is visible or not.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the series is visible or not.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the series line in pixels. Applies only to line-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the series line in pixels. Applies only to line-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
