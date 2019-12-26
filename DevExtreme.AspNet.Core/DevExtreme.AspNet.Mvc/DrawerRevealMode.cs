using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DrawerRevealMode
	{
		[EnumMember(Value = "slide")]
		Slide,
		[EnumMember(Value = "expand")]
		Expand
	}
}
