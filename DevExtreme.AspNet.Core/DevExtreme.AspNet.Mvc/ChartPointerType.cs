using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ChartPointerType
	{
		[EnumMember(Value = "all")]
		All,
		[EnumMember(Value = "mouse")]
		Mouse,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "touch")]
		Touch
	}
}
