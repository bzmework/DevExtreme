using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SankeyLabelOverlappingBehavior
	{
		[EnumMember(Value = "ellipsis")]
		Ellipsis,
		[EnumMember(Value = "hide")]
		Hide,
		[EnumMember(Value = "none")]
		None
	}
}
