using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DataSourceLoadMode
	{
		[EnumMember(Value = "processed")]
		Processed,
		[EnumMember(Value = "raw")]
		Raw
	}
}
