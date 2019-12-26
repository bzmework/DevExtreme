namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies chart segment grouping options.</summary>
	public class PieChartSeriesSmallValuesGroupingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the name of the grouped chart segment. This name represents the segment in the chart legend.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder GroupName(string value)
		{
			base.Options["groupName"] = value;
			return this;
		}

		/// <summary>Specifies the name of the grouped chart segment. This name represents the segment in the chart legend.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder GroupName(JS value)
		{
			base.Options["groupName"] = value;
			return this;
		}

		/// <summary>Specifies the segment grouping mode.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder Mode(SmallValuesGroupingMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies a threshold for segment values.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder Threshold(double value)
		{
			base.Options["threshold"] = value;
			return this;
		}

		/// <summary>Specifies a threshold for segment values.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder Threshold(JS value)
		{
			base.Options["threshold"] = value;
			return this;
		}

		/// <summary>Specifies how many segments must not be grouped.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder TopCount(int value)
		{
			base.Options["topCount"] = value;
			return this;
		}

		/// <summary>Specifies how many segments must not be grouped.</summary>
		[Generated]
		public PieChartSeriesSmallValuesGroupingBuilder TopCount(JS value)
		{
			base.Options["topCount"] = value;
			return this;
		}
	}
}
