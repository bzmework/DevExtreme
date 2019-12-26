using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramDataLayoutOrientation
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "vertical")]
		Vertical,
		[EnumMember(Value = "horizontal")]
		Horizontal
	}
}
