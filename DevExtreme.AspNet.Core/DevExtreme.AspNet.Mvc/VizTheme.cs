using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum VizTheme
	{
		[EnumMember(Value = "generic.dark")]
		GenericDark,
		[EnumMember(Value = "generic.light")]
		GenericLight,
		[EnumMember(Value = "generic.contrast")]
		GenericContrast,
		[EnumMember(Value = "ios7.default")]
		[Obsolete("Use GenericLight instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		IOS7Default,
		[EnumMember(Value = "generic.carmine")]
		GenericCarmine,
		[EnumMember(Value = "generic.darkmoon")]
		GenericDarkMoon,
		[EnumMember(Value = "generic.darkviolet")]
		GenericDarkViolet,
		[EnumMember(Value = "generic.greenmist")]
		GenericGreenMist,
		[EnumMember(Value = "generic.softblue")]
		GenericSoftBlue,
		[EnumMember(Value = "material.blue.light")]
		MaterialBlueLight,
		[EnumMember(Value = "material.lime.light")]
		MaterialLimeLight,
		[EnumMember(Value = "material.orange.light")]
		MaterialOrangeLight,
		[EnumMember(Value = "material.purple.light")]
		MaterialPurpleLight,
		[EnumMember(Value = "material.teal.light")]
		MaterialTealLight
	}
}
