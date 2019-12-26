using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ToastType
	{
		[EnumMember(Value = "custom")]
		Custom,
		[EnumMember(Value = "error")]
		Error,
		[EnumMember(Value = "info")]
		Info,
		[EnumMember(Value = "success")]
		Success,
		[EnumMember(Value = "warning")]
		Warning
	}
}
