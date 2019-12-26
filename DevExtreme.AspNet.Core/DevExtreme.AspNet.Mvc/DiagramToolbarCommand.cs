using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramToolbarCommand
	{
		[EnumMember(Value = "separator")]
		Separator,
		[EnumMember(Value = "export")]
		Export,
		[EnumMember(Value = "undo")]
		Undo,
		[EnumMember(Value = "redo")]
		Redo,
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
		[EnumMember(Value = "fontName")]
		FontName,
		[EnumMember(Value = "fontSize")]
		FontSize,
		[EnumMember(Value = "bold")]
		Bold,
		[EnumMember(Value = "italic")]
		Italic,
		[EnumMember(Value = "underline")]
		Underline,
		[EnumMember(Value = "fontColor")]
		FontColor,
		[EnumMember(Value = "lineColor")]
		LineColor,
		[EnumMember(Value = "fillColor")]
		FillColor,
		[EnumMember(Value = "textAlignLeft")]
		TextAlignLeft,
		[EnumMember(Value = "textAlignCenter")]
		TextAlignCenter,
		[EnumMember(Value = "textAlignRight")]
		TextAlignRight,
		[EnumMember(Value = "lock")]
		Lock,
		[EnumMember(Value = "unlock")]
		Unlock,
		[EnumMember(Value = "sendToBack")]
		SendToBack,
		[EnumMember(Value = "bringToFront")]
		BringToFront,
		[EnumMember(Value = "insertShapeImage")]
		InsertShapeImage,
		[EnumMember(Value = "editShapeImage")]
		EditShapeImage,
		[EnumMember(Value = "deleteShapeImage")]
		DeleteShapeImage,
		[EnumMember(Value = "connectorLineType")]
		ConnectorLineType,
		[EnumMember(Value = "connectorLineStart")]
		ConnectorLineStart,
		[EnumMember(Value = "connectorLineEnd")]
		ConnectorLineEnd,
		[EnumMember(Value = "autoLayout")]
		AutoLayout,
		[EnumMember(Value = "fullScreen")]
		FullScreen
	}
}
