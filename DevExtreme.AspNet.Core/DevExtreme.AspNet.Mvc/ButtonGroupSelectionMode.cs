using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ButtonGroupSelectionMode
	{
		[EnumMember(Value = "multiple")]
		Multiple,
		[EnumMember(Value = "single")]
		Single
	}
}
