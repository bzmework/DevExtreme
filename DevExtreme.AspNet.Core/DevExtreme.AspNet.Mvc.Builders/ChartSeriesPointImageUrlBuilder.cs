namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
	public class ChartSeriesPointImageUrlBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointImageUrlBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointImageUrlBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartSeriesPointImageUrlBuilder RangeMaxPoint(string value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartSeriesPointImageUrlBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartSeriesPointImageUrlBuilder RangeMinPoint(string value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartSeriesPointImageUrlBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
