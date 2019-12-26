using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventKeyModifier
	{
		[EnumMember(Value = "alt")]
		Alt,
		[EnumMember(Value = "ctrl")]
		Ctrl,
		[EnumMember(Value = "meta")]
		Meta,
		[EnumMember(Value = "shift")]
		Shift
	}
}
