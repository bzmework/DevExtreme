using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeMapLayoutAlgorithm
	{
		[EnumMember(Value = "sliceanddice")]
		SliceAndDice,
		[EnumMember(Value = "squarified")]
		Squarified,
		[EnumMember(Value = "strip")]
		Strip
	}
}
