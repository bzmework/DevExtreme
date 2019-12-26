using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridApplyFilterMode
	{
		[EnumMember(Value = "auto")]
		Auto,
		[EnumMember(Value = "onClick")]
		OnClick
	}
}
