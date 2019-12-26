namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the width of an image that is used as a point marker.</summary>
	public class ChartCommonSeriesSettingsPointImageWidthBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder RangeMaxPoint(double value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder RangeMinPoint(double value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageWidthBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
