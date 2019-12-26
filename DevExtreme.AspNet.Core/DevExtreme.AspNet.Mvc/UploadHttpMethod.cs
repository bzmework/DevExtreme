using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UploadHttpMethod
	{
		[EnumMember(Value = "POST")]
		POST,
		[EnumMember(Value = "PUT")]
		PUT
	}
}
