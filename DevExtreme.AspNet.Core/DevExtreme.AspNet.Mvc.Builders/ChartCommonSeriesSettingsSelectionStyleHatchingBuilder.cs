namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures hatching that applies when a user selects the series.</summary>
	public class ChartCommonSeriesSettingsSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the direction of hatching lines.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
