using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FilterBuilderGroupOperations
	{
		[EnumMember(Value = "and")]
		And,
		[EnumMember(Value = "or")]
		Or,
		[EnumMember(Value = "notAnd")]
		NotAnd,
		[EnumMember(Value = "notOr")]
		NotOr
	}
}
