using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramToolboxDisplayMode
	{
		[EnumMember(Value = "icons")]
		Icons,
		[EnumMember(Value = "texts")]
		Texts
	}
}
