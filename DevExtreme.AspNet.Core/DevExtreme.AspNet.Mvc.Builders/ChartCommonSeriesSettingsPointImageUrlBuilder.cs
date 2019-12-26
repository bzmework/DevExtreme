namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
	public class ChartCommonSeriesSettingsPointImageUrlBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder RangeMaxPoint(string value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder RangeMinPoint(string value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a maximum point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageUrlBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
