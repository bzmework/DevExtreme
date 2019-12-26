using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridScrollingMode
	{
		[EnumMember(Value = "infinite")]
		Infinite,
		[EnumMember(Value = "standard")]
		Standard,
		[EnumMember(Value = "virtual")]
		Virtual
	}
}
