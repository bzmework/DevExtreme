using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FinancialChartReductionLevel
	{
		[EnumMember(Value = "close")]
		Close,
		[EnumMember(Value = "high")]
		High,
		[EnumMember(Value = "low")]
		Low,
		[EnumMember(Value = "open")]
		Open
	}
}
