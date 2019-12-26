using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridGroupingExpandMode
	{
		[EnumMember(Value = "buttonClick")]
		ButtonClick,
		[EnumMember(Value = "rowClick")]
		RowClick
	}
}
