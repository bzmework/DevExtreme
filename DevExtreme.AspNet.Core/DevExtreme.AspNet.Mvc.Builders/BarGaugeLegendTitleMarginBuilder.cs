namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the legend title.</summary>
	public class BarGaugeLegendTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeLegendTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public BarGaugeLegendTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
