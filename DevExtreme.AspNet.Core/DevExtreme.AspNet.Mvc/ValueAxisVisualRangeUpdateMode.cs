using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ValueAxisVisualRangeUpdateMode
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "keep")]
		Keep,
		[EnumMember(Value = "reset")]
		Reset
	}
}
