using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GanttScaleType
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "minutes")]
		Minutes,
		[EnumMember(Value = "hours")]
		Hours,
		[EnumMember(Value = "days")]
		Days,
		[EnumMember(Value = "weeks")]
		Weeks,
		[EnumMember(Value = "months")]
		Months
	}
}
