namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures hatching that applies when a user selects the series.</summary>
	public class ChartSeriesSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the direction of hatching lines.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
