namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures paging.</summary>
	public class TreeListPagingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListPagingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListPagingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables paging.</summary>
		[Generated]
		public TreeListPagingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables paging.</summary>
		[Generated]
		public TreeListPagingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the page to be displayed using a zero-based index.</summary>
		[Generated]
		public TreeListPagingBuilder PageIndex(int value)
		{
			base.Options["pageIndex"] = value;
			return this;
		}

		/// <summary>Specifies the page to be displayed using a zero-based index.</summary>
		[Generated]
		public TreeListPagingBuilder PageIndex(JS value)
		{
			base.Options["pageIndex"] = value;
			return this;
		}

		/// <summary>Specifies the page size.</summary>
		[Generated]
		public TreeListPagingBuilder PageSize(int value)
		{
			base.Options["pageSize"] = value;
			return this;
		}

		/// <summary>Specifies the page size.</summary>
		[Generated]
		public TreeListPagingBuilder PageSize(JS value)
		{
			base.Options["pageSize"] = value;
			return this;
		}
	}
}
