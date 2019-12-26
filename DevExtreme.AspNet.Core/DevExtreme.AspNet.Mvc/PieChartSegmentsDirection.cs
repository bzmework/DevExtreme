using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PieChartSegmentsDirection
	{
		[EnumMember(Value = "anticlockwise")]
		AntiClockwise,
		[EnumMember(Value = "clockwise")]
		Clockwise
	}
}
