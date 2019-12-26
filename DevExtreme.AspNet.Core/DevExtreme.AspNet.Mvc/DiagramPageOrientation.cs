using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramPageOrientation
	{
		[EnumMember(Value = "portrait")]
		Portrait,
		[EnumMember(Value = "landscape")]
		Landscape
	}
}
