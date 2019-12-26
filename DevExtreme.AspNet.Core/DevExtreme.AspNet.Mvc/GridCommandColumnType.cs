using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridCommandColumnType
	{
		[EnumMember(Value = "adaptive")]
		Adaptive,
		[EnumMember(Value = "buttons")]
		Buttons,
		[EnumMember(Value = "detailExpand")]
		DetailExpand,
		[EnumMember(Value = "groupExpand")]
		GroupExpand,
		[EnumMember(Value = "selection")]
		Selection
	}
}
