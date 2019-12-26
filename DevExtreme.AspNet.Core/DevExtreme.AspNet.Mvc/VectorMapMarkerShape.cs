using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VectorMapMarkerShape
	{
		[EnumMember(Value = "circle")]
		Circle,
		[EnumMember(Value = "square")]
		Square
	}
}
