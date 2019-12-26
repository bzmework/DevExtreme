using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ToolbarItemLocateInMenuMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "never")]
		Never
	}
}
