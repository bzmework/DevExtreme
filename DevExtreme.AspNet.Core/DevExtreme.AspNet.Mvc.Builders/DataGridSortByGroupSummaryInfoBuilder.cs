namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Allows you to sort groups according to the values of group summary items.</summary>
	public class DataGridSortByGroupSummaryInfoBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column that must be used in grouping so that sorting by group summary item values be applied.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder GroupColumn(string value)
		{
			base.Options["groupColumn"] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column that must be used in grouping so that sorting by group summary item values be applied.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder GroupColumn(JS value)
		{
			base.Options["groupColumn"] = value;
			return this;
		}

		/// <summary>Specifies the sort order of group summary item values.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder SortOrder(SortOrder value)
		{
			base.Options["sortOrder"] = value;
			return this;
		}

		/// <summary>Specifies the group summary item whose values must be used to sort groups.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder SummaryItem(string value)
		{
			base.Options["summaryItem"] = value;
			return this;
		}

		/// <summary>Specifies the group summary item whose values must be used to sort groups.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder SummaryItem(int value)
		{
			base.Options["summaryItem"] = value;
			return this;
		}

		/// <summary>Specifies the group summary item whose values must be used to sort groups.</summary>
		[Generated]
		public DataGridSortByGroupSummaryInfoBuilder SummaryItem(JS value)
		{
			base.Options["summaryItem"] = value;
			return this;
		}
	}
}
