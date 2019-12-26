using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Direction
	{
		[EnumMember(Value = "bottom")]
		Bottom,
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right,
		[EnumMember(Value = "top")]
		Top
	}
}
