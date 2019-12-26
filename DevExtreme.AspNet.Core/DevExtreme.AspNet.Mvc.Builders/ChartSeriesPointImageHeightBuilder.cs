namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the height of the image used instead of a point marker.</summary>
	public class ChartSeriesPointImageHeightBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointImageHeightBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointImageHeightBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageHeightBuilder RangeMaxPoint(double value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageHeightBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageHeightBuilder RangeMinPoint(double value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageHeightBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
