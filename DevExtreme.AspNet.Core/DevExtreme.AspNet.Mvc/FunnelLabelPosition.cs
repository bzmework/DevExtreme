using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FunnelLabelPosition
	{
		[EnumMember(Value = "columns")]
		Columns,
		[EnumMember(Value = "inside")]
		Inside,
		[EnumMember(Value = "outside")]
		Outside
	}
}
