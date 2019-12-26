using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramDataLayoutType
	{
		[EnumMember(Value = "off")]
		Off,
		[EnumMember(Value = "tree")]
		Tree,
		[EnumMember(Value = "layered")]
		Layered
	}
}
