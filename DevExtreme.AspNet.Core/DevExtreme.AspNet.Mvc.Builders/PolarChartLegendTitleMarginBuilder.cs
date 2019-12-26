namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the legend title.</summary>
	public class PolarChartLegendTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartLegendTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public PolarChartLegendTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
