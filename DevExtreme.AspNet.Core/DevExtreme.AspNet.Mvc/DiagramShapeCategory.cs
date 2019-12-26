using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramShapeCategory
	{
		[EnumMember(Value = "general")]
		General,
		[EnumMember(Value = "flowchart")]
		Flowchart,
		[EnumMember(Value = "orgChart")]
		OrgChart,
		[EnumMember(Value = "containers")]
		Containers,
		[EnumMember(Value = "custom")]
		Custom
	}
}
