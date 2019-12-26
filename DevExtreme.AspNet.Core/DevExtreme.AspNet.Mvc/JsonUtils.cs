using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc
{
	internal static class JsonUtils
	{
		private class OurDateConverter : JsonConverter
		{
			public override bool CanConvert(Type objectType)
			{
				if (!(objectType == typeof(DateTime)))
				{
					return objectType == typeof(DateTime?);
				}
				return true;
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				throw new NotSupportedException();
			}

			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
				DateTime d = (DateTime)value;
				List<int> list = new List<int>(7)
				{
					d.Year,
					d.Month - 1,
					d.Day
				};
				if (d != d.Date)
				{
					list.Add(d.Hour);
					list.Add(d.Minute);
					list.Add(d.Second);
					list.Add(d.Millisecond);
				}
				writer.WriteRawValue("new Date(" + string.Join(", ", list) + ")");
			}
		}

		public static string SafeSerialize(object obj)
		{
			JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
			{
				StringEscapeHandling = StringEscapeHandling.EscapeHtml,
				Formatting = Compatibility.Rendering.JsonFormatting
			};
			if (Compatibility.Rendering.DateTimeSerializationMode == DateTimeSerializationMode.JavaScriptDate)
			{
				jsonSerializerSettings.Converters = new OurDateConverter[1]
				{
					new OurDateConverter()
				};
			}
			return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
		}
	}
}
