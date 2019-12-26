using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShowSubmenuMode
	{
		[EnumMember(Value = "onClick")]
		OnClick,
		[EnumMember(Value = "onHover")]
		OnHover
	}
}
