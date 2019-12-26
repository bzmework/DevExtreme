using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HeaderFilterGroupInterval
	{
		[EnumMember(Value = "day")]
		Day,
		[EnumMember(Value = "hour")]
		Hour,
		[EnumMember(Value = "minute")]
		Minute,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "quarter")]
		Quarter,
		[EnumMember(Value = "second")]
		Second,
		[EnumMember(Value = "year")]
		Year
	}
}
