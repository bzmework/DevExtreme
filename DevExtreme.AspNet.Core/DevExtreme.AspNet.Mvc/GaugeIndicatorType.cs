using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GaugeIndicatorType
	{
		[EnumMember(Value = "circle")]
		Circle,
		[EnumMember(Value = "rangeBar")]
		RangeBar,
		[EnumMember(Value = "rectangle")]
		Rectangle,
		[EnumMember(Value = "rectangleNeedle")]
		RectangleNeedle,
		[EnumMember(Value = "rhombus")]
		Rhombus,
		[EnumMember(Value = "textCloud")]
		TextCloud,
		[EnumMember(Value = "triangleMarker")]
		TriangleMarker,
		[EnumMember(Value = "triangleNeedle")]
		TriangleNeedle,
		[EnumMember(Value = "twoColorNeedle")]
		TwoColorNeedle
	}
}
