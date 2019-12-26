using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SummaryType
	{
		[EnumMember(Value = "avg")]
		Avg,
		[EnumMember(Value = "count")]
		Count,
		[EnumMember(Value = "custom")]
		Custom,
		[EnumMember(Value = "max")]
		Max,
		[EnumMember(Value = "min")]
		Min,
		[EnumMember(Value = "sum")]
		Sum
	}
}
