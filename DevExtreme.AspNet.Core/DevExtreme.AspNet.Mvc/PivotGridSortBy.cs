using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridSortBy
	{
		[EnumMember(Value = "displayText")]
		DisplayText,
		[EnumMember(Value = "value")]
		Value,
		[EnumMember(Value = "none")]
		None
	}
}
