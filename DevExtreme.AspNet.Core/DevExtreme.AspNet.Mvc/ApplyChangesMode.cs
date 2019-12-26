using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ApplyChangesMode
	{
		[EnumMember(Value = "instantly")]
		Instantly,
		[EnumMember(Value = "onDemand")]
		OnDemand
	}
}
