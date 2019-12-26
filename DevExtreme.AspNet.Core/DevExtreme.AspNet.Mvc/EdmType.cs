using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EdmType
	{
		[EnumMember(Value = "Guid")]
		Guid,
		[EnumMember(Value = "Int32")]
		Int32,
		[EnumMember(Value = "Int64")]
		Int64,
		[EnumMember(Value = "String")]
		String,
		[EnumMember(Value = "Boolean")]
		Boolean,
		[EnumMember(Value = "Single")]
		Single,
		[EnumMember(Value = "Decimal")]
		Decimal
	}
}
