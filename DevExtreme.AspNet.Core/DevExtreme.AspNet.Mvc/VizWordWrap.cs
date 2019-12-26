using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizWordWrap
	{
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "breakWord")]
		BreakWord,
		[EnumMember(Value = "none")]
		None
	}
}
