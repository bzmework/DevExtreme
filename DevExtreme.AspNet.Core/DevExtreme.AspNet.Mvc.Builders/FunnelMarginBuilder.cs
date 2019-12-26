namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the widget.</summary>
	public class FunnelMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the widget in pixels.</summary>
		[Generated]
		public FunnelMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
