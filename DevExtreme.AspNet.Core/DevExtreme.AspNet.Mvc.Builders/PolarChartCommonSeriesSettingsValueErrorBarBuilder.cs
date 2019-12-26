namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures error bars.</summary>
	public class PolarChartCommonSeriesSettingsValueErrorBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether error bars must be displayed in full or partially.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder DisplayMode(ValueErrorBarDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder EdgeLength(double value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder EdgeLength(JS value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for high error values.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for high error values.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder LineWidth(double value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder LineWidth(JS value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for low error values.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies the data field that provides data for low error values.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how error bar values must be calculated.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Type(ValueErrorBarType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsValueErrorBarBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
