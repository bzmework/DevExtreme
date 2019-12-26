using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CircularGaugeElementOrientation
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "inside")]
		Inside,
		[EnumMember(Value = "outside")]
		Outside
	}
}
