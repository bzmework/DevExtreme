using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ValueChangedCallMode
	{
		[EnumMember(Value = "onMoving")]
		OnMoving,
		[EnumMember(Value = "onMovingComplete")]
		OnMovingComplete
	}
}
