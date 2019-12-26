using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies argument axis options for the PolarChart widget.</summary>
	public class PolarChartArgumentAxisBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies the desired type of axis values.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder ArgumentType(ChartDataType value)
		{
			base.Options["argumentType"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder AxisDivisionFactor(double value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels. Applies only to the axes of the "continuous" and "logarithmic" types.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder AxisDivisionFactor(JS value)
		{
			base.Options["axisDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the order in which arguments (categories) are arranged on the discrete argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Categories(IEnumerable<double> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which arguments (categories) are arranged on the discrete argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Categories(IEnumerable<string> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which arguments (categories) are arranged on the discrete argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Categories(IEnumerable<DateTime> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order in which arguments (categories) are arranged on the discrete argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Categories(JS value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Defines an array of the argument axis constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder ConstantLines(Action<CollectionFactory<PolarChartArgumentAxisConstantLineBuilder>> configurator)
		{
			Collection("constantLines", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of all the widget's constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder ConstantLineStyle(Action<PolarChartArgumentAxisConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks/grid lines of a discrete axis are located between labels or cross the labels.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the first point at the angle specified by the startAngle option.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder FirstPointOnStartAngle(bool value)
		{
			base.Options["firstPointOnStartAngle"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the first point at the angle specified by the startAngle option.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder FirstPointOnStartAngle(JS value)
		{
			base.Options["firstPointOnStartAngle"] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for the grid lines of an axis in the PolarChart widget.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Grid(Action<PolarChartArgumentAxisGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Specifies the elements that will be highlighted when the argument axis is hovered over.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder HoverMode(ArgumentAxisHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Specifies options for argument axis labels.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Label(Action<PolarChartArgumentAxisLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder LinearThreshold(double value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic axis within which the axis should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder LinearThreshold(JS value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the options of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorGrid(Action<PolarChartArgumentAxisMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Specifies the options of the minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTick(Action<PolarChartArgumentAxisMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies the number of minor ticks between two neighboring major ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickCount(int value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the number of minor ticks between two neighboring major ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickCount(JS value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickInterval(Action<PolarChartArgumentAxisMinorTickIntervalBuilder> configurator)
		{
			NestedOptions("minorTickInterval", configurator);
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickInterval(VizTimeInterval value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used as the origin for the argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder OriginValue(double value)
		{
			base.Options["originValue"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used as the origin for the argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder OriginValue(JS value)
		{
			base.Options["originValue"] = value;
			return this;
		}

		/// <summary>Specifies the period of the argument values in the data source.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Period(double value)
		{
			base.Options["period"] = value;
			return this;
		}

		/// <summary>Specifies the period of the argument values in the data source.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Period(JS value)
		{
			base.Options["period"] = value;
			return this;
		}

		/// <summary>Specifies the angle in arc degrees to which the argument axis should be rotated. The positive values rotate the axis clockwise.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder StartAngle(double value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Specifies the angle in arc degrees to which the argument axis should be rotated. The positive values rotate the axis clockwise.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder StartAngle(JS value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Specifies options for argument axis strips.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Strips(Action<CollectionFactory<PolarChartArgumentAxisStripBuilder>> configurator)
		{
			Collection("strips", configurator);
			return this;
		}

		/// <summary>An object defining configuration options for strip style.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder StripStyle(Action<PolarChartArgumentAxisStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>An object defining the configuration options for axis ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Tick(Action<PolarChartArgumentAxisTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder TickInterval(Action<PolarChartArgumentAxisTickIntervalBuilder> configurator)
		{
			NestedOptions("tickInterval", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder TickInterval(VizTimeInterval value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks/grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the required type of the argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Type(AxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartArgumentAxisBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
