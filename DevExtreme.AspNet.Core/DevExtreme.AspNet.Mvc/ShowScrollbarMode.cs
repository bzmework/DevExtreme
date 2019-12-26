using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShowScrollbarMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "never")]
		Never,
		[EnumMember(Value = "onHover")]
		OnHover,
		[EnumMember(Value = "onScroll")]
		OnScroll
	}
}
