using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DiagramShapeType
	{
		[EnumMember(Value = "text")]
		Text,
		[EnumMember(Value = "rectangle")]
		Rectangle,
		[EnumMember(Value = "ellipse")]
		Ellipse,
		[EnumMember(Value = "cross")]
		Cross,
		[EnumMember(Value = "triangle")]
		Triangle,
		[EnumMember(Value = "diamond")]
		Diamond,
		[EnumMember(Value = "heart")]
		Heart,
		[EnumMember(Value = "pentagon")]
		Pentagon,
		[EnumMember(Value = "octagon")]
		Octagon,
		[EnumMember(Value = "star")]
		Star,
		[EnumMember(Value = "arrowLeft")]
		ArrowLeft,
		[EnumMember(Value = "arrowTop")]
		ArrowTop,
		[EnumMember(Value = "arrowRight")]
		ArrowRight,
		[EnumMember(Value = "arrowBottom")]
		ArrowBottom,
		[EnumMember(Value = "arrowNorthSouth")]
		ArrowNorthSouth,
		[EnumMember(Value = "arrowEastWest")]
		ArrowEastWest,
		[EnumMember(Value = "process")]
		Process,
		[EnumMember(Value = "decision")]
		Decision,
		[EnumMember(Value = "terminator")]
		Terminator,
		[EnumMember(Value = "predefinedProcess")]
		PredefinedProcess,
		[EnumMember(Value = "document")]
		Document,
		[EnumMember(Value = "multipleDocuments")]
		MultipleDocuments,
		[EnumMember(Value = "manualInput")]
		ManualInput,
		[EnumMember(Value = "preparation")]
		Preparation,
		[EnumMember(Value = "data")]
		Data,
		[EnumMember(Value = "database")]
		Database,
		[EnumMember(Value = "hardDisk")]
		HardDisk,
		[EnumMember(Value = "internalStorage")]
		InternalStorage,
		[EnumMember(Value = "paperTape")]
		PaperTape,
		[EnumMember(Value = "manualOperation")]
		ManualOperation,
		[EnumMember(Value = "delay")]
		Delay,
		[EnumMember(Value = "storedData")]
		StoredData,
		[EnumMember(Value = "display")]
		Display,
		[EnumMember(Value = "merge")]
		Merge,
		[EnumMember(Value = "or")]
		Or,
		[EnumMember(Value = "summingJunction")]
		SummingJunction,
		[EnumMember(Value = "verticalContainer")]
		VerticalContainer,
		[EnumMember(Value = "horizontalContainer")]
		HorizontalContainer,
		[EnumMember(Value = "cardWithImageOnLeft")]
		CardWithImageOnLeft,
		[EnumMember(Value = "cardWithImageOnTop")]
		CardWithImageOnTop,
		[EnumMember(Value = "cardWithImageOnRight")]
		CardWithImageOnRight
	}
}
