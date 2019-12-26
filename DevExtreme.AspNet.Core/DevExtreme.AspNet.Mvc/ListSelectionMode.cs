using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ListSelectionMode
	{
		[EnumMember(Value = "all")]
		All,
		[EnumMember(Value = "multiple")]
		Multiple,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "single")]
		Single
	}
}
