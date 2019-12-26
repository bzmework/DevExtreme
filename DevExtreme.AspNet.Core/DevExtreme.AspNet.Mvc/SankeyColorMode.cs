using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SankeyColorMode
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "source")]
		Source,
		[EnumMember(Value = "target")]
		Target,
		[EnumMember(Value = "gradient")]
		Gradient
	}
}
