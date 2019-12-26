namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures error bars.</summary>
	public class ChartSeriesValueErrorBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesValueErrorBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of error bars.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether error bars must be displayed in full or partially.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder DisplayMode(ValueErrorBarDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder EdgeLength(double value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the lines that indicate error bar edges.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder EdgeLength(JS value)
		{
			base.Options["edgeLength"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides high error values.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder HighValueField(string value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides high error values.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder HighValueField(JS value)
		{
			base.Options["highValueField"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder LineWidth(double value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the error bar line.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder LineWidth(JS value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides low error values.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder LowValueField(string value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides low error values.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder LowValueField(JS value)
		{
			base.Options["lowValueField"] = value;
			return this;
		}

		/// <summary>Specifies how trasparent error bars should be.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how trasparent error bars should be.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how error bar values must be calculated.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Type(ValueErrorBarType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the value to be used for generating error bars.</summary>
		[Generated]
		public ChartSeriesValueErrorBarBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
