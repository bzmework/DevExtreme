using Newtonsoft.Json;

namespace DevExtreme.AspNet.Mvc
{
	public static class Compatibility
	{
		public class DataSourceFlags
		{
			public bool UseLegacyRouting
			{
				get;
				set;
			}
		}

		public class ValidationFlags
		{
			public bool IgnoreRequiredForBoolean
			{
				get;
				set;
			}
		}

		public class RenderingFlags
		{
			public bool UseJQueryReady
			{
				get;
				set;
			}

			public DateTimeSerializationMode DateTimeSerializationMode
			{
				get;
				set;
			}

			public Formatting JsonFormatting
			{
				get;
				set;
			}
		}

		private const Formatting DEFAULT_JSON_FORMATTING = Formatting.None;

		public static DataSourceFlags DataSource
		{
			get;
		} = new DataSourceFlags
		{
			UseLegacyRouting = false
		};


		public static ValidationFlags Validation
		{
			get;
		} = new ValidationFlags
		{
			IgnoreRequiredForBoolean = true
		};


		public static RenderingFlags Rendering
		{
			get;
		} = new RenderingFlags
		{
			UseJQueryReady = false,
			DateTimeSerializationMode = DateTimeSerializationMode.JavaScriptDate,
			JsonFormatting = Formatting.None
		};

	}
}
