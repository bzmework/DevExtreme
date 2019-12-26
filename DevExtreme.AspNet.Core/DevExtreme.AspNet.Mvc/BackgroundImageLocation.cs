using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BackgroundImageLocation
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "centerBottom")]
		CenterBottom,
		[EnumMember(Value = "centerTop")]
		CenterTop,
		[EnumMember(Value = "full")]
		Full,
		[EnumMember(Value = "leftBottom")]
		LeftBottom,
		[EnumMember(Value = "leftCenter")]
		LeftCenter,
		[EnumMember(Value = "leftTop")]
		LeftTop,
		[EnumMember(Value = "rightBottom")]
		RightBottom,
		[EnumMember(Value = "rightCenter")]
		RightCenter,
		[EnumMember(Value = "rightTop")]
		RightTop
	}
}
