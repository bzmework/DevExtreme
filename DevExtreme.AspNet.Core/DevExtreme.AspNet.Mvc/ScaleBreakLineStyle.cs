using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ScaleBreakLineStyle
	{
		[EnumMember(Value = "straight")]
		Straight,
		[EnumMember(Value = "waved")]
		Waved
	}
}
