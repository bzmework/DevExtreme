namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures paging.</summary>
	public class DataGridPagingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridPagingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridPagingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables paging.</summary>
		[Generated]
		public DataGridPagingBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables paging.</summary>
		[Generated]
		public DataGridPagingBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the page to be displayed using a zero-based index.</summary>
		[Generated]
		public DataGridPagingBuilder PageIndex(int value)
		{
			base.Options["pageIndex"] = value;
			return this;
		}

		/// <summary>Specifies the page to be displayed using a zero-based index.</summary>
		[Generated]
		public DataGridPagingBuilder PageIndex(JS value)
		{
			base.Options["pageIndex"] = value;
			return this;
		}

		/// <summary>Specifies the page size.</summary>
		[Generated]
		public DataGridPagingBuilder PageSize(int value)
		{
			base.Options["pageSize"] = value;
			return this;
		}

		/// <summary>Specifies the page size.</summary>
		[Generated]
		public DataGridPagingBuilder PageSize(JS value)
		{
			base.Options["pageSize"] = value;
			return this;
		}
	}
}
