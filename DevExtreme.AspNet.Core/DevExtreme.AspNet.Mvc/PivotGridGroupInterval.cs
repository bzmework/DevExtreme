using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridGroupInterval
	{
		[EnumMember(Value = "day")]
		Day,
		[EnumMember(Value = "dayOfWeek")]
		DayOfWeek,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "quarter")]
		Quarter,
		[EnumMember(Value = "year")]
		Year
	}
}
