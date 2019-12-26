using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SparklineType
	{
		[EnumMember(Value = "area")]
		Area,
		[EnumMember(Value = "bar")]
		Bar,
		[EnumMember(Value = "line")]
		Line,
		[EnumMember(Value = "spline")]
		Spline,
		[EnumMember(Value = "splinearea")]
		SplineArea,
		[EnumMember(Value = "steparea")]
		StepArea,
		[EnumMember(Value = "stepline")]
		StepLine,
		[EnumMember(Value = "winloss")]
		WinLoss
	}
}
