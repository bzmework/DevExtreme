using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Format
	{
		[EnumMember(Value = "billions")]
		Billions,
		[EnumMember(Value = "currency")]
		Currency,
		[EnumMember(Value = "day")]
		Day,
		[EnumMember(Value = "decimal")]
		Decimal,
		[EnumMember(Value = "exponential")]
		Exponential,
		[EnumMember(Value = "fixedPoint")]
		FixedPoint,
		[EnumMember(Value = "largeNumber")]
		LargeNumber,
		[EnumMember(Value = "longDate")]
		LongDate,
		[EnumMember(Value = "longTime")]
		LongTime,
		[EnumMember(Value = "millions")]
		Millions,
		[EnumMember(Value = "millisecond")]
		Millisecond,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "monthAndDay")]
		MonthAndDay,
		[EnumMember(Value = "monthAndYear")]
		MonthAndYear,
		[EnumMember(Value = "percent")]
		Percent,
		[EnumMember(Value = "quarter")]
		Quarter,
		[EnumMember(Value = "quarterAndYear")]
		QuarterAndYear,
		[EnumMember(Value = "shortDate")]
		ShortDate,
		[EnumMember(Value = "shortTime")]
		ShortTime,
		[EnumMember(Value = "thousands")]
		Thousands,
		[EnumMember(Value = "trillions")]
		Trillions,
		[EnumMember(Value = "year")]
		Year,
		[EnumMember(Value = "dayOfWeek")]
		DayOfWeek,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "longDateLongTime")]
		LongDateLongTime,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "shortDateShortTime")]
		ShortDateShortTime
	}
}
