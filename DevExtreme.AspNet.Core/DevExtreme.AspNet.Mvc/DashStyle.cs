using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DashStyle
	{
		[EnumMember(Value = "dash")]
		Dash,
		[EnumMember(Value = "dot")]
		Dot,
		[EnumMember(Value = "longDash")]
		LongDash,
		[EnumMember(Value = "solid")]
		Solid
	}
}
