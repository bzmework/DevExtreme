using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartPointInteractionMode
	{
		[EnumMember(Value = "allArgumentPoints")]
		AllArgumentPoints,
		[EnumMember(Value = "allSeriesPoints")]
		AllSeriesPoints,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "onlyPoint")]
		OnlyPoint
	}
}
