namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the chart value axis.</summary>
	public class RangeSelectorChartValueAxisBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorChartValueAxisBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Indicates whether or not the chart's value axis must be inverted.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the chart's value axis must be inverted.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder LogarithmBase(double value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the value to be raised to a power when generating ticks for a logarithmic value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder LogarithmBase(JS value)
		{
			base.Options["logarithmBase"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value of the chart's value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value of the chart's value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value of the chart's value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value of the chart's value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the type of the value axis.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder Type(RangeSelectorChartAxisScaleType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the desired type of axis values.</summary>
		[Generated]
		public RangeSelectorChartValueAxisBuilder ValueType(ChartDataType value)
		{
			base.Options["valueType"] = value;
			return this;
		}
	}
}
