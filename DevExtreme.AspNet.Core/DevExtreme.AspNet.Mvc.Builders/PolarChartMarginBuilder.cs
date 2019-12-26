namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the widget.</summary>
	public class PolarChartMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public PolarChartMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
