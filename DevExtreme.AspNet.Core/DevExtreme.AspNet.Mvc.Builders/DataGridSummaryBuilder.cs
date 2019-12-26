using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the grid summary.</summary>
	public class DataGridSummaryBuilder<T> : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridSummaryBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a custom aggregate function. This function is called for summary items whose summaryType is "custom".</summary>
		[Generated]
		public DataGridSummaryBuilder<T> CalculateCustomSummary(string jsFunc)
		{
			AssignJS("calculateCustomSummary", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom aggregate function. This function is called for summary items whose summaryType is "custom".</summary>
		[Generated]
		public DataGridSummaryBuilder<T> CalculateCustomSummary(RazorBlock jsFunc)
		{
			return CalculateCustomSummary(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies items of the group summary.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> GroupItems(Action<CollectionFactory<DataGridSummaryGroupItemBuilder<T>>> configurator)
		{
			Collection("groupItems", configurator);
			return this;
		}

		/// <summary>Specifies whether to recalculate summaries while a user edits data.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> RecalculateWhileEditing(bool value)
		{
			base.Options["recalculateWhileEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether to recalculate summaries while a user edits data.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> RecalculateWhileEditing(JS value)
		{
			base.Options["recalculateWhileEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> SkipEmptyValues(bool value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> SkipEmptyValues(JS value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Contains options that specify text patterns for summary items.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> Texts(Action<DataGridSummaryTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies items of the total summary.</summary>
		[Generated]
		public DataGridSummaryBuilder<T> TotalItems(Action<CollectionFactory<DataGridSummaryTotalItemBuilder<T>>> configurator)
		{
			Collection("totalItems", configurator);
			return this;
		}
	}
}
