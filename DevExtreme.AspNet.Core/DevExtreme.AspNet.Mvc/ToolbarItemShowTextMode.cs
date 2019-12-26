using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ToolbarItemShowTextMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "inMenu")]
		InMenu
	}
}
