using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PolarChartSeriesType
	{
		[EnumMember(Value = "area")]
		Area,
		[EnumMember(Value = "bar")]
		Bar,
		[EnumMember(Value = "line")]
		Line,
		[EnumMember(Value = "scatter")]
		Scatter,
		[EnumMember(Value = "stackedbar")]
		Stackedbar
	}
}
