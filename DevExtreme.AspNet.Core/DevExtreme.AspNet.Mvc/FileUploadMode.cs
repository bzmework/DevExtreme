using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FileUploadMode
	{
		[EnumMember(Value = "instantly")]
		Instantly,
		[EnumMember(Value = "useButtons")]
		UseButtons,
		[EnumMember(Value = "useForm")]
		UseForm
	}
}
