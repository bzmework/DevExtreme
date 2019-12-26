using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the value axis.</summary>
	public class ChartValueAxisBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartValueAxisBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartValueAxisBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartValueAxisBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Enables auto-calculated scale breaks. Applies only if the axis' type is "continuous" or "logarithmic" and valueType is "numeric".</summary>
		[Generated]
		public ChartValueAxisBuilder AutoBreaksEnabled(bool value)
		{
			base.Options["autoBreaksEnabled"] = value;
			return this;
		}

		/// <summary>Enables auto-calculated scale breaks. Applies only if the axis' type is "continuous" or "logarithmic" and valueType is "numeric".</summary>
		[Generated]
		public ChartValueAxisBuilder AutoBreaksEnabled(JS value)
		{
			base.Options["autoBreaksEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public ChartValueAxisBuilder AxisDivisionFactor(double value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public ChartValueAxisBuilder AxisDivisionFactor(JS value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Declares a custom scale break collection. Applies only if the axis' type is "continuous" or "logarithmic".</summary>
		[Generated]
		public ChartValueAxisBuilder Breaks(Action<CollectionFactory<VizScaleBreakBuilder>> configurator)
		{
			Collection("breaks", configurator);
			return this;
		}

		/// <summary>Configures the scale breaks' appearance.</summary>
		[Generated]
		public ChartValueAxisBuilder BreakStyle(Action<ChartValueAxisBreakStyleBuilder> configurator)
		{
			NestedOptions("breakStyle", configurator);
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartValueAxisBuilder Categories(IEnumerable<double> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartValueAxisBuilder Categories(IEnumerable<string> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartValueAxisBuilder Categories(IEnumerable<DateTime> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartValueAxisBuilder Categories(JS value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartValueAxisBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartValueAxisBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Declares a collection of constant lines belonging to the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder ConstantLines(Action<CollectionFactory<ChartValueAxisConstantLineBuilder>> configurator)
		{
			Collection("constantLines", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of those constant lines that belong to the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder ConstantLineStyle(Action<ChartValueAxisConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks and grid lines should cross axis labels or lie between them. Applies only to the axes of the "discrete" type.</summary>
		[Generated]
		public ChartValueAxisBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Configures the grid.</summary>
		[Generated]
		public ChartValueAxisBuilder Grid(Action<ChartValueAxisGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Configures the labels of the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Label(Action<ChartValueAxisLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public ChartValueAxisBuilder LinearThreshold(double value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public ChartValueAxisBuilder LinearThreshold(JS value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for an axis of the "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for an axis of the "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Max(string value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Sets a limit on auto-calculated scale breaks. Custom scale breaks are not counted.</summary>
		[Generated]
		public ChartValueAxisBuilder MaxAutoBreakCount(int value)
		{
			base.Options["maxAutoBreakCount"] = value;
			return this;
		}

		/// <summary>Sets a limit on auto-calculated scale breaks. Custom scale breaks are not counted.</summary>
		[Generated]
		public ChartValueAxisBuilder MaxAutoBreakCount(JS value)
		{
			base.Options["maxAutoBreakCount"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder MaxValueMargin(double value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder MaxValueMargin(JS value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Min(string value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the valueAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartValueAxisBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Configures the minor grid.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorGrid(Action<ChartValueAxisMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Configures the appearance of minor axis ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTick(Action<ChartValueAxisMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies how many minor ticks to place between two neighboring major ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickCount(int value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies how many minor ticks to place between two neighboring major ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickCount(JS value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to continuous axes.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickInterval(Action<ChartValueAxisMinorTickIntervalBuilder> configurator)
		{
			NestedOptions("minorTickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to continuous axes.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickInterval(VizTimeInterval value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to continuous axes.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to continuous axes.</summary>
		[Generated]
		public ChartValueAxisBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder MinValueMargin(double value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartValueAxisBuilder MinValueMargin(JS value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartValueAxisBuilder MinVisualRangeLength(Action<ChartValueAxisMinVisualRangeLengthBuilder> configurator)
		{
			NestedOptions("minVisualRangeLength", configurator);
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartValueAxisBuilder MinVisualRangeLength(VizTimeInterval value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartValueAxisBuilder MinVisualRangeLength(double value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartValueAxisBuilder MinVisualRangeLength(JS value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two side-by-side value axes. Applies if several value axes are located on one side of the chart.</summary>
		[Generated]
		public ChartValueAxisBuilder MultipleAxesSpacing(double value)
		{
			base.Options["multipleAxesSpacing"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two side-by-side value axes. Applies if several value axes are located on one side of the chart.</summary>
		[Generated]
		public ChartValueAxisBuilder MultipleAxesSpacing(JS value)
		{
			base.Options["multipleAxesSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartValueAxisBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartValueAxisBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Binds the value axis to a pane.</summary>
		[Generated]
		public ChartValueAxisBuilder Pane(string value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Binds the value axis to a pane.</summary>
		[Generated]
		public ChartValueAxisBuilder Pane(JS value)
		{
			base.Options["pane"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartValueAxisBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartValueAxisBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Relocates the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Position(Position value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show zero on the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder ShowZero(bool value)
		{
			base.Options["showZero"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show zero on the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder ShowZero(JS value)
		{
			base.Options["showZero"] = value;
			return this;
		}

		/// <summary>Declares a collection of strips belonging to the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Strips(Action<CollectionFactory<ChartValueAxisStripBuilder>> configurator)
		{
			Collection("strips", configurator);
			return this;
		}

		/// <summary>Configures the appearance of strips.</summary>
		[Generated]
		public ChartValueAxisBuilder StripStyle(Action<ChartValueAxisStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>Synchronizes two or more value axes with each other at a specific value.</summary>
		[Generated]
		public ChartValueAxisBuilder SynchronizedValue(double value)
		{
			base.Options["synchronizedValue"] = value;
			return this;
		}

		/// <summary>Synchronizes two or more value axes with each other at a specific value.</summary>
		[Generated]
		public ChartValueAxisBuilder SynchronizedValue(JS value)
		{
			base.Options["synchronizedValue"] = value;
			return this;
		}

		/// <summary>Configures the appearance of major axis ticks.</summary>
		[Generated]
		public ChartValueAxisBuilder Tick(Action<ChartValueAxisTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies the interval between major ticks. Does not apply to discrete axes.</summary>
		[Generated]
		public ChartValueAxisBuilder TickInterval(Action<ChartValueAxisTickIntervalBuilder> configurator)
		{
			NestedOptions("tickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between major ticks. Does not apply to discrete axes.</summary>
		[Generated]
		public ChartValueAxisBuilder TickInterval(VizTimeInterval value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between major ticks. Does not apply to discrete axes.</summary>
		[Generated]
		public ChartValueAxisBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between major ticks. Does not apply to discrete axes.</summary>
		[Generated]
		public ChartValueAxisBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartValueAxisBuilder Title(Action<ChartValueAxisTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartValueAxisBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartValueAxisBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the type of the value axis.</summary>
		[Generated]
		public ChartValueAxisBuilder Type(AxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartValueAxisBuilder ValueMarginsEnabled(bool value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartValueAxisBuilder ValueMarginsEnabled(JS value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Casts values to a specified data type.</summary>
		[Generated]
		public ChartValueAxisBuilder ValueType(ChartDataType value)
		{
			base.Options["valueType"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartValueAxisBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartValueAxisBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRange(IEnumerable<DateTime> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRange(IEnumerable<double> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRange(IEnumerable<string> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRange(JS value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("visualRange", configurator);
			return this;
		}

		/// <summary>Specifies how the axis's visual range should behave when chart data is updated.</summary>
		[Generated]
		public ChartValueAxisBuilder VisualRangeUpdateMode(VisualRangeUpdateMode value)
		{
			base.Options["visualRangeUpdateMode"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartValueAxisBuilder WholeRange(IEnumerable<DateTime> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartValueAxisBuilder WholeRange(IEnumerable<double> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartValueAxisBuilder WholeRange(IEnumerable<string> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartValueAxisBuilder WholeRange(JS value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartValueAxisBuilder WholeRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("wholeRange", configurator);
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartValueAxisBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartValueAxisBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
