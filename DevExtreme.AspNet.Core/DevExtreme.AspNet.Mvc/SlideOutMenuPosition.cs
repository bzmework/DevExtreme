using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SlideOutMenuPosition
	{
		[EnumMember(Value = "inverted")]
		Inverted,
		[EnumMember(Value = "normal")]
		Normal
	}
}
