using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FileManagerItemViewMode
	{
		[EnumMember(Value = "details")]
		Details,
		[EnumMember(Value = "thumbnails")]
		Thumbnails
	}
}
