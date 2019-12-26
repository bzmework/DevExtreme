using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeListDataStructure
	{
		[EnumMember(Value = "plain")]
		Plain,
		[EnumMember(Value = "tree")]
		Tree
	}
}
