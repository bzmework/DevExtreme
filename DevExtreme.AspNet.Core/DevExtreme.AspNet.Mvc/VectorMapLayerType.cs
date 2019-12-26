using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VectorMapLayerType
	{
		[EnumMember(Value = "area")]
		Area,
		[EnumMember(Value = "line")]
		Line,
		[EnumMember(Value = "marker")]
		Marker
	}
}
