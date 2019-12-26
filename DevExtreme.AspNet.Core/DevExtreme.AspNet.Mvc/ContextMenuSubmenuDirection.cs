using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContextMenuSubmenuDirection
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "left")]
		Left,
		[EnumMember(Value = "right")]
		Right
	}
}
