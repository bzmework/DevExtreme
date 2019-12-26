using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeListFilterMode
	{
		[EnumMember(Value = "fullBranch")]
		FullBranch,
		[EnumMember(Value = "withAncestors")]
		WithAncestors,
		[EnumMember(Value = "matchOnly")]
		MatchOnly
	}
}
