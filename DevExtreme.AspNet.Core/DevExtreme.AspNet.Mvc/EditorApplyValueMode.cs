using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EditorApplyValueMode
	{
		[EnumMember(Value = "instantly")]
		Instantly,
		[EnumMember(Value = "useButtons")]
		UseButtons
	}
}
