using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DateBoxPickerType
	{
		[EnumMember(Value = "calendar")]
		Calendar,
		[EnumMember(Value = "list")]
		List,
		[EnumMember(Value = "native")]
		Native,
		[EnumMember(Value = "rollers")]
		Rollers
	}
}
