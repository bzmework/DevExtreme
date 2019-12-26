using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MaxAppointmentsPerCell
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "unlimited")]
		Unlimited
	}
}
