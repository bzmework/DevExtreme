using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PositionResolveCollision
	{
		[EnumMember(Value = "fit")]
		Fit,
		[EnumMember(Value = "flip")]
		Flip,
		[EnumMember(Value = "flipfit")]
		FlipFit,
		[EnumMember(Value = "none")]
		None
	}
}
