using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VerticalAlignment
	{
		[EnumMember(Value = "bottom")]
		Bottom,
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "top")]
		Top
	}
}
