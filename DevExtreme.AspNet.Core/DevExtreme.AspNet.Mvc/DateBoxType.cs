using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DateBoxType
	{
		[EnumMember(Value = "date")]
		Date,
		[EnumMember(Value = "datetime")]
		DateTime,
		[EnumMember(Value = "time")]
		Time
	}
}
