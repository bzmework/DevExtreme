using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridSummaryDisplayMode
	{
		[EnumMember(Value = "absoluteVariation")]
		AbsoluteVariation,
		[EnumMember(Value = "percentOfColumnGrandTotal")]
		PercentOfColumnGrandTotal,
		[EnumMember(Value = "percentOfColumnTotal")]
		PercentOfColumnTotal,
		[EnumMember(Value = "percentOfGrandTotal")]
		PercentOfGrandTotal,
		[EnumMember(Value = "percentOfRowGrandTotal")]
		PercentOfRowGrandTotal,
		[EnumMember(Value = "percentOfRowTotal")]
		PercentOfRowTotal,
		[EnumMember(Value = "percentVariation")]
		PercentVariation
	}
}
