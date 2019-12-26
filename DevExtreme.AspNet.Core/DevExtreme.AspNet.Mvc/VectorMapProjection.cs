using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VectorMapProjection
	{
		[EnumMember(Value = "equirectangular")]
		Equirectangular,
		[EnumMember(Value = "lambert")]
		Lambert,
		[EnumMember(Value = "mercator")]
		Mercator,
		[EnumMember(Value = "miller")]
		Miller
	}
}
