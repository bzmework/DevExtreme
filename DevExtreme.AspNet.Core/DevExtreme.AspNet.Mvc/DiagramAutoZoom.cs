using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramAutoZoom
	{
		[EnumMember(Value = "fitContent")]
		FitContent,
		[EnumMember(Value = "fitWidth")]
		FitWidth,
		[EnumMember(Value = "disabled")]
		Disabled
	}
}
