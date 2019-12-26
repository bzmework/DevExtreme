namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the height of the image used instead of a point marker.</summary>
	public class ChartCommonSeriesSettingsPointImageHeightBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder RangeMaxPoint(double value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder RangeMinPoint(double value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageHeightBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
