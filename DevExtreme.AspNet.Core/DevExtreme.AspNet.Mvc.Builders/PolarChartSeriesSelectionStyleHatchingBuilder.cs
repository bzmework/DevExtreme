namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the hatching options to be applied when a series is selected.</summary>
	public class PolarChartSeriesSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how to apply hatching to highlight a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between hatching lines in pixels.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between hatching lines in pixels.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
