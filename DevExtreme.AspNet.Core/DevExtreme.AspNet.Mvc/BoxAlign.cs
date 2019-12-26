using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BoxAlign
	{
		[EnumMember(Value = "center")]
		Center,
		[EnumMember(Value = "end")]
		End,
		[EnumMember(Value = "space-around")]
		SpaceAround,
		[EnumMember(Value = "space-between")]
		SpaceBetween,
		[EnumMember(Value = "start")]
		Start
	}
}
