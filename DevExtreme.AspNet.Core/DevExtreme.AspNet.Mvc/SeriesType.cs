using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SeriesType
	{
		[EnumMember(Value = "area")]
		Area,
		[EnumMember(Value = "bar")]
		Bar,
		[EnumMember(Value = "bubble")]
		Bubble,
		[EnumMember(Value = "candlestick")]
		Candlestick,
		[EnumMember(Value = "fullstackedarea")]
		FullStackedArea,
		[EnumMember(Value = "fullstackedbar")]
		FullStackedBar,
		[EnumMember(Value = "fullstackedline")]
		FullStackedLine,
		[EnumMember(Value = "fullstackedspline")]
		FullStackedSpline,
		[EnumMember(Value = "fullstackedsplinearea")]
		FullStackedSplineArea,
		[EnumMember(Value = "line")]
		Line,
		[EnumMember(Value = "rangearea")]
		RangeArea,
		[EnumMember(Value = "rangebar")]
		RangeBar,
		[EnumMember(Value = "scatter")]
		Scatter,
		[EnumMember(Value = "spline")]
		Spline,
		[EnumMember(Value = "splinearea")]
		SplineArea,
		[EnumMember(Value = "stackedarea")]
		StackedArea,
		[EnumMember(Value = "stackedbar")]
		StackedBar,
		[EnumMember(Value = "stackedline")]
		StackedLine,
		[EnumMember(Value = "stackedspline")]
		StackedSpline,
		[EnumMember(Value = "stackedsplinearea")]
		StackedSplineArea,
		[EnumMember(Value = "steparea")]
		StepArea,
		[EnumMember(Value = "stepline")]
		StepLine,
		[EnumMember(Value = "stock")]
		Stock
	}
}
