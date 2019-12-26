using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridDataType
	{
		[EnumMember(Value = "date")]
		Date,
		[EnumMember(Value = "number")]
		Number,
		[EnumMember(Value = "string")]
		String
	}
}
