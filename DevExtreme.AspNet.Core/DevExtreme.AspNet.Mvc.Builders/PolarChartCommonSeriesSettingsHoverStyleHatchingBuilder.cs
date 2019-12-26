namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the hatching options to be applied when a series is hovered over.</summary>
	public class PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how to apply hatching to highlight the hovered series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between hatching lines in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between hatching lines in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
