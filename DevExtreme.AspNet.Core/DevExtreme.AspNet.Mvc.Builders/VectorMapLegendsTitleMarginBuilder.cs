namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the legend title.</summary>
	public class VectorMapLegendsTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapLegendsTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's bottom margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's left margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's right margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's top margin.</summary>
		[Generated]
		public VectorMapLegendsTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
