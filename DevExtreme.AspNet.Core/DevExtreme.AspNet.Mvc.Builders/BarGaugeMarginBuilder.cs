namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the widget.</summary>
	public class BarGaugeMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public BarGaugeMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
