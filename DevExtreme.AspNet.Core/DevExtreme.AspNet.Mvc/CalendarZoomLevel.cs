using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CalendarZoomLevel
	{
		[EnumMember(Value = "century")]
		Century,
		[EnumMember(Value = "decade")]
		Decade,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "year")]
		Year
	}
}
