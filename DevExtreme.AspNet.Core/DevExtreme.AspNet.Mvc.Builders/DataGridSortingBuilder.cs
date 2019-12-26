namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures runtime sorting.</summary>
	public class DataGridSortingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridSortingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSortingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that sets an ascending sort order in a column.</summary>
		[Generated]
		public DataGridSortingBuilder AscendingText(string value)
		{
			base.Options["ascendingText"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that sets an ascending sort order in a column.</summary>
		[Generated]
		public DataGridSortingBuilder AscendingText(JS value)
		{
			base.Options["ascendingText"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that clears sorting settings for a column.</summary>
		[Generated]
		public DataGridSortingBuilder ClearText(string value)
		{
			base.Options["clearText"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that clears sorting settings for a column.</summary>
		[Generated]
		public DataGridSortingBuilder ClearText(JS value)
		{
			base.Options["clearText"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that sets a descending sort order in a column.</summary>
		[Generated]
		public DataGridSortingBuilder DescendingText(string value)
		{
			base.Options["descendingText"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that sets a descending sort order in a column.</summary>
		[Generated]
		public DataGridSortingBuilder DescendingText(JS value)
		{
			base.Options["descendingText"] = value;
			return this;
		}

		/// <summary>Specifies the sorting mode.</summary>
		[Generated]
		public DataGridSortingBuilder Mode(GridSortingMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies whether to display sort indexes in column headers. Applies only when sorting.mode is "multiple" and data is sorted by two or more columns.</summary>
		[Generated]
		public DataGridSortingBuilder ShowSortIndexes(bool value)
		{
			base.Options["showSortIndexes"] = value;
			return this;
		}

		/// <summary>Specifies whether to display sort indexes in column headers. Applies only when sorting.mode is "multiple" and data is sorted by two or more columns.</summary>
		[Generated]
		public DataGridSortingBuilder ShowSortIndexes(JS value)
		{
			base.Options["showSortIndexes"] = value;
			return this;
		}
	}
}
