using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NumberBoxMode
	{
		[EnumMember(Value = "number")]
		Number,
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "tel")]
		Tel
	}
}
