using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridEnterKeyDirection
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "column")]
		Column,
		[EnumMember(Value = "row")]
		Row
	}
}
