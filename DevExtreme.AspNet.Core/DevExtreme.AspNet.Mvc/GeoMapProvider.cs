using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoMapProvider
	{
		[EnumMember(Value = "bing")]
		Bing,
		[EnumMember(Value = "google")]
		Google,
		[EnumMember(Value = "googleStatic")]
		GoogleStatic
	}
}
