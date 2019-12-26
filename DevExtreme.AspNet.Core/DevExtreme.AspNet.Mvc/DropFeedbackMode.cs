using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DropFeedbackMode
	{
		[EnumMember(Value = "push")]
		Push,
		[EnumMember(Value = "indicate")]
		Indicate
	}
}
