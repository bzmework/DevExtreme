using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Toolbar
	{
		[EnumMember(Value = "bottom")]
		Bottom,
		[EnumMember(Value = "top")]
		Top
	}
}
