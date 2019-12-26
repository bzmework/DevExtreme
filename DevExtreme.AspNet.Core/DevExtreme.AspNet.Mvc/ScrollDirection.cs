using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ScrollDirection
	{
		[EnumMember(Value = "both")]
		Both,
		[EnumMember(Value = "horizontal")]
		Horizontal,
		[EnumMember(Value = "vertical")]
		Vertical
	}
}
