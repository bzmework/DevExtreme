using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridEditRefreshMode
	{
		[EnumMember(Value = "full")]
		Full,
		[EnumMember(Value = "reshape")]
		Reshape,
		[EnumMember(Value = "repaint")]
		Repaint
	}
}
