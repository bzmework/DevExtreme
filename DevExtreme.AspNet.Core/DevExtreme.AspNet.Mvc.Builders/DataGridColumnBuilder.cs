using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class DataGridColumnBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DataGridColumnBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns the content of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit values in the column at runtime. By default, inherits the value of the editing.allowUpdating option.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowEditing(bool value)
		{
			base.Options["allowEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can edit values in the column at runtime. By default, inherits the value of the editing.allowUpdating option.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowEditing(JS value)
		{
			base.Options["allowEditing"] = value;
			return this;
		}

		/// <summary>Specifies whether data from this column should be exported. Applies only if the column is visible.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowExporting(bool value)
		{
			base.Options["allowExporting"] = value;
			return this;
		}

		/// <summary>Specifies whether data from this column should be exported. Applies only if the column is visible.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowExporting(JS value)
		{
			base.Options["allowExporting"] = value;
			return this;
		}

		/// <summary>Specifies whether data can be filtered by this column. Applies only if filterRow.visible is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowFiltering(bool value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether data can be filtered by this column. Applies only if filterRow.visible is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowFiltering(JS value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can fix the column at runtime. Applies only if columnFixing.enabled is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowFixing(bool value)
		{
			base.Options["allowFixing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can fix the column at runtime. Applies only if columnFixing.enabled is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowFixing(JS value)
		{
			base.Options["allowFixing"] = value;
			return this;
		}

		/// <summary>Specifies whether the user can group data by values of this column. Applies only when grouping is enabled.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowGrouping(bool value)
		{
			base.Options["allowGrouping"] = value;
			return this;
		}

		/// <summary>Specifies whether the user can group data by values of this column. Applies only when grouping is enabled.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowGrouping(JS value)
		{
			base.Options["allowGrouping"] = value;
			return this;
		}

		/// <summary>Specifies whether the header filter can be used to filter data by this column. Applies only if headerFilter.visible is true. By default, inherits the value of the allowFiltering option.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowHeaderFiltering(bool value)
		{
			base.Options["allowHeaderFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether the header filter can be used to filter data by this column. Applies only if headerFilter.visible is true. By default, inherits the value of the allowFiltering option.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowHeaderFiltering(JS value)
		{
			base.Options["allowHeaderFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can hide the column using the column chooser at runtime. Applies only if columnChooser.enabled is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowHiding(bool value)
		{
			base.Options["allowHiding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can hide the column using the column chooser at runtime. Applies only if columnChooser.enabled is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowHiding(JS value)
		{
			base.Options["allowHiding"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be used in column reordering at runtime. Applies only if allowColumnReordering is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowReordering(bool value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be used in column reordering at runtime. Applies only if allowColumnReordering is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowReordering(JS value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize the column at runtime. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowResizing(bool value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize the column at runtime. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowResizing(JS value)
		{
			base.Options["allowResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be searched. Applies only if searchPanel.visible is true. Inherits the value of the allowFiltering option by default.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether this column can be searched. Applies only if searchPanel.visible is true. Inherits the value of the allowFiltering option by default.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort rows by this column at runtime. Applies only if sorting.mode differs from "none".</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowSorting(bool value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can sort rows by this column at runtime. Applies only if sorting.mode differs from "none".</summary>
		[Generated]
		public DataGridColumnBuilder<T> AllowSorting(JS value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Specifies whether groups appear expanded or not when records are grouped by a specific column. Setting this option makes sense only when grouping is allowed for this column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AutoExpandGroup(bool value)
		{
			base.Options["autoExpandGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether groups appear expanded or not when records are grouped by a specific column. Setting this option makes sense only when grouping is allowed for this column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> AutoExpandGroup(JS value)
		{
			base.Options["autoExpandGroup"] = value;
			return this;
		}

		/// <summary>Allows you to customize buttons in the editing column or create a custom command column. Applies only if the column's type is "buttons".</summary>
		[Generated]
		public DataGridColumnBuilder<T> Buttons(IEnumerable<GridColumnButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to customize buttons in the editing column or create a custom command column. Applies only if the column's type is "buttons".</summary>
		[Generated]
		public DataGridColumnBuilder<T> Buttons(Action<CollectionFactory<DataGridColumnButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Calculates custom cell values. Use this function to create an unbound data column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateCellValue(string jsFunc)
		{
			AssignJS("calculateCellValue", jsFunc);
			return this;
		}

		/// <summary>Calculates custom cell values. Use this function to create an unbound data column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateCellValue(RazorBlock jsFunc)
		{
			return CalculateCellValue(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Calculates custom display values for column cells. Requires specifying the dataField or calculateCellValue option. Used in lookup optimization.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateDisplayValue(string value)
		{
			base.Options["calculateDisplayValue"] = value;
			return this;
		}

		/// <summary>Calculates custom display values for column cells. Requires specifying the dataField or calculateCellValue option. Used in lookup optimization.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateDisplayValue(JS value)
		{
			base.Options["calculateDisplayValue"] = value;
			return this;
		}

		/// <summary>Specifies the column's custom filtering rules.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateFilterExpression(string jsFunc)
		{
			AssignJS("calculateFilterExpression", jsFunc);
			return this;
		}

		/// <summary>Specifies the column's custom filtering rules.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateFilterExpression(RazorBlock jsFunc)
		{
			return CalculateFilterExpression(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a field name or a function that returns a field name or a value to be used for grouping column cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateGroupValue(string value)
		{
			base.Options["calculateGroupValue"] = value;
			return this;
		}

		/// <summary>Specifies a field name or a function that returns a field name or a value to be used for grouping column cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateGroupValue(JS value)
		{
			base.Options["calculateGroupValue"] = value;
			return this;
		}

		/// <summary>Calculates custom values to be used in sorting.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateSortValue(string value)
		{
			base.Options["calculateSortValue"] = value;
			return this;
		}

		/// <summary>Calculates custom values to be used in sorting.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CalculateSortValue(JS value)
		{
			base.Options["calculateSortValue"] = value;
			return this;
		}

		/// <summary>Specifies a caption for the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies a caption for the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CellTemplate(string templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CellTemplate(TemplateName name)
		{
			AssignTemplate("cellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for data cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CellTemplate(JS value)
		{
			base.Options["cellTemplate"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Columns(IEnumerable<string> value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Columns(JS value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Columns(Action<CollectionFactory<DataGridColumnBuilder<T>>> configurator)
		{
			Collection("columns", configurator);
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed in column cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed in column cells.</summary>
		[Generated]
		public DataGridColumnBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the column to a field of the dataSource.</summary>
		[Generated]
		public DataGridColumnBuilder<T> DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Binds the column to a field of the dataSource.</summary>
		[Generated]
		public DataGridColumnBuilder<T> DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Casts column values to a specific data type.</summary>
		[Generated]
		public DataGridColumnBuilder<T> DataType(GridColumnDataType value)
		{
			base.Options["dataType"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EditCellTemplate(string templateContent)
		{
			AssignTemplate("editCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EditCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("editCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EditCellTemplate(TemplateName name)
		{
			AssignTemplate("editCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for data cells in editing state.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EditCellTemplate(JS value)
		{
			base.Options["editCellTemplate"] = value;
			return this;
		}

		/// <summary>Configures the default widget used for editing and filtering in the filter row.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EditorOptions(object value)
		{
			base.Options["editorOptions"] = value;
			return this;
		}

		/// <summary>Specifies whether HTML tags are displayed as plain text or applied to the values of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EncodeHtml(bool value)
		{
			base.Options["encodeHtml"] = value;
			return this;
		}

		/// <summary>Specifies whether HTML tags are displayed as plain text or applied to the values of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> EncodeHtml(JS value)
		{
			base.Options["encodeHtml"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all false items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FalseText(string value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all false items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FalseText(JS value)
		{
			base.Options["falseText"] = value;
			return this;
		}

		/// <summary>Specifies a set of available filter operations. Applies only if filterRow.visible and allowFiltering are true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FilterOperations(IEnumerable<FilterOperations> value)
		{
			base.Options["filterOperations"] = value;
			return this;
		}

		/// <summary>Specifies whether a user changes the current filter by including (selecting) or excluding (clearing the selection of) values. Applies only if headerFilter.visible and allowHeaderFiltering are true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FilterType(FilterType value)
		{
			base.Options["filterType"] = value;
			return this;
		}

		/// <summary>Specifies the column's filter value displayed in the filter row.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FilterValue(object value)
		{
			base.Options["filterValue"] = value;
			return this;
		}

		/// <summary>Specifies values selected in the column's header filter.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FilterValues(IEnumerable value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Specifies values selected in the column's header filter.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FilterValues(JS value)
		{
			base.Options["filterValues"] = value;
			return this;
		}

		/// <summary>Fixes the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Fixed(bool value)
		{
			base.Options["fixed"] = value;
			return this;
		}

		/// <summary>Fixes the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Fixed(JS value)
		{
			base.Options["fixed"] = value;
			return this;
		}

		/// <summary>Specifies the widget's edge to which the column is fixed. Applies only if columns[].fixed is true.</summary>
		[Generated]
		public DataGridColumnBuilder<T> FixedPosition(HorizontalEdge value)
		{
			base.Options["fixedPosition"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a column cell.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Configures the form item that the column produces in the editing state. Applies only if editing.mode is "form" or "popup".</summary>
		[Generated]
		public DataGridColumnBuilder<T> FormItem(Action<FormSimpleItemBuilder> configurator)
		{
			NestedOptions("formItem", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for group cells (group rows).</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupCellTemplate(string templateContent)
		{
			AssignTemplate("groupCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group cells (group rows).</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group cells (group rows).</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupCellTemplate(TemplateName name)
		{
			AssignTemplate("groupCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group cells (group rows).</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupCellTemplate(JS value)
		{
			base.Options["groupCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the index of a column when grid records are grouped by the values of this column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupIndex(int value)
		{
			base.Options["groupIndex"] = value;
			return this;
		}

		/// <summary>Specifies the index of a column when grid records are grouped by the values of this column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> GroupIndex(JS value)
		{
			base.Options["groupIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public DataGridColumnBuilder<T> HeaderCellTemplate(string templateContent)
		{
			AssignTemplate("headerCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public DataGridColumnBuilder<T> HeaderCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("headerCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public DataGridColumnBuilder<T> HeaderCellTemplate(TemplateName name)
		{
			AssignTemplate("headerCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for column headers.</summary>
		[Generated]
		public DataGridColumnBuilder<T> HeaderCellTemplate(JS value)
		{
			base.Options["headerCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies data settings for the header filter.</summary>
		[Generated]
		public DataGridColumnBuilder<T> HeaderFilter(Action<DataGridColumnHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies the order in which columns are hidden when the widget adapts to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public DataGridColumnBuilder<T> HidingPriority(int value)
		{
			base.Options["hidingPriority"] = value;
			return this;
		}

		/// <summary>Specifies the order in which columns are hidden when the widget adapts to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public DataGridColumnBuilder<T> HidingPriority(JS value)
		{
			base.Options["hidingPriority"] = value;
			return this;
		}

		/// <summary>Specifies whether the column bands other columns or not.</summary>
		[Generated]
		public DataGridColumnBuilder<T> IsBand(bool value)
		{
			base.Options["isBand"] = value;
			return this;
		}

		/// <summary>Specifies whether the column bands other columns or not.</summary>
		[Generated]
		public DataGridColumnBuilder<T> IsBand(JS value)
		{
			base.Options["isBand"] = value;
			return this;
		}

		/// <summary>Specifies options of a lookup column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Lookup(Action<DataGridColumnLookupBuilder> configurator)
		{
			NestedOptions("lookup", configurator);
			return this;
		}

		/// <summary>Specifies the minimum width of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the identifier of the column.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the band column that owns the current column. Accepts the index of the band column in the columns array.</summary>
		[Generated]
		public DataGridColumnBuilder<T> OwnerBand(int value)
		{
			base.Options["ownerBand"] = value;
			return this;
		}

		/// <summary>Specifies the band column that owns the current column. Accepts the index of the band column in the columns array.</summary>
		[Generated]
		public DataGridColumnBuilder<T> OwnerBand(JS value)
		{
			base.Options["ownerBand"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the column after other columns and elements. Use if column cells have a complex template. Requires the width option specified.</summary>
		[Generated]
		public DataGridColumnBuilder<T> RenderAsync(bool value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the column after other columns and elements. Use if column cells have a complex template. Requires the width option specified.</summary>
		[Generated]
		public DataGridColumnBuilder<T> RenderAsync(JS value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies the column's filter operation displayed in the filter row.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SelectedFilterOperation(FilterOperations value)
		{
			base.Options["selectedFilterOperation"] = value;
			return this;
		}

		/// <summary>Specifies a function to be invoked after the user has edited a cell value, but before it will be saved in the data source.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SetCellValue(string jsFunc)
		{
			AssignJS("setCellValue", jsFunc);
			return this;
		}

		/// <summary>Specifies a function to be invoked after the user has edited a cell value, but before it will be saved in the data source.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SetCellValue(RazorBlock jsFunc)
		{
			return SetCellValue(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the column displays its values using editors.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowEditorAlways(bool value)
		{
			base.Options["showEditorAlways"] = value;
			return this;
		}

		/// <summary>Specifies whether the column displays its values using editors.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowEditorAlways(JS value)
		{
			base.Options["showEditorAlways"] = value;
			return this;
		}

		/// <summary>Specifies whether the column chooser can contain the column header.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowInColumnChooser(bool value)
		{
			base.Options["showInColumnChooser"] = value;
			return this;
		}

		/// <summary>Specifies whether the column chooser can contain the column header.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowInColumnChooser(JS value)
		{
			base.Options["showInColumnChooser"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the column when grid records are grouped by it.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowWhenGrouped(bool value)
		{
			base.Options["showWhenGrouped"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the column when grid records are grouped by it.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ShowWhenGrouped(JS value)
		{
			base.Options["showWhenGrouped"] = value;
			return this;
		}

		/// <summary>Specifies the index according to which columns participate in sorting.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SortIndex(int value)
		{
			base.Options["sortIndex"] = value;
			return this;
		}

		/// <summary>Specifies the index according to which columns participate in sorting.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SortIndex(JS value)
		{
			base.Options["sortIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom comparison function for sorting. Applies only when sorting is performed on the client.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SortingMethod(string jsFunc)
		{
			AssignJS("sortingMethod", jsFunc);
			return this;
		}

		/// <summary>Specifies a custom comparison function for sorting. Applies only when sorting is performed on the client.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SortingMethod(RazorBlock jsFunc)
		{
			return SortingMethod(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the sort order of column values.</summary>
		[Generated]
		public DataGridColumnBuilder<T> SortOrder(SortOrder value)
		{
			base.Options["sortOrder"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all true items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public DataGridColumnBuilder<T> TrueText(string value)
		{
			base.Options["trueText"] = value;
			return this;
		}

		/// <summary>In a boolean column, replaces all true items with a specified text. Applies only if showEditorAlways option is false.</summary>
		[Generated]
		public DataGridColumnBuilder<T> TrueText(JS value)
		{
			base.Options["trueText"] = value;
			return this;
		}

		/// <summary>Specifies the command column that this object customizes.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Type(GridCommandColumnType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies validation rules to be checked when cell values are updated.</summary>
		[Generated]
		public DataGridColumnBuilder<T> ValidationRules(Action<ValidationRulesFactory> configurator)
		{
			CustomCollection("validationRules", configurator);
			return this;
		}

		/// <summary>Specifies whether the column is visible, that is, occupies space in the table.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the column is visible, that is, occupies space in the table.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the position of the column regarding other columns in the resulting widget.</summary>
		[Generated]
		public DataGridColumnBuilder<T> VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the position of the column regarding other columns in the resulting widget.</summary>
		[Generated]
		public DataGridColumnBuilder<T> VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the column's width in pixels or as a percentage. Ignored if it is less than minWidth.</summary>
		[Generated]
		public DataGridColumnBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
