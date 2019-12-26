namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies reduction options for financial series.</summary>
	public class ChartCommonSeriesSettingsReductionBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsReductionBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsReductionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the points whose price has decreased in comparison to the price of the previous point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsReductionBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the points whose price has decreased in comparison to the price of the previous point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsReductionBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether high, low, open or close prices of points should be compared.</summary>
		[Generated]
		public ChartCommonSeriesSettingsReductionBuilder Level(FinancialChartReductionLevel value)
		{
			base.Options["level"] = value;
			return this;
		}
	}
}
