using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the argument axis.</summary>
	public class ChartArgumentAxisBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aggregates series points that fall into the same category.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregateByCategory(bool value)
		{
			base.Options["aggregateByCategory"] = value;
			return this;
		}

		/// <summary>Aggregates series points that fall into the same category.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregateByCategory(JS value)
		{
			base.Options["aggregateByCategory"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in pixels. Does not apply if aggregateByCategory is true. May be ignored in favor of the aggregationInterval option.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationGroupWidth(double value)
		{
			base.Options["aggregationGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in pixels. Does not apply if aggregateByCategory is true. May be ignored in favor of the aggregationInterval option.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationGroupWidth(JS value)
		{
			base.Options["aggregationGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in axis units. Applies only to axes of continuous and logarithmic types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationInterval(Action<ChartArgumentAxisAggregationIntervalBuilder> configurator)
		{
			NestedOptions("aggregationInterval", configurator);
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in axis units. Applies only to axes of continuous and logarithmic types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationInterval(VizTimeInterval value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in axis units. Applies only to axes of continuous and logarithmic types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationInterval(double value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in axis units. Applies only to axes of continuous and logarithmic types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AggregationInterval(JS value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Casts arguments to a specified data type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder ArgumentType(ChartDataType value)
		{
			base.Options["argumentType"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AxisDivisionFactor(double value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public ChartArgumentAxisBuilder AxisDivisionFactor(JS value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Declares a scale break collection. Applies only if the axis' type is "continuous" or "logarithmic".</summary>
		[Generated]
		public ChartArgumentAxisBuilder Breaks(Action<CollectionFactory<VizScaleBreakBuilder>> configurator)
		{
			Collection("breaks", configurator);
			return this;
		}

		/// <summary>Configures the scale breaks' appearance.</summary>
		[Generated]
		public ChartArgumentAxisBuilder BreakStyle(Action<ChartArgumentAxisBreakStyleBuilder> configurator)
		{
			NestedOptions("breakStyle", configurator);
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Categories(IEnumerable<double> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Categories(IEnumerable<string> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Categories(IEnumerable<DateTime> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of categories on an axis of the "discrete" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Categories(JS value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Declares a collection of constant lines belonging to the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder ConstantLines(Action<CollectionFactory<ChartArgumentAxisConstantLineBuilder>> configurator)
		{
			Collection("constantLines", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of those constant lines that belong to the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder ConstantLineStyle(Action<ChartArgumentAxisConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks and grid lines should cross axis labels or lie between them. Applies only to the axes of the "discrete" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Configures the grid.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Grid(Action<ChartArgumentAxisGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Dates to be excluded from the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Holidays(IEnumerable<double> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Dates to be excluded from the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Holidays(IEnumerable<string> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Dates to be excluded from the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Holidays(IEnumerable<DateTime> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Dates to be excluded from the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Holidays(JS value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Specifies chart elements to be highlighted when a user points to an axis label.</summary>
		[Generated]
		public ChartArgumentAxisBuilder HoverMode(ArgumentAxisHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Configures the labels of the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Label(Action<ChartArgumentAxisLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public ChartArgumentAxisBuilder LinearThreshold(double value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public ChartArgumentAxisBuilder LinearThreshold(JS value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for an axis of the "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for an axis of the "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Max(string value)
		{
			base.Options["max"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MaxValueMargin(double value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MaxValueMargin(JS value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Min(string value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the argumentAxis.visualRange option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartArgumentAxisBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Configures the minor grid.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorGrid(Action<ChartArgumentAxisMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Configures the appearance of minor axis ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTick(Action<ChartArgumentAxisMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies how many minor ticks to place between two neighboring major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickCount(int value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies how many minor ticks to place between two neighboring major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickCount(JS value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to the axes of the "continuous" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickInterval(Action<ChartArgumentAxisMinorTickIntervalBuilder> configurator)
		{
			NestedOptions("minorTickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to the axes of the "continuous" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickInterval(VizTimeInterval value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to the axes of the "continuous" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks. Applies only to the axes of the "continuous" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinValueMargin(double value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinValueMargin(JS value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinVisualRangeLength(Action<ChartArgumentAxisMinVisualRangeLengthBuilder> configurator)
		{
			NestedOptions("minVisualRangeLength", configurator);
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinVisualRangeLength(VizTimeInterval value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinVisualRangeLength(double value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public ChartArgumentAxisBuilder MinVisualRangeLength(JS value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Relocates the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Position(Position value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Dates to be included on the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder SingleWorkdays(IEnumerable<double> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Dates to be included on the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder SingleWorkdays(IEnumerable<string> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Dates to be included on the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder SingleWorkdays(IEnumerable<DateTime> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Dates to be included on the axis when workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder SingleWorkdays(JS value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Declares a collection of strips belonging to the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Strips(Action<CollectionFactory<ChartArgumentAxisStripBuilder>> configurator)
		{
			Collection("strips", configurator);
			return this;
		}

		/// <summary>Configures the appearance of strips.</summary>
		[Generated]
		public ChartArgumentAxisBuilder StripStyle(Action<ChartArgumentAxisStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>Configures the appearance of major axis ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Tick(Action<ChartArgumentAxisTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies the interval between major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder TickInterval(Action<ChartArgumentAxisTickIntervalBuilder> configurator)
		{
			NestedOptions("tickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder TickInterval(VizTimeInterval value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between major ticks.</summary>
		[Generated]
		public ChartArgumentAxisBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Title(Action<ChartArgumentAxisTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the axis title.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the type of the argument axis.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Type(AxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartArgumentAxisBuilder ValueMarginsEnabled(bool value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartArgumentAxisBuilder ValueMarginsEnabled(JS value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRange(IEnumerable<DateTime> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRange(IEnumerable<double> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRange(IEnumerable<string> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRange(JS value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("visualRange", configurator);
			return this;
		}

		/// <summary>Specifies how the axis's visual range should behave when chart data is updated.</summary>
		[Generated]
		public ChartArgumentAxisBuilder VisualRangeUpdateMode(VisualRangeUpdateMode value)
		{
			base.Options["visualRangeUpdateMode"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WholeRange(IEnumerable<DateTime> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WholeRange(IEnumerable<double> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WholeRange(IEnumerable<string> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WholeRange(JS value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed and panned.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WholeRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("wholeRange", configurator);
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartArgumentAxisBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Leaves only workdays on the axis: the work week days plus single workdays minus holidays. Applies only if the axis' argumentType is "datetime".</summary>
		[Generated]
		public ChartArgumentAxisBuilder WorkdaysOnly(bool value)
		{
			base.Options["workdaysOnly"] = value;
			return this;
		}

		/// <summary>Leaves only workdays on the axis: the work week days plus single workdays minus holidays. Applies only if the axis' argumentType is "datetime".</summary>
		[Generated]
		public ChartArgumentAxisBuilder WorkdaysOnly(JS value)
		{
			base.Options["workdaysOnly"] = value;
			return this;
		}

		/// <summary>Specifies which days are workdays. The array can contain values from 0 (Sunday) to 6 (Saturday). Applies only if workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WorkWeek(IEnumerable<int> value)
		{
			base.Options["workWeek"] = value;
			return this;
		}

		/// <summary>Specifies which days are workdays. The array can contain values from 0 (Sunday) to 6 (Saturday). Applies only if workdaysOnly is true.</summary>
		[Generated]
		public ChartArgumentAxisBuilder WorkWeek(JS value)
		{
			base.Options["workWeek"] = value;
			return this;
		}
	}
}
