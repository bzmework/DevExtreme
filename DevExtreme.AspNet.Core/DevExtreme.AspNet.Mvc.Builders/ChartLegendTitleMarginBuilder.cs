namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the legend title.</summary>
	public class ChartLegendTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartLegendTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public ChartLegendTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
