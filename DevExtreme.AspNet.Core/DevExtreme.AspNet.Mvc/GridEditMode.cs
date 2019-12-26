using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridEditMode
	{
		[EnumMember(Value = "batch")]
		Batch,
		[EnumMember(Value = "cell")]
		Cell,
		[EnumMember(Value = "row")]
		Row,
		[EnumMember(Value = "form")]
		Form,
		[EnumMember(Value = "popup")]
		Popup
	}
}
