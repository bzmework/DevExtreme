using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PositionAlignment
	{
		[EnumMember(Value = "bottom")]
		Bottom,
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "left bottom")]
		LeftBottom,
		[EnumMember(Value = "left top")]
		LeftTop,
		[EnumMember(Value = "right")]
		Right,
		[EnumMember(Value = "right bottom")]
		RightBottom,
		[EnumMember(Value = "right top")]
		RightTop,
		[EnumMember(Value = "top")]
		Top
	}
}
