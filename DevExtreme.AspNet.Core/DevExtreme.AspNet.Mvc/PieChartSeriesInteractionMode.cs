using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PieChartSeriesInteractionMode
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "onlyPoint")]
		OnlyPoint
	}
}
