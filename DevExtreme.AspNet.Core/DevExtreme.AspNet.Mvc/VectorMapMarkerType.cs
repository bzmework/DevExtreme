using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VectorMapMarkerType
	{
		[EnumMember(Value = "bubble")]
		Bubble,
		[EnumMember(Value = "dot")]
		Dot,
		[EnumMember(Value = "image")]
		Image,
		[EnumMember(Value = "pie")]
		Pie
	}
}
