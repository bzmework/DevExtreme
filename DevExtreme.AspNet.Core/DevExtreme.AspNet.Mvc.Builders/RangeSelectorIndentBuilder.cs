namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Range selector's indent options.</summary>
	public class RangeSelectorIndentBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorIndentBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorIndentBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies range selector's left indent.</summary>
		[Generated]
		public RangeSelectorIndentBuilder Left(double value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies range selector's left indent.</summary>
		[Generated]
		public RangeSelectorIndentBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies range selector's right indent.</summary>
		[Generated]
		public RangeSelectorIndentBuilder Right(double value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Specifies range selector's right indent.</summary>
		[Generated]
		public RangeSelectorIndentBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}
	}
}
