namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Formats values.</summary>
	public class FormatBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FormatBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormatBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a 3-letter ISO 4217 code for currency. Applies only if the type is "currency".</summary>
		[Generated]
		public FormatBuilder Currency(string value)
		{
			base.Options["currency"] = value;
			return this;
		}

		/// <summary>Specifies a 3-letter ISO 4217 code for currency. Applies only if the type is "currency".</summary>
		[Generated]
		public FormatBuilder Currency(JS value)
		{
			base.Options["currency"] = value;
			return this;
		}

		/// <summary>A function that converts numeric or date-time values to a string.</summary>
		[Generated]
		public FormatBuilder Formatter(string jsFunc)
		{
			AssignJS("formatter", jsFunc);
			return this;
		}

		/// <summary>A function that converts numeric or date-time values to a string.</summary>
		[Generated]
		public FormatBuilder Formatter(RazorBlock jsFunc)
		{
			return Formatter(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Parses string values into numeric or date-time values. Can be used with formatter or one of the predefined formats.</summary>
		[Generated]
		public FormatBuilder Parser(string jsFunc)
		{
			AssignJS("parser", jsFunc);
			return this;
		}

		/// <summary>Parses string values into numeric or date-time values. Can be used with formatter or one of the predefined formats.</summary>
		[Generated]
		public FormatBuilder Parser(RazorBlock jsFunc)
		{
			return Parser(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a precision for values of a numeric format.</summary>
		[Generated]
		public FormatBuilder Precision(double value)
		{
			base.Options["precision"] = value;
			return this;
		}

		/// <summary>Specifies a precision for values of a numeric format.</summary>
		[Generated]
		public FormatBuilder Precision(JS value)
		{
			base.Options["precision"] = value;
			return this;
		}

		/// <summary>Specifies a predefined format. Does not apply if you have specified the formatter function.</summary>
		[Generated]
		public FormatBuilder Type(Format value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
