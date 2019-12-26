using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ButtonType
	{
		[EnumMember(Value = "back")]
		Back,
		[EnumMember(Value = "danger")]
		Danger,
		[EnumMember(Value = "default")]
		Default,
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "success")]
		Success
	}
}
