namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures error bars.</summary>
	public class ChartCommonSeriesSettingsValueErrorBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether error bars must be displayed in full or partially.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder DisplayMode(ValueErrorBarDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder EdgeLength(double value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder EdgeLength(JS value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides high error values.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides high error values.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder LineWidth(double value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder LineWidth(JS value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides low error values.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides low error values.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies how trasparent error bars should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how trasparent error bars should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how error bar values must be calculated.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Type(ValueErrorBarType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public ChartCommonSeriesSettingsValueErrorBarBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
