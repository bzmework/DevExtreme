namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
	public class PieChartLegendMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartLegendMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend's bottom margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend's bottom margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend's left margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend's left margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend's right margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend's right margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend's top margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend's top margin in pixels.</summary>
		[Generated]
		public PieChartLegendMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
