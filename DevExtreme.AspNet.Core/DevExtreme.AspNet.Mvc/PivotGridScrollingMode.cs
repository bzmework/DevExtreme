using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridScrollingMode
	{
		[EnumMember(Value = "standard")]
		Standard,
		[EnumMember(Value = "virtual")]
		Virtual
	}
}
