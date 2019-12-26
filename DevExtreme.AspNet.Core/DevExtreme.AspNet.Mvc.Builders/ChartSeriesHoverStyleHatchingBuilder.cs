namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures hatching that applies when a user points to the series.</summary>
	public class ChartSeriesHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the direction of hatching lines.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent hatching lines should be.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of hatching lines in pixels.</summary>
		[Generated]
		public ChartSeriesHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
