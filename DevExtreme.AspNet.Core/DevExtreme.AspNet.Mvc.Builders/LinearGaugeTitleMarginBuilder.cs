namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Generates space around the title.</summary>
	public class LinearGaugeTitleMarginBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeTitleMarginBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Bottom(double value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the bottom margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the left margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the right margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Top(double value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Specifies the top margin of the title.</summary>
		[Generated]
		public LinearGaugeTitleMarginBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}
	}
}
