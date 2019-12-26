using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizPalette
	{
		[EnumMember(Value = "Bright")]
		Bright,
		[EnumMember(Value = "Default")]
		[Obsolete("Use Material instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		Default,
		[EnumMember(Value = "Harmony Light")]
		HarmonyLight,
		[EnumMember(Value = "Ocean")]
		Ocean,
		[EnumMember(Value = "Pastel")]
		Pastel,
		[EnumMember(Value = "Soft")]
		Soft,
		[EnumMember(Value = "Soft Pastel")]
		SoftPastel,
		[EnumMember(Value = "Vintage")]
		Vintage,
		[EnumMember(Value = "Violet")]
		Violet,
		[EnumMember(Value = "Carmine")]
		Carmine,
		[EnumMember(Value = "Dark Moon")]
		DarkMoon,
		[EnumMember(Value = "Dark Violet")]
		DarkViolet,
		[EnumMember(Value = "Green Mist")]
		GreenMist,
		[EnumMember(Value = "Soft Blue")]
		SoftBlue,
		[EnumMember(Value = "Material")]
		Material,
		[EnumMember(Value = "Office")]
		Office
	}
}
