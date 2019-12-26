using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TreeViewDataStructure
	{
		[EnumMember(Value = "plain")]
		Plain,
		[EnumMember(Value = "tree")]
		Tree
	}
}
