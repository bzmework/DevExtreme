using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The DataGrid is a widget that represents data from a local or remote source in the form of a grid. This widget offers such basic features as sorting, grouping, filtering, as well as more advanced capabilities, like state storing, export to Excel, master-detail interface, and many others.</summary>
	public class DataGridBuilder<T> : WidgetBuilder
	{
		/// <summary>Specifies the operations that must be performed on the server side.</summary>
		[Obsolete("Use RemoteOperations(bool value) or RemoteOperations(Action configurator) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataGridBuilder<T> RemoteOperations(string value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		[Obsolete("Use KeyExpr(string) or KeyExpr(IEnumerable<string>) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataGridBuilder<T> KeyExpr(string key1, string key2, params string[] rest)
		{
			base.Options["keyExpr"] = new string[2]
			{
				key1,
				key2
			}.Concat(rest);
			return this;
		}

		[Generated]
		public DataGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DataGridBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DataGridBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DataGridBuilder<T> AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DataGridBuilder<T> AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DataGridBuilder<T> ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DataGridBuilder<T> ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can reorder columns.</summary>
		[Generated]
		public DataGridBuilder<T> AllowColumnReordering(bool value)
		{
			base.Options["allowColumnReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can reorder columns.</summary>
		[Generated]
		public DataGridBuilder<T> AllowColumnReordering(JS value)
		{
			base.Options["allowColumnReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize columns.</summary>
		[Generated]
		public DataGridBuilder<T> AllowColumnResizing(bool value)
		{
			base.Options["allowColumnResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize columns.</summary>
		[Generated]
		public DataGridBuilder<T> AllowColumnResizing(JS value)
		{
			base.Options["allowColumnResizing"] = value;
			return this;
		}

		/// <summary>Automatically scrolls to the focused row when the focusedRowKey is changed.</summary>
		[Generated]
		public DataGridBuilder<T> AutoNavigateToFocusedRow(bool value)
		{
			base.Options["autoNavigateToFocusedRow"] = value;
			return this;
		}

		/// <summary>Automatically scrolls to the focused row when the focusedRowKey is changed.</summary>
		[Generated]
		public DataGridBuilder<T> AutoNavigateToFocusedRow(JS value)
		{
			base.Options["autoNavigateToFocusedRow"] = value;
			return this;
		}

		/// <summary>Specifies whether data should be cached.</summary>
		[Generated]
		public DataGridBuilder<T> CacheEnabled(bool value)
		{
			base.Options["cacheEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether data should be cached.</summary>
		[Generated]
		public DataGridBuilder<T> CacheEnabled(JS value)
		{
			base.Options["cacheEnabled"] = value;
			return this;
		}

		/// <summary>Enables a hint that appears when a user hovers the mouse pointer over a cell with truncated content.</summary>
		[Generated]
		public DataGridBuilder<T> CellHintEnabled(bool value)
		{
			base.Options["cellHintEnabled"] = value;
			return this;
		}

		/// <summary>Enables a hint that appears when a user hovers the mouse pointer over a cell with truncated content.</summary>
		[Generated]
		public DataGridBuilder<T> CellHintEnabled(JS value)
		{
			base.Options["cellHintEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether columns should adjust their widths to the content.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnAutoWidth(bool value)
		{
			base.Options["columnAutoWidth"] = value;
			return this;
		}

		/// <summary>Specifies whether columns should adjust their widths to the content.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnAutoWidth(JS value)
		{
			base.Options["columnAutoWidth"] = value;
			return this;
		}

		/// <summary>Configures the column chooser.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnChooser(Action<DataGridColumnChooserBuilder> configurator)
		{
			NestedOptions("columnChooser", configurator);
			return this;
		}

		/// <summary>Configures column fixing.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnFixing(Action<DataGridColumnFixingBuilder> configurator)
		{
			NestedOptions("columnFixing", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget should hide columns to adapt to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public DataGridBuilder<T> ColumnHidingEnabled(bool value)
		{
			base.Options["columnHidingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should hide columns to adapt to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public DataGridBuilder<T> ColumnHidingEnabled(JS value)
		{
			base.Options["columnHidingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of columns.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnMinWidth(double value)
		{
			base.Options["columnMinWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of columns.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnMinWidth(JS value)
		{
			base.Options["columnMinWidth"] = value;
			return this;
		}

		/// <summary>Specifies how the widget resizes columns. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnResizingMode(ColumnResizingMode value)
		{
			base.Options["columnResizingMode"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridBuilder<T> Columns(IEnumerable<string> value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridBuilder<T> Columns(JS value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of grid columns.</summary>
		[Generated]
		public DataGridBuilder<T> Columns(Action<CollectionFactory<DataGridColumnBuilder<T>>> configurator)
		{
			Collection("columns", configurator);
			return this;
		}

		/// <summary>Specifies the width for all data columns. Has a lower priority than the column.width option.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnWidth(double value)
		{
			base.Options["columnWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width for all data columns. Has a lower priority than the column.width option.</summary>
		[Generated]
		public DataGridBuilder<T> ColumnWidth(JS value)
		{
			base.Options["columnWidth"] = value;
			return this;
		}

		/// <summary>Customizes columns after they are created.</summary>
		[Generated]
		public DataGridBuilder<T> CustomizeColumns(string jsFunc)
		{
			AssignJS("customizeColumns", jsFunc);
			return this;
		}

		/// <summary>Customizes columns after they are created.</summary>
		[Generated]
		public DataGridBuilder<T> CustomizeColumns(RazorBlock jsFunc)
		{
			return CustomizeColumns(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes data before export. You can use the export.customizeExcelCell function instead.</summary>
		[Generated]
		public DataGridBuilder<T> CustomizeExportData(string jsFunc)
		{
			AssignJS("customizeExportData", jsFunc);
			return this;
		}

		/// <summary>Customizes data before export. You can use the export.customizeExcelCell function instead.</summary>
		[Generated]
		public DataGridBuilder<T> CustomizeExportData(RazorBlock jsFunc)
		{
			return CustomizeExportData(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DataGridBuilder<T> DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DataGridBuilder<T> DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DataGridBuilder<T> DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DataGridBuilder<T> DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DataGridBuilder<T> DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the format in which date-time values should be sent to the server. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public DataGridBuilder<T> DateSerializationFormat(string value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the format in which date-time values should be sent to the server. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public DataGridBuilder<T> DateSerializationFormat(JS value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DataGridBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DataGridBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Configures editing.</summary>
		[Generated]
		public DataGridBuilder<T> Editing(Action<DataGridEditingBuilder<T>> configurator)
		{
			NestedOptions("editing", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DataGridBuilder<T> ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DataGridBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DataGridBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DataGridBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Indicates whether to show the error row.</summary>
		[Generated]
		public DataGridBuilder<T> ErrorRowEnabled(bool value)
		{
			base.Options["errorRowEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether to show the error row.</summary>
		[Generated]
		public DataGridBuilder<T> ErrorRowEnabled(JS value)
		{
			base.Options["errorRowEnabled"] = value;
			return this;
		}

		/// <summary>Configures client-side exporting.</summary>
		[Generated]
		public DataGridBuilder<T> Export(Action<DataGridExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Configures the integrated filter builder.</summary>
		[Generated]
		public DataGridBuilder<T> FilterBuilder(Action<FilterBuilderBuilder<T>> configurator)
		{
			NestedOptions("filterBuilder", configurator);
			return this;
		}

		/// <summary>Configures the popup in which the integrated filter builder is shown.</summary>
		[Generated]
		public DataGridBuilder<T> FilterBuilderPopup(Action<PopupBuilder> configurator)
		{
			NestedOptions("filterBuilderPopup", configurator);
			return this;
		}

		/// <summary>Configures the filter panel.</summary>
		[Generated]
		public DataGridBuilder<T> FilterPanel(Action<DataGridFilterPanelBuilder> configurator)
		{
			NestedOptions("filterPanel", configurator);
			return this;
		}

		/// <summary>Configures the filter row.</summary>
		[Generated]
		public DataGridBuilder<T> FilterRow(Action<DataGridFilterRowBuilder> configurator)
		{
			NestedOptions("filterRow", configurator);
			return this;
		}

		/// <summary>Specifies whether to synchronize the filter row, header filter, and filter builder. The synchronized filter expression is stored in the filterValue option.</summary>
		[Generated]
		public DataGridBuilder<T> FilterSyncEnabled(bool value)
		{
			base.Options["filterSyncEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to synchronize the filter row, header filter, and filter builder. The synchronized filter expression is stored in the filterValue option.</summary>
		[Generated]
		public DataGridBuilder<T> FilterSyncEnabled(JS value)
		{
			base.Options["filterSyncEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a filter expression.</summary>
		[Generated]
		public DataGridBuilder<T> FilterValue(string jsExpr)
		{
			AssignJS("filterValue", jsExpr);
			return this;
		}

		/// <summary>Specifies a filter expression.</summary>
		[Generated]
		public DataGridBuilder<T> FilterValue(object filterExpr)
		{
			base.Options["filterValue"] = filterExpr;
			return this;
		}

		/// <summary>Specifies the index of the column focused initially or currently in the data row area.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedColumnIndex(int value)
		{
			base.Options["focusedColumnIndex"] = value;
			return this;
		}

		/// <summary>Specifies the index of the column focused initially or currently in the data row area.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedColumnIndex(JS value)
		{
			base.Options["focusedColumnIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the focused row feature is enabled.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedRowEnabled(bool value)
		{
			base.Options["focusedRowEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the focused row feature is enabled.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedRowEnabled(JS value)
		{
			base.Options["focusedRowEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the initially or currently focused grid row's index. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedRowIndex(int value)
		{
			base.Options["focusedRowIndex"] = value;
			return this;
		}

		/// <summary>Specifies the initially or currently focused grid row's index. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedRowIndex(JS value)
		{
			base.Options["focusedRowIndex"] = value;
			return this;
		}

		/// <summary>Specifies initially or currently focused grid row's key. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> FocusedRowKey(object value)
		{
			base.Options["focusedRowKey"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DataGridBuilder<T> FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DataGridBuilder<T> FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures grouping.</summary>
		[Generated]
		public DataGridBuilder<T> Grouping(Action<DataGridGroupingBuilder> configurator)
		{
			NestedOptions("grouping", configurator);
			return this;
		}

		/// <summary>Configures the group panel.</summary>
		[Generated]
		public DataGridBuilder<T> GroupPanel(Action<DataGridGroupPanelBuilder> configurator)
		{
			NestedOptions("groupPanel", configurator);
			return this;
		}

		/// <summary>Configures the header filter feature.</summary>
		[Generated]
		public DataGridBuilder<T> HeaderFilter(Action<DataGridHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DataGridBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DataGridBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DataGridBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight rows and cells with edited data. repaintChangesOnly should be true.</summary>
		[Generated]
		public DataGridBuilder<T> HighlightChanges(bool value)
		{
			base.Options["highlightChanges"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight rows and cells with edited data. repaintChangesOnly should be true.</summary>
		[Generated]
		public DataGridBuilder<T> HighlightChanges(JS value)
		{
			base.Options["highlightChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DataGridBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DataGridBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DataGridBuilder<T> HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DataGridBuilder<T> HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures keyboard navigation.</summary>
		[Generated]
		public DataGridBuilder<T> KeyboardNavigation(Action<DataGridKeyboardNavigationBuilder> configurator)
		{
			NestedOptions("keyboardNavigation", configurator);
			return this;
		}

		/// <summary>Specifies which data field provides keys for data items. Applies only if data is a simple array.</summary>
		[Generated]
		public DataGridBuilder<T> KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for data items. Applies only if data is a simple array.</summary>
		[Generated]
		public DataGridBuilder<T> KeyExpr(IEnumerable<string> value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for data items. Applies only if data is a simple array.</summary>
		[Generated]
		public DataGridBuilder<T> KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Configures the load panel.</summary>
		[Generated]
		public DataGridBuilder<T> LoadPanel(Action<DataGridLoadPanelBuilder> configurator)
		{
			NestedOptions("loadPanel", configurator);
			return this;
		}

		/// <summary>Allows you to build a master-detail interface in the grid.</summary>
		[Generated]
		public DataGridBuilder<T> MasterDetail(Action<DataGridMasterDetailBuilder> configurator)
		{
			NestedOptions("masterDetail", configurator);
			return this;
		}

		/// <summary>Specifies text shown when the widget does not display any data.</summary>
		[Generated]
		public DataGridBuilder<T> NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>Specifies text shown when the widget does not display any data.</summary>
		[Generated]
		public DataGridBuilder<T> NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed before an adaptive detail row is rendered.</summary>
		[Generated]
		public DataGridBuilder<T> OnAdaptiveDetailRowPreparing(string jsFunc)
		{
			AssignJS("onAdaptiveDetailRowPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an adaptive detail row is rendered.</summary>
		[Generated]
		public DataGridBuilder<T> OnAdaptiveDetailRowPreparing(RazorBlock jsFunc)
		{
			return OnAdaptiveDetailRowPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a cell is clicked or tapped. Executed before onRowClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellClick(string jsFunc)
		{
			AssignJS("onCellClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a cell is clicked or tapped. Executed before onRowClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellClick(RazorBlock jsFunc)
		{
			return OnCellClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a cell is double-clicked or double-tapped. Executed before onRowDblClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellDblClick(string jsFunc)
		{
			AssignJS("onCellDblClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a cell is double-clicked or double-tapped. Executed before onRowDblClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellDblClick(RazorBlock jsFunc)
		{
			return OnCellDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a cell.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellHoverChanged(string jsFunc)
		{
			AssignJS("onCellHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a cell.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellHoverChanged(RazorBlock jsFunc)
		{
			return OnCellHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a cell is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellPrepared(string jsFunc)
		{
			AssignJS("onCellPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a cell is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnCellPrepared(RazorBlock jsFunc)
		{
			return OnCellPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DataGridBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DataGridBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public DataGridBuilder<T> OnContextMenuPreparing(string jsFunc)
		{
			AssignJS("onContextMenuPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public DataGridBuilder<T> OnContextMenuPreparing(RazorBlock jsFunc)
		{
			return OnContextMenuPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnDataErrorOccurred(string jsFunc)
		{
			AssignJS("onDataErrorOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnDataErrorOccurred(RazorBlock jsFunc)
		{
			return OnDataErrorOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DataGridBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DataGridBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a cell or row switches to the editing state.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditingStart(string jsFunc)
		{
			AssignJS("onEditingStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a cell or row switches to the editing state.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditingStart(RazorBlock jsFunc)
		{
			return OnEditingStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after an editor is created. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditorPrepared(string jsFunc)
		{
			AssignJS("onEditorPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an editor is created. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditorPrepared(RazorBlock jsFunc)
		{
			return OnEditorPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used to customize or replace default editors. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditorPreparing(string jsFunc)
		{
			AssignJS("onEditorPreparing", jsFunc);
			return this;
		}

		/// <summary>A function used to customize or replace default editors. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public DataGridBuilder<T> OnEditorPreparing(RazorBlock jsFunc)
		{
			return OnEditorPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is exported.</summary>
		[Generated]
		public DataGridBuilder<T> OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is exported.</summary>
		[Generated]
		public DataGridBuilder<T> OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before data is exported.</summary>
		[Generated]
		public DataGridBuilder<T> OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is exported.</summary>
		[Generated]
		public DataGridBuilder<T> OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported data is saved to the user's local storage.</summary>
		[Generated]
		public DataGridBuilder<T> OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported data is saved to the user's local storage.</summary>
		[Generated]
		public DataGridBuilder<T> OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the focused cell changes.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedCellChanged(string jsFunc)
		{
			AssignJS("onFocusedCellChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the focused cell changes.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedCellChanged(RazorBlock jsFunc)
		{
			return OnFocusedCellChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the focused cell changes.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedCellChanging(string jsFunc)
		{
			AssignJS("onFocusedCellChanging", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the focused cell changes.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedCellChanging(RazorBlock jsFunc)
		{
			return OnFocusedCellChanging(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedRowChanged(string jsFunc)
		{
			AssignJS("onFocusedRowChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedRowChanged(RazorBlock jsFunc)
		{
			return OnFocusedRowChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedRowChanging(string jsFunc)
		{
			AssignJS("onFocusedRowChanging", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public DataGridBuilder<T> OnFocusedRowChanging(RazorBlock jsFunc)
		{
			return OnFocusedRowChanging(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DataGridBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DataGridBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a new row is added to the widget.</summary>
		[Generated]
		public DataGridBuilder<T> OnInitNewRow(string jsFunc)
		{
			AssignJS("onInitNewRow", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a new row is added to the widget.</summary>
		[Generated]
		public DataGridBuilder<T> OnInitNewRow(RazorBlock jsFunc)
		{
			return OnInitNewRow(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget is in focus and a key has been pressed down.</summary>
		[Generated]
		public DataGridBuilder<T> OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget is in focus and a key has been pressed down.</summary>
		[Generated]
		public DataGridBuilder<T> OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DataGridBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DataGridBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a row is clicked or tapped.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowClick(string jsFunc)
		{
			AssignJS("onRowClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a row is clicked or tapped.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowClick(RazorBlock jsFunc)
		{
			return OnRowClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is collapsed.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowCollapsed(string jsFunc)
		{
			AssignJS("onRowCollapsed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is collapsed.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowCollapsed(RazorBlock jsFunc)
		{
			return OnRowCollapsed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is collapsed.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowCollapsing(string jsFunc)
		{
			AssignJS("onRowCollapsing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is collapsed.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowCollapsing(RazorBlock jsFunc)
		{
			return OnRowCollapsing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a row is double-clicked or double-tapped. Executed after onCellDblClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowDblClick(string jsFunc)
		{
			AssignJS("onRowDblClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a row is double-clicked or double-tapped. Executed after onCellDblClick.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowDblClick(RazorBlock jsFunc)
		{
			return OnRowDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is expanded.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowExpanded(string jsFunc)
		{
			AssignJS("onRowExpanded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is expanded.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowExpanded(RazorBlock jsFunc)
		{
			return OnRowExpanded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is expanded.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowExpanding(string jsFunc)
		{
			AssignJS("onRowExpanding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is expanded.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowExpanding(RazorBlock jsFunc)
		{
			return OnRowExpanding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a new row has been inserted into the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowInserted(string jsFunc)
		{
			AssignJS("onRowInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a new row has been inserted into the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowInserted(RazorBlock jsFunc)
		{
			return OnRowInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a new row is inserted into the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowInserting(string jsFunc)
		{
			AssignJS("onRowInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a new row is inserted into the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowInserting(RazorBlock jsFunc)
		{
			return OnRowInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowPrepared(string jsFunc)
		{
			AssignJS("onRowPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowPrepared(RazorBlock jsFunc)
		{
			return OnRowPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row has been removed from the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowRemoved(string jsFunc)
		{
			AssignJS("onRowRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row has been removed from the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowRemoved(RazorBlock jsFunc)
		{
			return OnRowRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is removed from the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowRemoving(string jsFunc)
		{
			AssignJS("onRowRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is removed from the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowRemoving(RazorBlock jsFunc)
		{
			return OnRowRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row has been updated in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowUpdated(string jsFunc)
		{
			AssignJS("onRowUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row has been updated in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowUpdated(RazorBlock jsFunc)
		{
			return OnRowUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is updated in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowUpdating(string jsFunc)
		{
			AssignJS("onRowUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is updated in the data source.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowUpdating(RazorBlock jsFunc)
		{
			return OnRowUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after cells in a row are validated against validation rules.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowValidating(string jsFunc)
		{
			AssignJS("onRowValidating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after cells in a row are validated against validation rules.</summary>
		[Generated]
		public DataGridBuilder<T> OnRowValidating(RazorBlock jsFunc)
		{
			return OnRowValidating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after selecting a row or clearing its selection.</summary>
		[Generated]
		public DataGridBuilder<T> OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after selecting a row or clearing its selection.</summary>
		[Generated]
		public DataGridBuilder<T> OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the toolbar is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnToolbarPreparing(string jsFunc)
		{
			AssignJS("onToolbarPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the toolbar is created.</summary>
		[Generated]
		public DataGridBuilder<T> OnToolbarPreparing(RazorBlock jsFunc)
		{
			return OnToolbarPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Configures the pager.</summary>
		[Generated]
		public DataGridBuilder<T> Pager(Action<DataGridPagerBuilder> configurator)
		{
			NestedOptions("pager", configurator);
			return this;
		}

		/// <summary>Configures paging.</summary>
		[Generated]
		public DataGridBuilder<T> Paging(Action<DataGridPagingBuilder> configurator)
		{
			NestedOptions("paging", configurator);
			return this;
		}

		/// <summary>Notifies the DataGrid of the server's data processing operations.</summary>
		[Generated]
		public DataGridBuilder<T> RemoteOperations(Action<DataGridRemoteOperationsBuilder> configurator)
		{
			NestedOptions("remoteOperations", configurator);
			return this;
		}

		/// <summary>Notifies the DataGrid of the server's data processing operations.</summary>
		[Generated]
		public DataGridBuilder<T> RemoteOperations(bool value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		/// <summary>Notifies the DataGrid of the server's data processing operations.</summary>
		[Generated]
		public DataGridBuilder<T> RemoteOperations(JS value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the filter row, command columns, and columns with showEditorAlways set to true after other elements.</summary>
		[Generated]
		public DataGridBuilder<T> RenderAsync(bool value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the filter row, command columns, and columns with showEditorAlways set to true after other elements.</summary>
		[Generated]
		public DataGridBuilder<T> RenderAsync(JS value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those cells whose data changed.</summary>
		[Generated]
		public DataGridBuilder<T> RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those cells whose data changed.</summary>
		[Generated]
		public DataGridBuilder<T> RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether rows should be shaded differently.</summary>
		[Generated]
		public DataGridBuilder<T> RowAlternationEnabled(bool value)
		{
			base.Options["rowAlternationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether rows should be shaded differently.</summary>
		[Generated]
		public DataGridBuilder<T> RowAlternationEnabled(JS value)
		{
			base.Options["rowAlternationEnabled"] = value;
			return this;
		}

		/// <summary>Configures row reordering using drag and drop gestures.</summary>
		[Generated]
		public DataGridBuilder<T> RowDragging(Action<DataGridRowDraggingBuilder> configurator)
		{
			NestedOptions("rowDragging", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for rows.</summary>
		[Generated]
		public DataGridBuilder<T> RowTemplate(string templateContent)
		{
			AssignTemplate("rowTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for rows.</summary>
		[Generated]
		public DataGridBuilder<T> RowTemplate(RazorBlock templateContent)
		{
			AssignTemplate("rowTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for rows.</summary>
		[Generated]
		public DataGridBuilder<T> RowTemplate(TemplateName name)
		{
			AssignTemplate("rowTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for rows.</summary>
		[Generated]
		public DataGridBuilder<T> RowTemplate(JS value)
		{
			base.Options["rowTemplate"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DataGridBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DataGridBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Configures scrolling.</summary>
		[Generated]
		public DataGridBuilder<T> Scrolling(Action<DataGridScrollingBuilder> configurator)
		{
			NestedOptions("scrolling", configurator);
			return this;
		}

		/// <summary>Configures the search panel.</summary>
		[Generated]
		public DataGridBuilder<T> SearchPanel(Action<DataGridSearchPanelBuilder> configurator)
		{
			NestedOptions("searchPanel", configurator);
			return this;
		}

		/// <summary>Allows you to select rows or determine which rows are selected.</summary>
		[Generated]
		public DataGridBuilder<T> SelectedRowKeys(IEnumerable value)
		{
			base.Options["selectedRowKeys"] = value;
			return this;
		}

		/// <summary>Allows you to select rows or determine which rows are selected.</summary>
		[Generated]
		public DataGridBuilder<T> SelectedRowKeys(JS value)
		{
			base.Options["selectedRowKeys"] = value;
			return this;
		}

		/// <summary>Configures runtime selection.</summary>
		[Generated]
		public DataGridBuilder<T> Selection(Action<DataGridSelectionBuilder> configurator)
		{
			NestedOptions("selection", configurator);
			return this;
		}

		/// <summary>Specifies filters for the rows that must be selected initially. Applies only if selection.deferred is true.</summary>
		[Generated]
		public DataGridBuilder<T> SelectionFilter(string jsExpr)
		{
			AssignJS("selectionFilter", jsExpr);
			return this;
		}

		/// <summary>Specifies filters for the rows that must be selected initially. Applies only if selection.deferred is true.</summary>
		[Generated]
		public DataGridBuilder<T> SelectionFilter(object filterExpr)
		{
			base.Options["selectionFilter"] = filterExpr;
			return this;
		}

		/// <summary>Specifies whether the outer borders of the widget are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowBorders(bool value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether the outer borders of the widget are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowBorders(JS value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether column headers are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowColumnHeaders(bool value)
		{
			base.Options["showColumnHeaders"] = value;
			return this;
		}

		/// <summary>Specifies whether column headers are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowColumnHeaders(JS value)
		{
			base.Options["showColumnHeaders"] = value;
			return this;
		}

		/// <summary>Specifies whether vertical lines that separate one column from another are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowColumnLines(bool value)
		{
			base.Options["showColumnLines"] = value;
			return this;
		}

		/// <summary>Specifies whether vertical lines that separate one column from another are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowColumnLines(JS value)
		{
			base.Options["showColumnLines"] = value;
			return this;
		}

		/// <summary>Specifies whether horizontal lines that separate one row from another are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowRowLines(bool value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Specifies whether horizontal lines that separate one row from another are visible.</summary>
		[Generated]
		public DataGridBuilder<T> ShowRowLines(JS value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Allows you to sort groups according to the values of group summary items.</summary>
		[Generated]
		public DataGridBuilder<T> SortByGroupSummaryInfo(Action<CollectionFactory<DataGridSortByGroupSummaryInfoBuilder>> configurator)
		{
			Collection("sortByGroupSummaryInfo", configurator);
			return this;
		}

		/// <summary>Configures runtime sorting.</summary>
		[Generated]
		public DataGridBuilder<T> Sorting(Action<DataGridSortingBuilder> configurator)
		{
			NestedOptions("sorting", configurator);
			return this;
		}

		/// <summary>Configures state storing.</summary>
		[Generated]
		public DataGridBuilder<T> StateStoring(Action<DataGridStateStoringBuilder> configurator)
		{
			NestedOptions("stateStoring", configurator);
			return this;
		}

		/// <summary>Specifies the options of the grid summary.</summary>
		[Generated]
		public DataGridBuilder<T> Summary(Action<DataGridSummaryBuilder<T>> configurator)
		{
			NestedOptions("summary", configurator);
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DataGridBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DataGridBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable two-way data binding.</summary>
		[Generated]
		public DataGridBuilder<T> TwoWayBindingEnabled(bool value)
		{
			base.Options["twoWayBindingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable two-way data binding.</summary>
		[Generated]
		public DataGridBuilder<T> TwoWayBindingEnabled(JS value)
		{
			base.Options["twoWayBindingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DataGridBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DataGridBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DataGridBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DataGridBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DataGridBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a column should be wrapped.</summary>
		[Generated]
		public DataGridBuilder<T> WordWrapEnabled(bool value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a column should be wrapped.</summary>
		[Generated]
		public DataGridBuilder<T> WordWrapEnabled(JS value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}
	}
}
