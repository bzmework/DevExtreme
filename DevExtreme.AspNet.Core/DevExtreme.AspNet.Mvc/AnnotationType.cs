using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AnnotationType
	{
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "image")]
		Image,
		[EnumMember(Value = "custom")]
		Custom
	}
}
