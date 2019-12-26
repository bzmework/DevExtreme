using Newtonsoft.Json;

namespace DevExtreme.AspNet.Mvc
{
	[JsonConverter(typeof(JSConverter))]
	public struct JS
	{
		public static readonly JS Undefined = new JS("undefined");

		public readonly string Value;

		public JS(string value)
		{
			Value = value;
		}

		public override string ToString()
		{
			return Value?.ToString();
		}
	}
}
