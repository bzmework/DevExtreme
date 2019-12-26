using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ListMenuMode
	{
		[EnumMember(Value = "context")]
		Context,
		[EnumMember(Value = "slide")]
		Slide
	}
}
