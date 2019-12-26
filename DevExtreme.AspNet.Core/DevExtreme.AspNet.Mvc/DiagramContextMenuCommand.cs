using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramContextMenuCommand
	{
		[EnumMember(Value = "cut")]
		Cut,
		[EnumMember(Value = "copy")]
		Copy,
		[EnumMember(Value = "paste")]
		Paste,
		[EnumMember(Value = "selectAll")]
		SelectAll,
		[EnumMember(Value = "delete")]
		Delete,
		[EnumMember(Value = "bringToFront")]
		BringToFront,
		[EnumMember(Value = "sendToBack")]
		SendToBack,
		[EnumMember(Value = "lock")]
		Lock,
		[EnumMember(Value = "unlock")]
		Unlock,
		[EnumMember(Value = "insertShapeImage")]
		InsertShapeImage,
		[EnumMember(Value = "editShapeImage")]
		EditShapeImage,
		[EnumMember(Value = "deleteShapeImage")]
		DeleteShapeImage
	}
}
