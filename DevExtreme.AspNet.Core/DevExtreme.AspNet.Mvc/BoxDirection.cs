using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BoxDirection
	{
		[EnumMember(Value = "col")]
		Col,
		[EnumMember(Value = "row")]
		Row
	}
}
