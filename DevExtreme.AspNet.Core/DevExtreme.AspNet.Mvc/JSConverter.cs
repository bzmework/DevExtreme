using Newtonsoft.Json;
using System;

namespace DevExtreme.AspNet.Mvc
{
	internal class JSConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(JS);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			throw new NotSupportedException();
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteRawValue(((JS)value).Value);
		}
	}
}
