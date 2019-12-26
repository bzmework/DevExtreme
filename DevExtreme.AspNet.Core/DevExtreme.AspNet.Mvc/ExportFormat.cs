using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ExportFormat
	{
		[EnumMember(Value = "GIF")]
		GIF,
		[EnumMember(Value = "JPEG")]
		JPEG,
		[EnumMember(Value = "PDF")]
		PDF,
		[EnumMember(Value = "PNG")]
		PNG,
		[EnumMember(Value = "SVG")]
		SVG
	}
}
