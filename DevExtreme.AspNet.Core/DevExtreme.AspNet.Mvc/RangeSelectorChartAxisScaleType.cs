using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RangeSelectorChartAxisScaleType
	{
		[EnumMember(Value = "continuous")]
		Continuous,
		[EnumMember(Value = "logarithmic")]
		Logarithmic
	}
}
