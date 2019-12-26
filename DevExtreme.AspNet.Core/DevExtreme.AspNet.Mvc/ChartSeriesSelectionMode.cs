using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartSeriesSelectionMode
	{
		[EnumMember(Value = "allArgumentPoints")]
		AllArgumentPoints,
		[EnumMember(Value = "allSeriesPoints")]
		AllSeriesPoints,
		[EnumMember(Value = "excludePoints")]
		ExcludePoints,
		[EnumMember(Value = "includePoints")]
		IncludePoints,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "onlyPoint")]
		OnlyPoint
	}
}
