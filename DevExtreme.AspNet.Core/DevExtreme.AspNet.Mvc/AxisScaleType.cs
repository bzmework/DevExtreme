using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AxisScaleType
	{
		[EnumMember(Value = "continuous")]
		Continuous,
		[EnumMember(Value = "discrete")]
		Discrete,
		[EnumMember(Value = "logarithmic")]
		Logarithmic
	}
}
