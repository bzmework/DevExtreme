using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridArea
	{
		[EnumMember(Value = "column")]
		Column,
		[EnumMember(Value = "data")]
		Data,
		[EnumMember(Value = "filter")]
		Filter,
		[EnumMember(Value = "row")]
		Row
	}
}
