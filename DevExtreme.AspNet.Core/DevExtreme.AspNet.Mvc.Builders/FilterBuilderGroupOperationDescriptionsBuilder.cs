namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies group operation descriptions.</summary>
	public class FilterBuilderGroupOperationDescriptionsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The "and" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder And(string value)
		{
			base.Options["and"] = value;
			return this;
		}

		/// <summary>The "and" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder And(JS value)
		{
			base.Options["and"] = value;
			return this;
		}

		/// <summary>The "notand" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder NotAnd(string value)
		{
			base.Options["notAnd"] = value;
			return this;
		}

		/// <summary>The "notand" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder NotAnd(JS value)
		{
			base.Options["notAnd"] = value;
			return this;
		}

		/// <summary>The "notor" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder NotOr(string value)
		{
			base.Options["notOr"] = value;
			return this;
		}

		/// <summary>The "notor" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder NotOr(JS value)
		{
			base.Options["notOr"] = value;
			return this;
		}

		/// <summary>The "or" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder Or(string value)
		{
			base.Options["or"] = value;
			return this;
		}

		/// <summary>The "or" operation's description.</summary>
		[Generated]
		public FilterBuilderGroupOperationDescriptionsBuilder Or(JS value)
		{
			base.Options["or"] = value;
			return this;
		}
	}
}
