using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EditorStylingMode
	{
		[EnumMember(Value = "outlined")]
		Outlined,
		[EnumMember(Value = "underlined")]
		Underlined,
		[EnumMember(Value = "filled")]
		Filled
	}
}
