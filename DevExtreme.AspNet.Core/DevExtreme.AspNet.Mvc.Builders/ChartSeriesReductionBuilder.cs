namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies reduction options for financial series.</summary>
	public class ChartSeriesReductionBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesReductionBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesReductionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the points whose price has decreased in comparison to the price of the previous point.</summary>
		[Generated]
		public ChartSeriesReductionBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the points whose price has decreased in comparison to the price of the previous point.</summary>
		[Generated]
		public ChartSeriesReductionBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether high, low, open or close prices of points should be compared.</summary>
		[Generated]
		public ChartSeriesReductionBuilder Level(FinancialChartReductionLevel value)
		{
			base.Options["level"] = value;
			return this;
		}
	}
}
