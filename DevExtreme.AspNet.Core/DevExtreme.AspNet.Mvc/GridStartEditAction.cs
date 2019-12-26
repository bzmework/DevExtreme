using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridStartEditAction
	{
		[EnumMember(Value = "click")]
		Click,
		[EnumMember(Value = "dblClick")]
		DblClick
	}
}
