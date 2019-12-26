using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ListItemDeleteMode
	{
		[EnumMember(Value = "context")]
		Context,
		[EnumMember(Value = "slideButton")]
		SlideButton,
		[EnumMember(Value = "slideItem")]
		SlideItem,
		[EnumMember(Value = "static")]
		Static,
		[EnumMember(Value = "swipe")]
		Swipe,
		[EnumMember(Value = "toggle")]
		Toggle
	}
}
