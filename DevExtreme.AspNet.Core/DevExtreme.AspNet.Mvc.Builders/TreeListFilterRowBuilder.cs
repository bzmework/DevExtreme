using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the filter row.</summary>
	public class TreeListFilterRowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListFilterRowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListFilterRowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies when to apply a filter.</summary>
		[Generated]
		public TreeListFilterRowBuilder ApplyFilter(GridApplyFilterMode value)
		{
			base.Options["applyFilter"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on a button that applies the filter.</summary>
		[Generated]
		public TreeListFilterRowBuilder ApplyFilterText(string value)
		{
			base.Options["applyFilterText"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on a button that applies the filter.</summary>
		[Generated]
		public TreeListFilterRowBuilder ApplyFilterText(JS value)
		{
			base.Options["applyFilterText"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the editor that specifies the end of a range when a user selects the "between" filter operation.</summary>
		[Generated]
		public TreeListFilterRowBuilder BetweenEndText(string value)
		{
			base.Options["betweenEndText"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the editor that specifies the end of a range when a user selects the "between" filter operation.</summary>
		[Generated]
		public TreeListFilterRowBuilder BetweenEndText(JS value)
		{
			base.Options["betweenEndText"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the editor that specifies the start of a range when a user selects the "between" filter operation.</summary>
		[Generated]
		public TreeListFilterRowBuilder BetweenStartText(string value)
		{
			base.Options["betweenStartText"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the editor that specifies the start of a range when a user selects the "between" filter operation.</summary>
		[Generated]
		public TreeListFilterRowBuilder BetweenStartText(JS value)
		{
			base.Options["betweenStartText"] = value;
			return this;
		}

		/// <summary>Specifies descriptions for filter operations on the filter list.</summary>
		[Generated]
		public TreeListFilterRowBuilder OperationDescriptions(Action<TreeListFilterRowOperationDescriptionsBuilder> configurator)
		{
			NestedOptions("operationDescriptions", configurator);
			return this;
		}

		/// <summary>Specifies text for the reset operation on the filter list.</summary>
		[Generated]
		public TreeListFilterRowBuilder ResetOperationText(string value)
		{
			base.Options["resetOperationText"] = value;
			return this;
		}

		/// <summary>Specifies text for the reset operation on the filter list.</summary>
		[Generated]
		public TreeListFilterRowBuilder ResetOperationText(JS value)
		{
			base.Options["resetOperationText"] = value;
			return this;
		}

		/// <summary>Specifies text for the item that clears the applied filter. Used only when a cell of the filter row contains a select box.</summary>
		[Generated]
		public TreeListFilterRowBuilder ShowAllText(string value)
		{
			base.Options["showAllText"] = value;
			return this;
		}

		/// <summary>Specifies text for the item that clears the applied filter. Used only when a cell of the filter row contains a select box.</summary>
		[Generated]
		public TreeListFilterRowBuilder ShowAllText(JS value)
		{
			base.Options["showAllText"] = value;
			return this;
		}

		/// <summary>Specifies whether icons that open the filter lists are visible.</summary>
		[Generated]
		public TreeListFilterRowBuilder ShowOperationChooser(bool value)
		{
			base.Options["showOperationChooser"] = value;
			return this;
		}

		/// <summary>Specifies whether icons that open the filter lists are visible.</summary>
		[Generated]
		public TreeListFilterRowBuilder ShowOperationChooser(JS value)
		{
			base.Options["showOperationChooser"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter row is visible.</summary>
		[Generated]
		public TreeListFilterRowBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter row is visible.</summary>
		[Generated]
		public TreeListFilterRowBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
