using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ComparisonOperator
	{
		[EnumMember(Value = "!=")]
		NotEqual,
		[EnumMember(Value = "!==")]
		NotStrictEqual,
		[EnumMember(Value = "<")]
		LessThan,
		[EnumMember(Value = "<=")]
		LessThanOrEqual,
		[EnumMember(Value = "==")]
		Equal,
		[EnumMember(Value = "===")]
		StrictEqual,
		[EnumMember(Value = ">")]
		GreaterThan,
		[EnumMember(Value = ">=")]
		GreaterThanOrEqual
	}
}
