namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the widget.</summary>
	public class SankeyMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public SankeyMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
