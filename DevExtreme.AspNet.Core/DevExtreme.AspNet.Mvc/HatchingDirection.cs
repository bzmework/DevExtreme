using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HatchingDirection
	{
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "right")]
		Right
	}
}
