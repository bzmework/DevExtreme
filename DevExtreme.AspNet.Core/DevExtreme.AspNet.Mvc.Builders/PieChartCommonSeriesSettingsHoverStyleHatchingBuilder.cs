namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the hatching options to be applied when a point is hovered over.</summary>
	public class PieChartCommonSeriesSettingsHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how to apply hatching to highlight the hovered point.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
