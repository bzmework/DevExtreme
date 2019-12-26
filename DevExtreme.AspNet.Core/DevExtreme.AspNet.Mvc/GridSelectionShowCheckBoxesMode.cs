using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridSelectionShowCheckBoxesMode
	{
		[EnumMember(Value = "always")]
		Always,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "onClick")]
		OnClick,
		[EnumMember(Value = "onLongTap")]
		OnLongTap
	}
}
