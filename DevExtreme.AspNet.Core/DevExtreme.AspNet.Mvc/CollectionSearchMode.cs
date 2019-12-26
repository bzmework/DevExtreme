using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CollectionSearchMode
	{
		[EnumMember(Value = "contains")]
		Contains,
		[EnumMember(Value = "startswith")]
		StartsWith,
		[EnumMember(Value = "equals")]
		Equals
	}
}
