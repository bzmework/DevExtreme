namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the hatching options to be applied when a point is selected.</summary>
	public class PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how to apply hatching to highlight the selected point.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
