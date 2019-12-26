using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartSeriesAggregationMethod
	{
		[EnumMember(Value = "avg")]
		Avg,
		[EnumMember(Value = "count")]
		Count,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "ohlc")]
		Ohlc,
		[EnumMember(Value = "range")]
		Range,
		[EnumMember(Value = "sum")]
		Sum,
		[EnumMember(Value = "custom")]
		Custom
	}
}
