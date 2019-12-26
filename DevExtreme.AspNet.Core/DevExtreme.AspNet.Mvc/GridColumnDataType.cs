using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridColumnDataType
	{
		[EnumMember(Value = "string")]
		String,
		[EnumMember(Value = "number")]
		Number,
		[EnumMember(Value = "date")]
		Date,
		[EnumMember(Value = "boolean")]
		Boolean,
		[EnumMember(Value = "object")]
		Object,
		[EnumMember(Value = "datetime")]
		DateTime
	}
}
