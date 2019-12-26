using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VisualRangeUpdateMode
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "keep")]
		Keep,
		[EnumMember(Value = "reset")]
		Reset,
		[EnumMember(Value = "shift")]
		Shift
	}
}
