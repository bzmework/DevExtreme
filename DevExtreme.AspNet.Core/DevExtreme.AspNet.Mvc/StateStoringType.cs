using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StateStoringType
	{
		[EnumMember(Value = "custom")]
		Custom,
		[EnumMember(Value = "localStorage")]
		LocalStorage,
		[EnumMember(Value = "sessionStorage")]
		SessionStorage
	}
}
