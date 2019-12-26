using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ToolbarItemLocation
	{
		[EnumMember(Value = "after")]
		After,
		[EnumMember(Value = "before")]
		Before,
		[EnumMember(Value = "center")]
		Center
	}
}
