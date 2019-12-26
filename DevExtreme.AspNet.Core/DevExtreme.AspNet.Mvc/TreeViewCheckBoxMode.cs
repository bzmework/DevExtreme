using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeViewCheckBoxMode
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "selectAll")]
		SelectAll
	}
}
