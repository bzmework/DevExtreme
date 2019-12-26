using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartLabelDisplayMode
	{
		[EnumMember(Value = "rotate")]
		Rotate,
		[EnumMember(Value = "stagger")]
		Stagger,
		[EnumMember(Value = "standard")]
		Standard
	}
}
