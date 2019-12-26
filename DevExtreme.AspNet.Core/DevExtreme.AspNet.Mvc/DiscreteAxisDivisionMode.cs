using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiscreteAxisDivisionMode
	{
		[EnumMember(Value = "betweenLabels")]
		BetweenLabels,
		[EnumMember(Value = "crossLabels")]
		CrossLabels
	}
}
