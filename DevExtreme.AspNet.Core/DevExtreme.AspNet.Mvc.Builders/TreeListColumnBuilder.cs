using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class TreeListColumnBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public TreeListColumnBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns the content of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit values in the column at runtime. By default, inherits the value of the editing.allowUpdating option.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowEditing(bool value)
		{
			base.Options["allowEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit values in the column at runtime. By default, inherits the value of the editing.allowUpdating option.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowEditing(JS value)
		{
			base.Options["allowEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether data can be filtered by this column. Applies only if filterRow.visible is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowFiltering(bool value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether data can be filtered by this column. Applies only if filterRow.visible is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowFiltering(JS value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can fix the column at runtime. Applies only if columnFixing.enabled is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowFixing(bool value)
		{
			base.Options["allowFixing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can fix the column at runtime. Applies only if columnFixing.enabled is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowFixing(JS value)
		{
			base.Options["allowFixing"] = value;
			return this;
		}

		/// <summary>Specifies whether the header filter can be used to filter data by this column. Applies only if headerFilter.visible is true. By default, inherits the value of the allowFiltering option.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowHeaderFiltering(bool value)
		{
			base.Options["allowHeaderFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether the header filter can be used to filter data by this column. Applies only if headerFilter.visible is true. By default, inherits the value of the allowFiltering option.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowHeaderFiltering(JS value)
		{
			base.Options["allowHeaderFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can hide the column using the column chooser at runtime. Applies only if columnChooser.enabled is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowHiding(bool value)
		{
			base.Options["allowHiding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can hide the column using the column chooser at runtime. Applies only if columnChooser.enabled is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowHiding(JS value)
		{
			base.Options["allowHiding"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be used in column reordering at runtime. Applies only if allowColumnReordering is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowReordering(bool value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be used in column reordering at runtime. Applies only if allowColumnReordering is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowReordering(JS value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize the column at runtime. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowResizing(bool value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize the column at runtime. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowResizing(JS value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be searched. Applies only if searchPanel.visible is true. Inherits the value of the allowFiltering option by default.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be searched. Applies only if searchPanel.visible is true. Inherits the value of the allowFiltering option by default.</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort rows by this column at runtime. Applies only if sorting.mode differs from "none".</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowSorting(bool value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort rows by this column at runtime. Applies only if sorting.mode differs from "none".</summary>
		[Generated]
		public TreeListColumnBuilder<T> AllowSorting(JS value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Allows you to customize buttons in the editing column or create a custom command column. Applies only if the column's type is "buttons".</summary>
		[Generated]
		public TreeListColumnBuilder<T> Buttons(IEnumerable<TreeListColumnButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to customize buttons in the editing column or create a custom command column. Applies only if the column's type is "buttons".</summary>
		[Generated]
		public TreeListColumnBuilder<T> Buttons(Action<CollectionFactory<TreeListColumnButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Calculates custom cell values. Use this function to create an unbound data column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateCellValue(string jsFunc)
		{
			AssignJS("calculateCellValue", jsFunc);
			return this;
		}

		/// <summary>Calculates custom cell values. Use this function to create an unbound data column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateCellValue(RazorBlock jsFunc)
		{
			return CalculateCellValue(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Calculates custom display values for column cells. Requires specifying the dataField or calculateCellValue option. Used in lookup optimization.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateDisplayValue(string value)
		{
			base.Options["calculateDisplayValue"] = value;
			return this;
		}

		/// <summary>Calculates custom display values for column cells. Requires specifying the dataField or calculateCellValue option. Used in lookup optimization.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateDisplayValue(JS value)
		{
			base.Options["calculateDisplayValue"] = value;
			return this;
		}

		/// <summary>Specifies the column's custom filtering rules.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateFilterExpression(string jsFunc)
		{
			AssignJS("calculateFilterExpression", jsFunc);
			return this;
		}

		/// <summary>Specifies the column's custom filtering rules.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateFilterExpression(RazorBlock jsFunc)
		{
			return CalculateFilterExpression(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Calculates custom values to be used in sorting.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateSortValue(string value)
		{
			base.Options["calculateSortValue"] = value;
			return this;
		}

		/// <summary>Calculates custom values to be used in sorting.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CalculateSortValue(JS value)
		{
			base.Options["calculateSortValue"] = value;
			return this;
		}

		/// <summary>Specifies a caption for the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies a caption for the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CellTemplate(string templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CellTemplate(TemplateName name)
		{
			AssignTemplate("cellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CellTemplate(JS value)
		{
			base.Options["cellTemplate"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Columns(IEnumerable<string> value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Columns(JS value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Columns(Action<CollectionFactory<TreeListColumnBuilder<T>>> configurator)
		{
			Collection("columns", configurator);
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed in column cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed in column cells.</summary>
		[Generated]
		public TreeListColumnBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the column to a field of the dataSource.</summary>
		[Generated]
		public TreeListColumnBuilder<T> DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Binds the column to a field of the dataSource.</summary>
		[Generated]
		public TreeListColumnBuilder<T> DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Casts column values to a specific data type.</summary>
		[Generated]
		public TreeListColumnBuilder<T> DataType(GridColumnDataType value)
		{
			base.Options["dataType"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EditCellTemplate(string templateContent)
		{
			AssignTemplate("editCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EditCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("editCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EditCellTemplate(TemplateName name)
		{
			AssignTemplate("editCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EditCellTemplate(JS value)
		{
			base.Options["editCellTemplate"] = value;
			return this;
		}

		/// <summary>Configures the default widget used for editing and filtering in the filter row.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EditorOptions(object value)
		{
			base.Options["editorOptions"] = value;
			return this;
		}

		/// <summary>Specifies whether HTML tags are displayed as plain text or applied to the values of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EncodeHtml(bool value)
		{
			base.Options["encodeHtml"] = value;
			return this;
		}

		/// <summary>Specifies whether HTML tags are displayed as plain text or applied to the values of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> EncodeHtml(JS value)
		{
			base.Options["encodeHtml"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all false items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FalseText(string value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all false items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FalseText(JS value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>Specifies a set of available filter operations. Applies only if filterRow.visible and allowFiltering are true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FilterOperations(IEnumerable<FilterOperations> value)
		{
			base.Options["filterOperations"] = value;
			return this;
		}

		/// <summary>Specifies whether a user changes the current filter by including (selecting) or excluding (clearing the selection of) values. Applies only if headerFilter.visible and allowHeaderFiltering are true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FilterType(FilterType value)
		{
			base.Options["filterType"] = value;
			return this;
		}

		/// <summary>Specifies the column's filter value displayed in the filter row.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FilterValue(object value)
		{
			base.Options["filterValue"] = value;
			return this;
		}

		/// <summary>Specifies values selected in the column's header filter.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FilterValues(IEnumerable value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Specifies values selected in the column's header filter.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FilterValues(JS value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Fixes the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Fixed(bool value)
		{
			base.Options["fixed"] = value;
			return this;
		}

		/// <summary>Fixes the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Fixed(JS value)
		{
			base.Options["fixed"] = value;
			return this;
		}

		/// <summary>Specifies the widget's edge to which the column is fixed. Applies only if columns[].fixed is true.</summary>
		[Generated]
		public TreeListColumnBuilder<T> FixedPosition(HorizontalEdge value)
		{
			base.Options["fixedPosition"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Configures the form item that the column produces in the editing state. Applies only if editing.mode is "form" or "popup".</summary>
		[Generated]
		public TreeListColumnBuilder<T> FormItem(Action<FormSimpleItemBuilder> configurator)
		{
			NestedOptions("formItem", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public TreeListColumnBuilder<T> HeaderCellTemplate(string templateContent)
		{
			AssignTemplate("headerCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public TreeListColumnBuilder<T> HeaderCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("headerCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public TreeListColumnBuilder<T> HeaderCellTemplate(TemplateName name)
		{
			AssignTemplate("headerCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public TreeListColumnBuilder<T> HeaderCellTemplate(JS value)
		{
			base.Options["headerCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies data settings for the header filter.</summary>
		[Generated]
		public TreeListColumnBuilder<T> HeaderFilter(Action<TreeListColumnHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies the order in which columns are hidden when the widget adapts to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public TreeListColumnBuilder<T> HidingPriority(int value)
		{
			base.Options["hidingPriority"] = value;
			return this;
		}

		/// <summary>Specifies the order in which columns are hidden when the widget adapts to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public TreeListColumnBuilder<T> HidingPriority(JS value)
		{
			base.Options["hidingPriority"] = value;
			return this;
		}

		/// <summary>Specifies whether the column bands other columns or not.</summary>
		[Generated]
		public TreeListColumnBuilder<T> IsBand(bool value)
		{
			base.Options["isBand"] = value;
			return this;
		}

		/// <summary>Specifies whether the column bands other columns or not.</summary>
		[Generated]
		public TreeListColumnBuilder<T> IsBand(JS value)
		{
			base.Options["isBand"] = value;
			return this;
		}

		/// <summary>Specifies options of a lookup column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Lookup(Action<TreeListColumnLookupBuilder> configurator)
		{
			NestedOptions("lookup", configurator);
			return this;
		}

		/// <summary>Specifies the minimum width of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the band column that owns the current column. Accepts the index of the band column in the columns array.</summary>
		[Generated]
		public TreeListColumnBuilder<T> OwnerBand(double value)
		{
			base.Options["ownerBand"] = value;
			return this;
		}

		/// <summary>Specifies the band column that owns the current column. Accepts the index of the band column in the columns array.</summary>
		[Generated]
		public TreeListColumnBuilder<T> OwnerBand(JS value)
		{
			base.Options["ownerBand"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the column after other columns and elements. Use if column cells have a complex template. Requires the width option specified.</summary>
		[Generated]
		public TreeListColumnBuilder<T> RenderAsync(bool value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the column after other columns and elements. Use if column cells have a complex template. Requires the width option specified.</summary>
		[Generated]
		public TreeListColumnBuilder<T> RenderAsync(JS value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies the column's filter operation displayed in the filter row.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SelectedFilterOperation(FilterOperations value)
		{
			base.Options["selectedFilterOperation"] = value;
			return this;
		}

		/// <summary>Specifies a function to be invoked after the user has edited a cell value, but before it will be saved in the data source.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SetCellValue(string jsFunc)
		{
			AssignJS("setCellValue", jsFunc);
			return this;
		}

		/// <summary>Specifies a function to be invoked after the user has edited a cell value, but before it will be saved in the data source.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SetCellValue(RazorBlock jsFunc)
		{
			return SetCellValue(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the column displays its values using editors.</summary>
		[Generated]
		public TreeListColumnBuilder<T> ShowEditorAlways(bool value)
		{
			base.Options["showEditorAlways"] = value;
			return this;
		}

		/// <summary>Specifies whether the column displays its values using editors.</summary>
		[Generated]
		public TreeListColumnBuilder<T> ShowEditorAlways(JS value)
		{
			base.Options["showEditorAlways"] = value;
			return this;
		}

		/// <summary>Specifies whether the column chooser can contain the column header.</summary>
		[Generated]
		public TreeListColumnBuilder<T> ShowInColumnChooser(bool value)
		{
			base.Options["showInColumnChooser"] = value;
			return this;
		}

		/// <summary>Specifies whether the column chooser can contain the column header.</summary>
		[Generated]
		public TreeListColumnBuilder<T> ShowInColumnChooser(JS value)
		{
			base.Options["showInColumnChooser"] = value;
			return this;
		}

		/// <summary>Specifies the index according to which columns participate in sorting.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SortIndex(int value)
		{
			base.Options["sortIndex"] = value;
			return this;
		}

		/// <summary>Specifies the index according to which columns participate in sorting.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SortIndex(JS value)
		{
			base.Options["sortIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom comparison function for sorting. Applies only when sorting is performed on the client.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SortingMethod(string jsFunc)
		{
			AssignJS("sortingMethod", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom comparison function for sorting. Applies only when sorting is performed on the client.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SortingMethod(RazorBlock jsFunc)
		{
			return SortingMethod(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the sort order of column values.</summary>
		[Generated]
		public TreeListColumnBuilder<T> SortOrder(SortOrder value)
		{
			base.Options["sortOrder"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all true items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public TreeListColumnBuilder<T> TrueText(string value)
		{
			base.Options["trueText"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all true items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public TreeListColumnBuilder<T> TrueText(JS value)
		{
			base.Options["trueText"] = value;
			return this;
		}

		/// <summary>Specifies the command column that this object customizes.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Type(TreeListCommandColumnType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies validation rules to be checked when cell values are updated.</summary>
		[Generated]
		public TreeListColumnBuilder<T> ValidationRules(Action<ValidationRulesFactory> configurator)
		{
			CustomCollection("validationRules", configurator);
			return this;
		}

		/// <summary>Specifies whether the column is visible, that is, occupies space in the table.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the column is visible, that is, occupies space in the table.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the position of the column regarding other columns in the resulting widget.</summary>
		[Generated]
		public TreeListColumnBuilder<T> VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the position of the column regarding other columns in the resulting widget.</summary>
		[Generated]
		public TreeListColumnBuilder<T> VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public TreeListColumnBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
