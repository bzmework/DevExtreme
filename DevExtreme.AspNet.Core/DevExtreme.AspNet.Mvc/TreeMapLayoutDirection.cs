using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeMapLayoutDirection
	{
		[EnumMember(Value = "leftBottomRightTop")]
		LeftBottomRightTop,
		[EnumMember(Value = "leftTopRightBottom")]
		LeftTopRightBottom,
		[EnumMember(Value = "rightBottomLeftTop")]
		RightBottomLeftTop,
		[EnumMember(Value = "rightTopLeftBottom")]
		RightTopLeftBottom
	}
}
