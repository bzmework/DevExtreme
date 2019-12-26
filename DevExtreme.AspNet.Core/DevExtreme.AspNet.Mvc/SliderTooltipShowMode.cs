using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SliderTooltipShowMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "onHover")]
		OnHover
	}
}
