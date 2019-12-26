using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridTotalsDisplayMode
	{
		[EnumMember(Value = "both")]
		Both,
		[EnumMember(Value = "columns")]
		Columns,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "rows")]
		Rows
	}
}
