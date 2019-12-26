using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SubmenuDirection
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "leftOrTop")]
		LeftOrTop,
		[EnumMember(Value = "rightOrBottom")]
		RightOrBottom
	}
}
