using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ValueErrorBarDisplayMode
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "high")]
		High,
		[EnumMember(Value = "low")]
		Low,
		[EnumMember(Value = "none")]
		None
	}
}
