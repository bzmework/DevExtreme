using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AnimationType
	{
		[EnumMember(Value = "css")]
		Css,
		[EnumMember(Value = "fade")]
		Fade,
		[EnumMember(Value = "fadeIn")]
		FadeIn,
		[EnumMember(Value = "fadeOut")]
		FadeOut,
		[EnumMember(Value = "pop")]
		Pop,
		[EnumMember(Value = "slide")]
		Slide,
		[EnumMember(Value = "slideIn")]
		SlideIn,
		[EnumMember(Value = "slideOut")]
		SlideOut
	}
}
