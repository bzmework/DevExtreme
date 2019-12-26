using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeMapColorizerType
	{
		[EnumMember(Value = "discrete")]
		Discrete,
		[EnumMember(Value = "gradient")]
		Gradient,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "range")]
		Range
	}
}
