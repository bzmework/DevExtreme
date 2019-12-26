namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines the texts of grouping-related visual elements.</summary>
	public class DataGridGroupingTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridGroupingTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that groups data by a specific column.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupByThisColumn(string value)
		{
			base.Options["groupByThisColumn"] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that groups data by a specific column.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupByThisColumn(JS value)
		{
			base.Options["groupByThisColumn"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed in a group row when the corresponding group is continued from the previous page.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupContinuedMessage(string value)
		{
			base.Options["groupContinuedMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed in a group row when the corresponding group is continued from the previous page.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupContinuedMessage(JS value)
		{
			base.Options["groupContinuedMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed in a group row when the corresponding group continues on the next page.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupContinuesMessage(string value)
		{
			base.Options["groupContinuesMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed in a group row when the corresponding group continues on the next page.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder GroupContinuesMessage(JS value)
		{
			base.Options["groupContinuesMessage"] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that clears grouping settings of a specific column.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder Ungroup(string value)
		{
			base.Options["ungroup"] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that clears grouping settings of a specific column.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder Ungroup(JS value)
		{
			base.Options["ungroup"] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that clears grouping settings of all columns.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder UngroupAll(string value)
		{
			base.Options["ungroupAll"] = value;
			return this;
		}

		/// <summary>Specifies the text of the context menu item that clears grouping settings of all columns.</summary>
		[Generated]
		public DataGridGroupingTextsBuilder UngroupAll(JS value)
		{
			base.Options["ungroupAll"] = value;
			return this;
		}
	}
}
