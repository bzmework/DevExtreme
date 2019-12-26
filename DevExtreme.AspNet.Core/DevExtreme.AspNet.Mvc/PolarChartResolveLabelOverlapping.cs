using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PolarChartResolveLabelOverlapping
	{
		[EnumMember(Value = "hide")]
		Hide,
		[EnumMember(Value = "none")]
		None
	}
}
