using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridColumnChooserMode
	{
		[EnumMember(Value = "dragAndDrop")]
		DragAndDrop,
		[EnumMember(Value = "select")]
		Select
	}
}
