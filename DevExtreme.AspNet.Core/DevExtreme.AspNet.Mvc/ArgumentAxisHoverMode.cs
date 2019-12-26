using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ArgumentAxisHoverMode
	{
		[EnumMember(Value = "allArgumentPoints")]
		AllArgumentPoints,
		[EnumMember(Value = "none")]
		None
	}
}
