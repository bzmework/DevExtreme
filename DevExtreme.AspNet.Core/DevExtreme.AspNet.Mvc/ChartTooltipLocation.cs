using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartTooltipLocation
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "edge")]
		Edge
	}
}
