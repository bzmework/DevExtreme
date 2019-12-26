using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextEditorButtonLocation
	{
		[EnumMember(Value = "after")]
		After,
		[EnumMember(Value = "before")]
		Before
	}
}
