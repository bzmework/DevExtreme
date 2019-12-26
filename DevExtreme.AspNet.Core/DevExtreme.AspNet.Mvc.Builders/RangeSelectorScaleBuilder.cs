using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the range selector's scale.</summary>
	public class RangeSelectorScaleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aggregates series points that fall into the same category.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregateByCategory(bool value)
		{
			base.Options["aggregateByCategory"] = value;
			return this;
		}

		/// <summary>Aggregates series points that fall into the same category.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregateByCategory(JS value)
		{
			base.Options["aggregateByCategory"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in pixels. Does not apply if aggregateByCategory is true. May be ignored in favor of the aggregationInterval option.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationGroupWidth(double value)
		{
			base.Options["aggregationGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in pixels. Does not apply if aggregateByCategory is true. May be ignored in favor of the aggregationInterval option.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationGroupWidth(JS value)
		{
			base.Options["aggregationGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in scale units. Applies only to the scale of the continuous or logarithmic type.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationInterval(Action<RangeSelectorScaleAggregationIntervalBuilder> configurator)
		{
			NestedOptions("aggregationInterval", configurator);
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in scale units. Applies only to the scale of the continuous or logarithmic type.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationInterval(VizTimeInterval value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in scale units. Applies only to the scale of the continuous or logarithmic type.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationInterval(double value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies the length of aggregation intervals in scale units. Applies only to the scale of the continuous or logarithmic type.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AggregationInterval(JS value)
		{
			base.Options["aggregationInterval"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public RangeSelectorScaleBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Declares a scale break collection. Applies only if the scale's type is "continuous" or "logarithmic".</summary>
		[Generated]
		public RangeSelectorScaleBuilder Breaks(Action<CollectionFactory<VizScaleBreakBuilder>> configurator)
		{
			Collection("breaks", configurator);
			return this;
		}

		/// <summary>Configures the scale breaks' appearance.</summary>
		[Generated]
		public RangeSelectorScaleBuilder BreakStyle(Action<RangeSelectorScaleBreakStyleBuilder> configurator)
		{
			NestedOptions("breakStyle", configurator);
			return this;
		}

		/// <summary>Specifies the order of arguments on a discrete scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Categories(IEnumerable<double> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of arguments on a discrete scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Categories(IEnumerable<string> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of arguments on a discrete scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Categories(IEnumerable<DateTime> value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies the order of arguments on a discrete scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Categories(JS value)
		{
			base.Options["categories"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the scale to start and end on ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the scale to start and end on ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies the scale's end value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's end value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's end value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's end value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Days to be excluded from the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Holidays(IEnumerable<double> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Days to be excluded from the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Holidays(IEnumerable<string> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Days to be excluded from the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Holidays(IEnumerable<DateTime> value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Days to be excluded from the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Holidays(JS value)
		{
			base.Options["holidays"] = value;
			return this;
		}

		/// <summary>Specifies common options for scale labels.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Label(Action<RangeSelectorScaleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic scale within which the scale should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public RangeSelectorScaleBuilder LinearThreshold(double value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value used to calculate the range on a logarithmic scale within which the scale should be linear. Applies only if the data source contains negative values or zeroes.</summary>
		[Generated]
		public RangeSelectorScaleBuilder LinearThreshold(JS value)
		{
			base.Options["linearThreshold"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies options for the date-time scale's markers.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Marker(Action<RangeSelectorScaleMarkerBuilder> configurator)
		{
			NestedOptions("marker", configurator);
			return this;
		}

		/// <summary>Specifies the maximum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MaxRange(Action<RangeSelectorScaleMaxRangeBuilder> configurator)
		{
			NestedOptions("maxRange", configurator);
			return this;
		}

		/// <summary>Specifies the maximum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MaxRange(VizTimeInterval value)
		{
			base.Options["maxRange"] = value;
			return this;
		}

		/// <summary>Specifies the maximum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MaxRange(double value)
		{
			base.Options["maxRange"] = value;
			return this;
		}

		/// <summary>Specifies the maximum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MaxRange(JS value)
		{
			base.Options["maxRange"] = value;
			return this;
		}

		/// <summary>Specifies options of the range selector's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTick(Action<RangeSelectorScaleMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies the number of minor ticks between neighboring major ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickCount(int value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies the number of minor ticks between neighboring major ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickCount(JS value)
		{
			base.Options["minorTickCount"] = value;
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickInterval(Action<RangeSelectorScaleMinorTickIntervalBuilder> configurator)
		{
			NestedOptions("minorTickInterval", configurator);
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickInterval(VizTimeInterval value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the minimum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinRange(Action<RangeSelectorScaleMinRangeBuilder> configurator)
		{
			NestedOptions("minRange", configurator);
			return this;
		}

		/// <summary>Specifies the minimum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinRange(VizTimeInterval value)
		{
			base.Options["minRange"] = value;
			return this;
		}

		/// <summary>Specifies the minimum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinRange(double value)
		{
			base.Options["minRange"] = value;
			return this;
		}

		/// <summary>Specifies the minimum range that can be selected.</summary>
		[Generated]
		public RangeSelectorScaleBuilder MinRange(JS value)
		{
			base.Options["minRange"] = value;
			return this;
		}

		/// <summary>Specifies the height of the space reserved for the scale in pixels.</summary>
		[Generated]
		public RangeSelectorScaleBuilder PlaceholderHeight(double value)
		{
			base.Options["placeholderHeight"] = value;
			return this;
		}

		/// <summary>Specifies the height of the space reserved for the scale in pixels.</summary>
		[Generated]
		public RangeSelectorScaleBuilder PlaceholderHeight(JS value)
		{
			base.Options["placeholderHeight"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show ticks for the boundary scale values, when neither major ticks nor minor ticks are created for these values.</summary>
		[Generated]
		public RangeSelectorScaleBuilder ShowCustomBoundaryTicks(bool value)
		{
			base.Options["showCustomBoundaryTicks"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show ticks for the boundary scale values, when neither major ticks nor minor ticks are created for these values.</summary>
		[Generated]
		public RangeSelectorScaleBuilder ShowCustomBoundaryTicks(JS value)
		{
			base.Options["showCustomBoundaryTicks"] = value;
			return this;
		}

		/// <summary>Days to be included in the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder SingleWorkdays(IEnumerable<double> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Days to be included in the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder SingleWorkdays(IEnumerable<string> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Days to be included in the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder SingleWorkdays(IEnumerable<DateTime> value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Days to be included in the scale when workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder SingleWorkdays(JS value)
		{
			base.Options["singleWorkdays"] = value;
			return this;
		}

		/// <summary>Specifies the scale's start value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's start value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's start value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies the scale's start value.</summary>
		[Generated]
		public RangeSelectorScaleBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies options defining the appearance of scale ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Tick(Action<RangeSelectorScaleTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder TickInterval(Action<RangeSelectorScaleTickIntervalBuilder> configurator)
		{
			NestedOptions("tickInterval", configurator);
			return this;
		}

		/// <summary>Specifies an interval between axis ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder TickInterval(VizTimeInterval value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between axis ticks.</summary>
		[Generated]
		public RangeSelectorScaleBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the type of the scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder Type(RangeSelectorAxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the type of values on the scale.</summary>
		[Generated]
		public RangeSelectorScaleBuilder ValueType(ChartDataType value)
		{
			base.Options["valueType"] = value;
			return this;
		}

		/// <summary>Leaves only workdays on the scale: the work week days plus single workdays minus holidays. Applies only if the scale's valueType is "datetime".</summary>
		[Generated]
		public RangeSelectorScaleBuilder WorkdaysOnly(bool value)
		{
			base.Options["workdaysOnly"] = value;
			return this;
		}

		/// <summary>Leaves only workdays on the scale: the work week days plus single workdays minus holidays. Applies only if the scale's valueType is "datetime".</summary>
		[Generated]
		public RangeSelectorScaleBuilder WorkdaysOnly(JS value)
		{
			base.Options["workdaysOnly"] = value;
			return this;
		}

		/// <summary>Specifies which days are workdays. The array can contain values from 0 (Sunday) to 6 (Saturday). Applies only if workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder WorkWeek(IEnumerable<int> value)
		{
			base.Options["workWeek"] = value;
			return this;
		}

		/// <summary>Specifies which days are workdays. The array can contain values from 0 (Sunday) to 6 (Saturday). Applies only if workdaysOnly is true.</summary>
		[Generated]
		public RangeSelectorScaleBuilder WorkWeek(JS value)
		{
			base.Options["workWeek"] = value;
			return this;
		}
	}
}
