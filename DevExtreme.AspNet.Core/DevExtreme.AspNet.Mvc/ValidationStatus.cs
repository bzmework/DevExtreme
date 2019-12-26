using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ValidationStatus
	{
		[EnumMember(Value = "valid")]
		Valid,
		[EnumMember(Value = "invalid")]
		Invalid,
		[EnumMember(Value = "pending")]
		Pending
	}
}
