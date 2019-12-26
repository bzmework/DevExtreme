using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartZoomAndPanMode
	{
		[EnumMember(Value = "both")]
		Both,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "pan")]
		Pan,
		[EnumMember(Value = "zoom")]
		Zoom
	}
}
