using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FilterBuilderFieldFilterOperations
	{
		[EnumMember(Value = "=")]
		Equal,
		[EnumMember(Value = "<>")]
		NotEqual,
		[EnumMember(Value = "<")]
		LessThan,
		[EnumMember(Value = "<=")]
		LessThanOrEqual,
		[EnumMember(Value = ">")]
		GreaterThan,
		[EnumMember(Value = ">=")]
		GreaterThanOrEqual,
		[EnumMember(Value = "contains")]
		Contains,
		[EnumMember(Value = "endswith")]
		EndsWith,
		[EnumMember(Value = "isblank")]
		IsBlank,
		[EnumMember(Value = "isnotblank")]
		IsNotBlank,
		[EnumMember(Value = "notcontains")]
		NotContains,
		[EnumMember(Value = "startswith")]
		StartsWith,
		[EnumMember(Value = "between")]
		Between
	}
}
