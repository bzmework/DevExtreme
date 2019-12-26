using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ButtonStylingMode
	{
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "outlined")]
		Outlined,
		[EnumMember(Value = "contained")]
		Contained
	}
}
