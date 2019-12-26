using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeViewExpandEvent
	{
		[EnumMember(Value = "dblclick")]
		DblClick,
		[EnumMember(Value = "click")]
		Click
	}
}
