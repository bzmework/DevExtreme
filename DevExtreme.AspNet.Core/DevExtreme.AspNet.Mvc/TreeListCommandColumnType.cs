using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeListCommandColumnType
	{
		[EnumMember(Value = "adaptive")]
		Adaptive,
		[EnumMember(Value = "buttons")]
		Buttons
	}
}
