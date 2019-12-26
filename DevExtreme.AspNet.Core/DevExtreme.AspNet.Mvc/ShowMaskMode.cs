using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShowMaskMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "onFocus")]
		OnFocus
	}
}
