using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DrawerPosition
	{
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right,
		[EnumMember(Value = "top")]
		Top,
		[EnumMember(Value = "bottom")]
		Bottom,
		[EnumMember(Value = "before")]
		Before,
		[EnumMember(Value = "after")]
		After
	}
}
