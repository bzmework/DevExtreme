using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DropDownEditorButtonName
	{
		[EnumMember(Value = "clear")]
		Clear,
		[EnumMember(Value = "dropDown")]
		DropDown
	}
}
