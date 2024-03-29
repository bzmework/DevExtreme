using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PolarChartOverlappingBehavior
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "hide")]
		Hide
	}
}
