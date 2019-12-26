using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OverlappingBehavior
	{
		[EnumMember(Value = "rotate")]
		Rotate,
		[EnumMember(Value = "stagger")]
		Stagger,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "hide")]
		Hide
	}
}
