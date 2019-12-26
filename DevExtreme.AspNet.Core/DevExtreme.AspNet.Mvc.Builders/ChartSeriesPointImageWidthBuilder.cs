namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the width of an image that is used as a point marker.</summary>
	public class ChartSeriesPointImageWidthBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointImageWidthBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointImageWidthBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageWidthBuilder RangeMaxPoint(double value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the maximum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageWidthBuilder RangeMaxPoint(JS value)
		{
			base.Options["rangeMaxPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageWidthBuilder RangeMinPoint(double value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}

		/// <summary>Specifies the width of the image that represents the minimum point in a range area series.</summary>
		[Generated]
		public ChartSeriesPointImageWidthBuilder RangeMinPoint(JS value)
		{
			base.Options["rangeMinPoint"] = value;
			return this;
		}
	}
}
