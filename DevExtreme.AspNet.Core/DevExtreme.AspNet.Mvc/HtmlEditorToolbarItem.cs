using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HtmlEditorToolbarItem
	{
		[EnumMember(Value = "background")]
		Background,
		[EnumMember(Value = "bold")]
		Bold,
		[EnumMember(Value = "color")]
		Color,
		[EnumMember(Value = "italic")]
		Italic,
		[EnumMember(Value = "link")]
		Link,
		[EnumMember(Value = "image")]
		Image,
		[EnumMember(Value = "strike")]
		Strike,
		[EnumMember(Value = "subscript")]
		Subscript,
		[EnumMember(Value = "superscript")]
		Superscript,
		[EnumMember(Value = "underline")]
		Underline,
		[EnumMember(Value = "blockquote")]
		Blockquote,
		[EnumMember(Value = "header")]
		Header,
		[EnumMember(Value = "increaseIndent")]
		IncreaseIndent,
		[EnumMember(Value = "decreaseIndent")]
		DecreaseIndent,
		[EnumMember(Value = "orderedList")]
		OrderedList,
		[EnumMember(Value = "bulletList")]
		BulletList,
		[EnumMember(Value = "alignLeft")]
		AlignLeft,
		[EnumMember(Value = "alignCenter")]
		AlignCenter,
		[EnumMember(Value = "alignRight")]
		AlignRight,
		[EnumMember(Value = "alignJustify")]
		AlignJustify,
		[EnumMember(Value = "codeBlock")]
		CodeBlock,
		[EnumMember(Value = "variable")]
		Variable,
		[EnumMember(Value = "separator")]
		Separator,
		[EnumMember(Value = "undo")]
		Undo,
		[EnumMember(Value = "redo")]
		Redo,
		[EnumMember(Value = "clear")]
		Clear
	}
}
