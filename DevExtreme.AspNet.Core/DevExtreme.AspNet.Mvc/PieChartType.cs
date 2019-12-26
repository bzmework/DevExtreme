using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PieChartType
	{
		[EnumMember(Value = "donut")]
		Donut,
		[EnumMember(Value = "doughnut")]
		Doughnut,
		[EnumMember(Value = "pie")]
		Pie
	}
}
