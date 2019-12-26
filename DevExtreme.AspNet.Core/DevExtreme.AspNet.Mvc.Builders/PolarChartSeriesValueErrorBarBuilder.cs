namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures error bars.</summary>
	public class PolarChartSeriesValueErrorBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether error bars must be displayed in full or partially.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder DisplayMode(ValueErrorBarDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder EdgeLength(double value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder EdgeLength(JS value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for high error values.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for high error values.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder LineWidth(double value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder LineWidth(JS value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for low error values.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for low error values.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how error bar values must be calculated.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Type(ValueErrorBarType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public PolarChartSeriesValueErrorBarBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
