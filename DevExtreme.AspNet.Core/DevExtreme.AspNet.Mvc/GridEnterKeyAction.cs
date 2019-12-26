using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridEnterKeyAction
	{
		[EnumMember(Value = "startEdit")]
		StartEdit,
		[EnumMember(Value = "moveFocus")]
		MoveFocus
	}
}
