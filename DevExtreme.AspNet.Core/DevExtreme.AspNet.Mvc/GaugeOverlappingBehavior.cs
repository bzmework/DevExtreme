using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GaugeOverlappingBehavior
	{
		[EnumMember(Value = "first")]
		HideFirstLabel,
		[EnumMember(Value = "last")]
		HideLastLabel
	}
}
