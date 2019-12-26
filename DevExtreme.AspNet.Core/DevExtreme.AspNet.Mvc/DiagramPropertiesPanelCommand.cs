using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramPropertiesPanelCommand
	{
		[EnumMember(Value = "zoomLevel")]
		ZoomLevel,
		[EnumMember(Value = "autoZoom")]
		AutoZoom,
		[EnumMember(Value = "showGrid")]
		ShowGrid,
		[EnumMember(Value = "snapToGrid")]
		SnapToGrid,
		[EnumMember(Value = "gridSize")]
		GridSize,
		[EnumMember(Value = "units")]
		Units,
		[EnumMember(Value = "pageSize")]
		PageSize,
		[EnumMember(Value = "pageOrientation")]
		PageOrientation,
		[EnumMember(Value = "pageColor")]
		PageColor
	}
}
