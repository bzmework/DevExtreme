using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PivotGridRowHeadersLayout
	{
		[EnumMember(Value = "standard")]
		Standard,
		[EnumMember(Value = "tree")]
		Tree
	}
}
