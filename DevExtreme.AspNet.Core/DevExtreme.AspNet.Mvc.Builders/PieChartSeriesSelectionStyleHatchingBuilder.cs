namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the hatching options to be applied when a point is selected.</summary>
	public class PieChartSeriesSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies how to apply hatching to highlight the selected point.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of hatching lines.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two hatching lines in pixels.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
