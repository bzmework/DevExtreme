using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ColumnResizingMode
	{
		[EnumMember(Value = "nextColumn")]
		NextColumn,
		[EnumMember(Value = "widget")]
		Widget
	}
}
