using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FilterType
	{
		[EnumMember(Value = "exclude")]
		Exclude,
		[EnumMember(Value = "include")]
		Include
	}
}
