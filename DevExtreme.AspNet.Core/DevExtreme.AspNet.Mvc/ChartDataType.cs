using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartDataType
	{
		[EnumMember(Value = "datetime")]
		DateTime,
		[EnumMember(Value = "numeric")]
		Numeric,
		[EnumMember(Value = "string")]
		String
	}
}
