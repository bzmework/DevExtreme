using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SchedulerViewType
	{
		[EnumMember(Value = "agenda")]
		Agenda,
		[EnumMember(Value = "day")]
		Day,
		[EnumMember(Value = "month")]
		Month,
		[EnumMember(Value = "timelineDay")]
		TimelineDay,
		[EnumMember(Value = "timelineMonth")]
		TimelineMonth,
		[EnumMember(Value = "timelineWeek")]
		TimelineWeek,
		[EnumMember(Value = "timelineWorkWeek")]
		TimelineWorkWeek,
		[EnumMember(Value = "week")]
		Week,
		[EnumMember(Value = "workWeek")]
		WorkWeek
	}
}
