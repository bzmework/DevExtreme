using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HorizontalAlignment
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right
	}
}
