using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizPointSymbol
	{
		[EnumMember(Value = "circle")]
		Circle,
		[EnumMember(Value = "cross")]
		Cross,
		[EnumMember(Value = "polygon")]
		Polygon,
		[EnumMember(Value = "square")]
		Square,
		[EnumMember(Value = "triangle")]
		Triangle
	}
}
