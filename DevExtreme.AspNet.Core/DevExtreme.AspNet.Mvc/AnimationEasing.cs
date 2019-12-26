using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AnimationEasing
	{
		[EnumMember(Value = "ease")]
		Ease,
		[EnumMember(Value = "ease-in")]
		EaseIn,
		[EnumMember(Value = "ease-in-out")]
		EaseInOut,
		[EnumMember(Value = "ease-out")]
		EaseOut,
		[EnumMember(Value = "linear")]
		Linear,
		[EnumMember(Value = "step-end")]
		StepEnd,
		[EnumMember(Value = "step-start")]
		StepStart,
		[EnumMember(Value = "swing")]
		Swing
	}
}
