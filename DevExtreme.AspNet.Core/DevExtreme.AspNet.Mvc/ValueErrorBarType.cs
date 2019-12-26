using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ValueErrorBarType
	{
		[EnumMember(Value = "fixed")]
		Fixed,
		[EnumMember(Value = "percent")]
		Percent,
		[EnumMember(Value = "stdDeviation")]
		StdDeviation,
		[EnumMember(Value = "stdError")]
		StdError,
		[EnumMember(Value = "variance")]
		Variance
	}
}
