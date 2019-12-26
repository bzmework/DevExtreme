namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the widget.</summary>
	public class ChartMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public ChartMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
