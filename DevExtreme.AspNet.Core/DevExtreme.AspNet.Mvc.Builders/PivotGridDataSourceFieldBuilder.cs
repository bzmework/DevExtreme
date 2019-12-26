using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures pivot grid fields.</summary>
	public class PivotGridDataSourceFieldBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PivotGridDataSourceFieldBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to take neighboring groups' summary values into account when calculating a running total and absolute or percent variation.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowCrossGroupCalculation(bool value)
		{
			base.Options["allowCrossGroupCalculation"] = value;
			return this;
		}

		/// <summary>Specifies whether to take neighboring groups' summary values into account when calculating a running total and absolute or percent variation.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowCrossGroupCalculation(JS value)
		{
			base.Options["allowCrossGroupCalculation"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can expand/collapse all items within the same column or row header level using the context menu.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowExpandAll(bool value)
		{
			base.Options["allowExpandAll"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can expand/collapse all items within the same column or row header level using the context menu.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowExpandAll(JS value)
		{
			base.Options["allowExpandAll"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can filter the field's values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowFiltering(bool value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can filter the field's values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowFiltering(JS value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can change the field's sorting.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowSorting(bool value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can change the field's sorting.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowSorting(JS value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort the pivot grid by summary values instead of field values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowSortingBySummary(bool value)
		{
			base.Options["allowSortingBySummary"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort the pivot grid by summary values instead of field values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AllowSortingBySummary(JS value)
		{
			base.Options["allowSortingBySummary"] = value;
			return this;
		}

		/// <summary>Specifies the field's area.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Area(PivotGridArea value)
		{
			base.Options["area"] = value;
			return this;
		}

		/// <summary>Specifies the field's order among the other fields in the same area. Corresponds to the field's order in the fields array by default.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AreaIndex(int value)
		{
			base.Options["areaIndex"] = value;
			return this;
		}

		/// <summary>Specifies the field's order among the other fields in the same area. Corresponds to the field's order in the fields array by default.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> AreaIndex(JS value)
		{
			base.Options["areaIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom aggregate function. Applies only if the summaryType is "custom" and the remoteOperations is false. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CalculateCustomSummary(string jsFunc)
		{
			AssignJS("calculateCustomSummary", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom aggregate function. Applies only if the summaryType is "custom" and the remoteOperations is false. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CalculateCustomSummary(RazorBlock jsFunc)
		{
			return CalculateCustomSummary(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a custom post-processing function for summary values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CalculateSummaryValue(string jsFunc)
		{
			AssignJS("calculateSummaryValue", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom post-processing function for summary values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CalculateSummaryValue(RazorBlock jsFunc)
		{
			return CalculateSummaryValue(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the field's caption to be displayed in the field chooser and on the field panel.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies the field's caption to be displayed in the field chooser and on the field panel.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed in summary cells.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed in summary cells.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies which data source field provides data for the pivot grid field.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides data for the pivot grid field.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Casts field values to a specific data type.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> DataType(PivotGridDataType value)
		{
			base.Options["dataType"] = value;
			return this;
		}

		/// <summary>Specifies the name of the folder in which the field is located when displayed in the field chooser.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> DisplayFolder(string value)
		{
			base.Options["displayFolder"] = value;
			return this;
		}

		/// <summary>Specifies the name of the folder in which the field is located when displayed in the field chooser.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> DisplayFolder(JS value)
		{
			base.Options["displayFolder"] = value;
			return this;
		}

		/// <summary>Specifies whether to expand all items within the field's header level.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Expanded(bool value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Specifies whether to expand all items within the field's header level.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Expanded(JS value)
		{
			base.Options["expanded"] = value;
			return this;
		}

		/// <summary>Specifies whether a user changes the current filter by including (selecting) or excluding (clearing the selection of) values.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> FilterType(FilterType value)
		{
			base.Options["filterType"] = value;
			return this;
		}

		/// <summary>Specifies the values by which the field is filtered.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> FilterValues(IEnumerable value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Specifies the values by which the field is filtered.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> FilterValues(JS value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Formats field values before they are displayed.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats field values before they are displayed.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats field values before they are displayed.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats field values before they are displayed.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the field's index within its group.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupIndex(int value)
		{
			base.Options["groupIndex"] = value;
			return this;
		}

		/// <summary>Specifies the field's index within its group.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupIndex(JS value)
		{
			base.Options["groupIndex"] = value;
			return this;
		}

		/// <summary>Specifies how the field's values are combined into groups for the headers. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupInterval(PivotGridGroupInterval value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the field's values are combined into groups for the headers. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupInterval(double value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies how the field's values are combined into groups for the headers. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupInterval(JS value)
		{
			base.Options["groupInterval"] = value;
			return this;
		}

		/// <summary>Specifies the name of the field's group.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupName(string value)
		{
			base.Options["groupName"] = value;
			return this;
		}

		/// <summary>Specifies the name of the field's group.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> GroupName(JS value)
		{
			base.Options["groupName"] = value;
			return this;
		}

		/// <summary>Configures the field's header filter.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> HeaderFilter(Action<PivotGridDataSourceFieldsHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies whether the field should be treated as a measure (a field providing data for calculation).</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> IsMeasure(bool value)
		{
			base.Options["isMeasure"] = value;
			return this;
		}

		/// <summary>Specifies whether the field should be treated as a measure (a field providing data for calculation).</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> IsMeasure(JS value)
		{
			base.Options["isMeasure"] = value;
			return this;
		}

		/// <summary>Specifies the field's identifier.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the field's identifier.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies whether to calculate the running total by rows or by columns.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> RunningTotal(PivotGridRunningTotalMode value)
		{
			base.Options["runningTotal"] = value;
			return this;
		}

		/// <summary>Specifies a function that combines the field's values into groups for the headers. Cannot be used with an XmlaStore or remote operations.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Selector(string jsFunc)
		{
			AssignJS("selector", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that combines the field's values into groups for the headers. Cannot be used with an XmlaStore or remote operations.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Selector(RazorBlock jsFunc)
		{
			return Selector(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether to display the field's grand totals. Applies only if the field is in the data area.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowGrandTotals(bool value)
		{
			base.Options["showGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the field's grand totals. Applies only if the field is in the data area.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowGrandTotals(JS value)
		{
			base.Options["showGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the field's totals.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowTotals(bool value)
		{
			base.Options["showTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the field's totals.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowTotals(JS value)
		{
			base.Options["showTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the field's summary values. Applies only if the field is in the data area. Inherits the showTotals' value by default.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowValues(bool value)
		{
			base.Options["showValues"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the field's summary values. Applies only if the field is in the data area. Inherits the showTotals' value by default.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> ShowValues(JS value)
		{
			base.Options["showValues"] = value;
			return this;
		}

		/// <summary>Specifies how the field's values in the headers should be sorted.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBy(PivotGridSortBy value)
		{
			base.Options["sortBy"] = value;
			return this;
		}

		/// <summary>Sorts the field's values in the headers by the specified measure's summary values. Accepts the measure's name, caption, dataField, or index in the fields array.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBySummaryField(string value)
		{
			base.Options["sortBySummaryField"] = value;
			return this;
		}

		/// <summary>Sorts the field's values in the headers by the specified measure's summary values. Accepts the measure's name, caption, dataField, or index in the fields array.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBySummaryField(JS value)
		{
			base.Options["sortBySummaryField"] = value;
			return this;
		}

		/// <summary>Specifies a path to the column or row whose summary values should be used to sort the field's values in the headers.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBySummaryPath(IEnumerable<double> value)
		{
			base.Options["sortBySummaryPath"] = value;
			return this;
		}

		/// <summary>Specifies a path to the column or row whose summary values should be used to sort the field's values in the headers.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBySummaryPath(IEnumerable<string> value)
		{
			base.Options["sortBySummaryPath"] = value;
			return this;
		}

		/// <summary>Specifies a path to the column or row whose summary values should be used to sort the field's values in the headers.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortBySummaryPath(JS value)
		{
			base.Options["sortBySummaryPath"] = value;
			return this;
		}

		/// <summary>Specifies a custom comparison function that sorts the field's values in the headers.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortingMethod(string jsFunc)
		{
			AssignJS("sortingMethod", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom comparison function that sorts the field's values in the headers.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortingMethod(RazorBlock jsFunc)
		{
			return SortingMethod(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the field values' sorting order.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SortOrder(SortOrder value)
		{
			base.Options["sortOrder"] = value;
			return this;
		}

		/// <summary>Specifies a predefined post-processing function. Does not apply when the calculateSummaryValue option is set.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SummaryDisplayMode(PivotGridSummaryDisplayMode value)
		{
			base.Options["summaryDisplayMode"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate the field's data. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SummaryType(SummaryType value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate the field's data. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SummaryType(string value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate the field's data. Cannot be used with an XmlaStore.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> SummaryType(JS value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies whether the field is visible in the pivot grid and field chooser.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the field is visible in the pivot grid and field chooser.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the field's width in pixels when the field is displayed in the pivot grid.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the field's width in pixels when the field is displayed in the pivot grid.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a header item should be wrapped.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> WordWrapEnabled(bool value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a header item should be wrapped.</summary>
		[Generated]
		public PivotGridDataSourceFieldBuilder<T> WordWrapEnabled(JS value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}
	}
}
