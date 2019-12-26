using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramUnits
	{
		[EnumMember(Value = "in")]
		In,
		[EnumMember(Value = "cm")]
		Cm,
		[EnumMember(Value = "px")]
		Px
	}
}
