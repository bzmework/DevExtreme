using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GeoMapRouteMode
	{
		[EnumMember(Value = "driving")]
		Driving,
		[EnumMember(Value = "walking")]
		Walking
	}
}
