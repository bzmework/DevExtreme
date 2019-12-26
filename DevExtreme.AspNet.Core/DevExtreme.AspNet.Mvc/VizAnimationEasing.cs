using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizAnimationEasing
	{
		[EnumMember(Value = "easeOutCubic")]
		EaseOutCubic,
		[EnumMember(Value = "linear")]
		Linear
	}
}
