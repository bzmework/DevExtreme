using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Orientation
	{
		[EnumMember(Value = "horizontal")]
		Horizontal,
		[EnumMember(Value = "vertical")]
		Vertical
	}
}
