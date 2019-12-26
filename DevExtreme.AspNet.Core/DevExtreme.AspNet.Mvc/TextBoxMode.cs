using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextBoxMode
	{
		[EnumMember(Value = "email")]
		Email,
		[EnumMember(Value = "password")]
		Password,
		[EnumMember(Value = "search")]
		Search,
		[EnumMember(Value = "tel")]
		Tel,
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "url")]
		Url
	}
}
