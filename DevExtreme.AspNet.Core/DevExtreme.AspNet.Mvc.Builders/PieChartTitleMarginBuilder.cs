namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the title.</summary>
	public class PieChartTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public PieChartTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
