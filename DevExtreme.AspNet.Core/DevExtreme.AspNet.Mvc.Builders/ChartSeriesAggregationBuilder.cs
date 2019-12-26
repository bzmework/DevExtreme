namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures data aggregation for the series.</summary>
	public class ChartSeriesAggregationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesAggregationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a custom aggregate function. Applies only if the aggregation method is "custom".</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Calculate(string jsFunc)
		{
			AssignJS("calculate", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom aggregate function. Applies only if the aggregation method is "custom".</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Calculate(RazorBlock jsFunc)
		{
			return Calculate(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables data aggregation for the series.</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables data aggregation for the series.</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate series points.</summary>
		[Generated]
		public ChartSeriesAggregationBuilder Method(ChartSeriesAggregationMethod value)
		{
			base.Options["method"] = value;
			return this;
		}
	}
}
