namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the legend title.</summary>
	public class FunnelLegendTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLegendTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public FunnelLegendTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
