using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizPaletteExtensionMode
	{
		[EnumMember(Value = "alternate")]
		Alternate,
		[EnumMember(Value = "blend")]
		Blend,
		[EnumMember(Value = "extrapolate")]
		Extrapolate
	}
}
