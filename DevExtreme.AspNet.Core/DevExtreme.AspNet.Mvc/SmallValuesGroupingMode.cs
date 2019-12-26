using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SmallValuesGroupingMode
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "smallValueThreshold")]
		SmallValueThreshold,
		[EnumMember(Value = "topN")]
		TopN
	}
}
