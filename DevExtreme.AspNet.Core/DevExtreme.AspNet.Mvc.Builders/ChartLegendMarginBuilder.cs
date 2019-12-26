namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
	public class ChartLegendMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartLegendMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartLegendMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend's bottom margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend's bottom margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend's left margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend's left margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend's right margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend's right margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend's top margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend's top margin in pixels.</summary>
		[Generated]
		public ChartLegendMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
