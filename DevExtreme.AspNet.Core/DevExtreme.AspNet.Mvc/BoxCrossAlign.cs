using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BoxCrossAlign
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "end")]
		End,
		[EnumMember(Value = "start")]
		Start,
		[EnumMember(Value = "stretch")]
		Stretch
	}
}
