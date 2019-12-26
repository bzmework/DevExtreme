using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SelectionMode
	{
		[EnumMember(Value = "multiple")]
		Multiple,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "single")]
		Single
	}
}
