using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GridColumnButtonName
	{
		[EnumMember(Value = "cancel")]
		Cancel,
		[EnumMember(Value = "delete")]
		Delete,
		[EnumMember(Value = "edit")]
		Edit,
		[EnumMember(Value = "save")]
		Save,
		[EnumMember(Value = "undelete")]
		Undelete
	}
}
