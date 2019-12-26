using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SchedulerRecurrenceEditMode
	{
		[EnumMember(Value = "dialog")]
		Dialog,
		[EnumMember(Value = "occurrence")]
		Occurrence,
		[EnumMember(Value = "series")]
		Series
	}
}
