using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridColumnRenderingMode
	{
		[EnumMember(Value = "standard")]
		Standard,
		[EnumMember(Value = "virtual")]
		Virtual
	}
}
