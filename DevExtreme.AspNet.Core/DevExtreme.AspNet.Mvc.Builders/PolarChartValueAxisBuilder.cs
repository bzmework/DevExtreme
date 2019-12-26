using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies value axis options for the PolarChart widget.</summary>
	public class PolarChartValueAxisBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartValueAxisBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartValueAxisBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient for dividing the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder AxisDivisionFactor(double value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient for dividing the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder AxisDivisionFactor(JS value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the order in which discrete values are arranged on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Categories(IEnumerable<double> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which discrete values are arranged on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Categories(IEnumerable<string> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which discrete values are arranged on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Categories(IEnumerable<DateTime> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which discrete values are arranged on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Categories(JS value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Defines an array of the value axis constant lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ConstantLines(Action<CollectionFactory<PolarChartValueAxisConstantLineBuilder>> configurator)
		{
			Collection("constantLines", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of all the widget's constant lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ConstantLineStyle(Action<PolarChartValueAxisConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks/grid lines of a discrete axis are located between labels or cross the labels.</summary>
		[Generated]
		public PolarChartValueAxisBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for the grid lines of an axis in the PolarChart widget.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Grid(Action<PolarChartValueAxisGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Specifies options for value axis labels.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Label(Action<PolarChartValueAxisLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public PolarChartValueAxisBuilder LinearThreshold(double value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public PolarChartValueAxisBuilder LinearThreshold(JS value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the spacing between the maximum series point and the axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MaxValueMargin(double value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the spacing between the maximum series point and the axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MaxValueMargin(JS value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies the options of the minor grid.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorGrid(Action<PolarChartValueAxisMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Specifies the options of the minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTick(Action<PolarChartValueAxisMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies the number of minor ticks between two neighboring major ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickCount(int value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the number of minor ticks between two neighboring major ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickCount(JS value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickInterval(Action<PolarChartValueAxisMinorTickIntervalBuilder> configurator)
		{
			NestedOptions("minorTickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickInterval(VizTimeInterval value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the spacing between the minimum series point and the axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinValueMargin(double value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the spacing between the minimum series point and the axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinValueMargin(JS value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinVisualRangeLength(Action<PolarChartValueAxisMinVisualRangeLengthBuilder> configurator)
		{
			NestedOptions("minVisualRangeLength", configurator);
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinVisualRangeLength(VizTimeInterval value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinVisualRangeLength(double value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the minimum length of the visual range.</summary>
		[Generated]
		public PolarChartValueAxisBuilder MinVisualRangeLength(JS value)
		{
			base.Options["minVisualRangeLength"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate a zero value on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ShowZero(bool value)
		{
			base.Options["showZero"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate a zero value on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ShowZero(JS value)
		{
			base.Options["showZero"] = value;
			return this;
		}

		/// <summary>Specifies options for value axis strips.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Strips(Action<CollectionFactory<PolarChartValueAxisStripBuilder>> configurator)
		{
			Collection("strips", configurator);
			return this;
		}

		/// <summary>An object defining configuration options for strip style.</summary>
		[Generated]
		public PolarChartValueAxisBuilder StripStyle(Action<PolarChartValueAxisStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>An object defining the configuration options for axis ticks.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Tick(Action<PolarChartValueAxisTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder TickInterval(Action<PolarChartValueAxisTickIntervalBuilder> configurator)
		{
			NestedOptions("tickInterval", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder TickInterval(VizTimeInterval value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartValueAxisBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the required type of the value axis.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Type(AxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Indicates whether to display series with indents from axis boundaries.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ValueMarginsEnabled(bool value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether to display series with indents from axis boundaries.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ValueMarginsEnabled(JS value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the desired type of axis values.</summary>
		[Generated]
		public PolarChartValueAxisBuilder ValueType(ChartDataType value)
		{
			base.Options["valueType"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRange(IEnumerable<DateTime> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRange(IEnumerable<double> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRange(IEnumerable<string> value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRange(JS value)
		{
			base.Options["visualRange"] = value;
			return this;
		}

		/// <summary>Defines the axis' displayed range. Cannot be wider than the wholeRange.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("visualRange", configurator);
			return this;
		}

		/// <summary>Specifies how the axis's visual range should behave when the PolarChart data is updated.</summary>
		[Generated]
		public PolarChartValueAxisBuilder VisualRangeUpdateMode(ValueAxisVisualRangeUpdateMode value)
		{
			base.Options["visualRangeUpdateMode"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed.</summary>
		[Generated]
		public PolarChartValueAxisBuilder WholeRange(IEnumerable<DateTime> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed.</summary>
		[Generated]
		public PolarChartValueAxisBuilder WholeRange(IEnumerable<double> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed.</summary>
		[Generated]
		public PolarChartValueAxisBuilder WholeRange(IEnumerable<string> value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed.</summary>
		[Generated]
		public PolarChartValueAxisBuilder WholeRange(JS value)
		{
			base.Options["wholeRange"] = value;
			return this;
		}

		/// <summary>Defines the range where the axis can be zoomed.</summary>
		[Generated]
		public PolarChartValueAxisBuilder WholeRange(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("wholeRange", configurator);
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartValueAxisBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
