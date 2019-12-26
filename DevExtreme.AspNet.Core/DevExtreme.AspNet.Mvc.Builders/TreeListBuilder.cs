using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The TreeList is a widget that represents data from a local or remote source in the form of a multi-column tree view. This widget offers such features as sorting, filtering, editing, selection, etc.</summary>
	public class TreeListBuilder<T> : WidgetBuilder
	{
		/// <summary>Specifies what operations are performed on the server.</summary>
		[Obsolete("Use RemoteOperations(Action configurator) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TreeListBuilder<T> RemoteOperations(string value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		/// <summary>Specifies what operations are performed on the server.</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public TreeListBuilder<T> RemoteOperations(JS value)
		{
			base.Options["remoteOperations"] = value;
			return this;
		}

		[Generated]
		public TreeListBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TreeListBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TreeListBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TreeListBuilder<T> AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TreeListBuilder<T> AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TreeListBuilder<T> ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TreeListBuilder<T> ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can reorder columns.</summary>
		[Generated]
		public TreeListBuilder<T> AllowColumnReordering(bool value)
		{
			base.Options["allowColumnReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can reorder columns.</summary>
		[Generated]
		public TreeListBuilder<T> AllowColumnReordering(JS value)
		{
			base.Options["allowColumnReordering"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize columns.</summary>
		[Generated]
		public TreeListBuilder<T> AllowColumnResizing(bool value)
		{
			base.Options["allowColumnResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can resize columns.</summary>
		[Generated]
		public TreeListBuilder<T> AllowColumnResizing(JS value)
		{
			base.Options["allowColumnResizing"] = value;
			return this;
		}

		/// <summary>Specifies whether all rows are expanded initially.</summary>
		[Generated]
		public TreeListBuilder<T> AutoExpandAll(bool value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Specifies whether all rows are expanded initially.</summary>
		[Generated]
		public TreeListBuilder<T> AutoExpandAll(JS value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Automatically scrolls to the focused row when the focusedRowKey is changed.</summary>
		[Generated]
		public TreeListBuilder<T> AutoNavigateToFocusedRow(bool value)
		{
			base.Options["autoNavigateToFocusedRow"] = value;
			return this;
		}

		/// <summary>Automatically scrolls to the focused row when the focusedRowKey is changed.</summary>
		[Generated]
		public TreeListBuilder<T> AutoNavigateToFocusedRow(JS value)
		{
			base.Options["autoNavigateToFocusedRow"] = value;
			return this;
		}

		/// <summary>Specifies whether data should be cached.</summary>
		[Generated]
		public TreeListBuilder<T> CacheEnabled(bool value)
		{
			base.Options["cacheEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether data should be cached.</summary>
		[Generated]
		public TreeListBuilder<T> CacheEnabled(JS value)
		{
			base.Options["cacheEnabled"] = value;
			return this;
		}

		/// <summary>Enables a hint that appears when a user hovers the mouse pointer over a cell with truncated content.</summary>
		[Generated]
		public TreeListBuilder<T> CellHintEnabled(bool value)
		{
			base.Options["cellHintEnabled"] = value;
			return this;
		}

		/// <summary>Enables a hint that appears when a user hovers the mouse pointer over a cell with truncated content.</summary>
		[Generated]
		public TreeListBuilder<T> CellHintEnabled(JS value)
		{
			base.Options["cellHintEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether columns should adjust their widths to the content.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnAutoWidth(bool value)
		{
			base.Options["columnAutoWidth"] = value;
			return this;
		}

		/// <summary>Specifies whether columns should adjust their widths to the content.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnAutoWidth(JS value)
		{
			base.Options["columnAutoWidth"] = value;
			return this;
		}

		/// <summary>Configures the column chooser.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnChooser(Action<TreeListColumnChooserBuilder> configurator)
		{
			NestedOptions("columnChooser", configurator);
			return this;
		}

		/// <summary>Configures column fixing.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnFixing(Action<TreeListColumnFixingBuilder> configurator)
		{
			NestedOptions("columnFixing", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget should hide columns to adapt to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public TreeListBuilder<T> ColumnHidingEnabled(bool value)
		{
			base.Options["columnHidingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget should hide columns to adapt to the screen or container size. Ignored if allowColumnResizing is true and columnResizingMode is "widget".</summary>
		[Generated]
		public TreeListBuilder<T> ColumnHidingEnabled(JS value)
		{
			base.Options["columnHidingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of columns.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnMinWidth(double value)
		{
			base.Options["columnMinWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width of columns.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnMinWidth(JS value)
		{
			base.Options["columnMinWidth"] = value;
			return this;
		}

		/// <summary>Specifies how the widget resizes columns. Applies only if allowColumnResizing is true.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnResizingMode(ColumnResizingMode value)
		{
			base.Options["columnResizingMode"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListBuilder<T> Columns(IEnumerable<string> value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListBuilder<T> Columns(JS value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>Configures columns.</summary>
		[Generated]
		public TreeListBuilder<T> Columns(Action<CollectionFactory<TreeListColumnBuilder<T>>> configurator)
		{
			Collection("columns", configurator);
			return this;
		}

		/// <summary>Specifies the width for all data columns. Has a lower priority than the column.width option.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnWidth(double value)
		{
			base.Options["columnWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width for all data columns. Has a lower priority than the column.width option.</summary>
		[Generated]
		public TreeListBuilder<T> ColumnWidth(JS value)
		{
			base.Options["columnWidth"] = value;
			return this;
		}

		/// <summary>Customizes columns after they are created.</summary>
		[Generated]
		public TreeListBuilder<T> CustomizeColumns(string jsFunc)
		{
			AssignJS("customizeColumns", jsFunc);
			return this;
		}

		/// <summary>Customizes columns after they are created.</summary>
		[Generated]
		public TreeListBuilder<T> CustomizeColumns(RazorBlock jsFunc)
		{
			return CustomizeColumns(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeListBuilder<T> DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeListBuilder<T> DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeListBuilder<T> DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeListBuilder<T> DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeListBuilder<T> DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Notifies the widget of the used data structure.</summary>
		[Generated]
		public TreeListBuilder<T> DataStructure(TreeListDataStructure value)
		{
			base.Options["dataStructure"] = value;
			return this;
		}

		/// <summary>Specifies the format in which date-time values should be sent to the server. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public TreeListBuilder<T> DateSerializationFormat(string value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the format in which date-time values should be sent to the server. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public TreeListBuilder<T> DateSerializationFormat(JS value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TreeListBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TreeListBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Configures editing.</summary>
		[Generated]
		public TreeListBuilder<T> Editing(Action<TreeListEditingBuilder<T>> configurator)
		{
			NestedOptions("editing", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeListBuilder<T> ElementAttr(string attributeName, object value)
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
		public TreeListBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeListBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeListBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Indicates whether to show the error row.</summary>
		[Generated]
		public TreeListBuilder<T> ErrorRowEnabled(bool value)
		{
			base.Options["errorRowEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether to show the error row.</summary>
		[Generated]
		public TreeListBuilder<T> ErrorRowEnabled(JS value)
		{
			base.Options["errorRowEnabled"] = value;
			return this;
		}

		/// <summary>Specifies keys of the initially expanded rows.</summary>
		[Generated]
		public TreeListBuilder<T> ExpandedRowKeys(IEnumerable value)
		{
			base.Options["expandedRowKeys"] = value;
			return this;
		}

		/// <summary>Specifies keys of the initially expanded rows.</summary>
		[Generated]
		public TreeListBuilder<T> ExpandedRowKeys(JS value)
		{
			base.Options["expandedRowKeys"] = value;
			return this;
		}

		/// <summary>Specifies whether nodes appear expanded or collapsed after filtering is applied.</summary>
		[Generated]
		public TreeListBuilder<T> ExpandNodesOnFiltering(bool value)
		{
			base.Options["expandNodesOnFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether nodes appear expanded or collapsed after filtering is applied.</summary>
		[Generated]
		public TreeListBuilder<T> ExpandNodesOnFiltering(JS value)
		{
			base.Options["expandNodesOnFiltering"] = value;
			return this;
		}

		/// <summary>Configures the integrated filter builder.</summary>
		[Generated]
		public TreeListBuilder<T> FilterBuilder(Action<FilterBuilderBuilder<T>> configurator)
		{
			NestedOptions("filterBuilder", configurator);
			return this;
		}

		/// <summary>Configures the popup in which the integrated filter builder is shown.</summary>
		[Generated]
		public TreeListBuilder<T> FilterBuilderPopup(Action<PopupBuilder> configurator)
		{
			NestedOptions("filterBuilderPopup", configurator);
			return this;
		}

		/// <summary>Specifies whether filter and search results should include matching rows only, matching rows with ancestors, or matching rows with ancestors and descendants (full branch).</summary>
		[Generated]
		public TreeListBuilder<T> FilterMode(TreeListFilterMode value)
		{
			base.Options["filterMode"] = value;
			return this;
		}

		/// <summary>Configures the filter panel.</summary>
		[Generated]
		public TreeListBuilder<T> FilterPanel(Action<TreeListFilterPanelBuilder> configurator)
		{
			NestedOptions("filterPanel", configurator);
			return this;
		}

		/// <summary>Configures the filter row.</summary>
		[Generated]
		public TreeListBuilder<T> FilterRow(Action<TreeListFilterRowBuilder> configurator)
		{
			NestedOptions("filterRow", configurator);
			return this;
		}

		/// <summary>Specifies whether to synchronize the filter row, header filter, and filter builder. The synchronized filter expression is stored in the filterValue option.</summary>
		[Generated]
		public TreeListBuilder<T> FilterSyncEnabled(bool value)
		{
			base.Options["filterSyncEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to synchronize the filter row, header filter, and filter builder. The synchronized filter expression is stored in the filterValue option.</summary>
		[Generated]
		public TreeListBuilder<T> FilterSyncEnabled(JS value)
		{
			base.Options["filterSyncEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a filter expression.</summary>
		[Generated]
		public TreeListBuilder<T> FilterValue(string jsExpr)
		{
			AssignJS("filterValue", jsExpr);
			return this;
		}

		/// <summary>Specifies a filter expression.</summary>
		[Generated]
		public TreeListBuilder<T> FilterValue(object filterExpr)
		{
			base.Options["filterValue"] = filterExpr;
			return this;
		}

		/// <summary>Specifies the index of the column focused initially or currently in the data row area.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedColumnIndex(int value)
		{
			base.Options["focusedColumnIndex"] = value;
			return this;
		}

		/// <summary>Specifies the index of the column focused initially or currently in the data row area.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedColumnIndex(JS value)
		{
			base.Options["focusedColumnIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the focused row feature is enabled.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedRowEnabled(bool value)
		{
			base.Options["focusedRowEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the focused row feature is enabled.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedRowEnabled(JS value)
		{
			base.Options["focusedRowEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the initially or currently focused grid row's index. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedRowIndex(int value)
		{
			base.Options["focusedRowIndex"] = value;
			return this;
		}

		/// <summary>Specifies the initially or currently focused grid row's index. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedRowIndex(JS value)
		{
			base.Options["focusedRowIndex"] = value;
			return this;
		}

		/// <summary>Specifies initially or currently focused grid row's key. Use it when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> FocusedRowKey(object value)
		{
			base.Options["focusedRowKey"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TreeListBuilder<T> FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TreeListBuilder<T> FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies which data field defines whether the node has children.</summary>
		[Generated]
		public TreeListBuilder<T> HasItemsExpr(string value)
		{
			base.Options["hasItemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field defines whether the node has children.</summary>
		[Generated]
		public TreeListBuilder<T> HasItemsExpr(JS value)
		{
			base.Options["hasItemsExpr"] = value;
			return this;
		}

		/// <summary>Configures the header filter feature.</summary>
		[Generated]
		public TreeListBuilder<T> HeaderFilter(Action<TreeListHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeListBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeListBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeListBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight rows and cells with edited data. repaintChangesOnly should be true.</summary>
		[Generated]
		public TreeListBuilder<T> HighlightChanges(bool value)
		{
			base.Options["highlightChanges"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight rows and cells with edited data. repaintChangesOnly should be true.</summary>
		[Generated]
		public TreeListBuilder<T> HighlightChanges(JS value)
		{
			base.Options["highlightChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TreeListBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TreeListBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TreeListBuilder<T> HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TreeListBuilder<T> HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies which data field contains nested items. Set this option when your data has a hierarchical structure.</summary>
		[Generated]
		public TreeListBuilder<T> ItemsExpr(string value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field contains nested items. Set this option when your data has a hierarchical structure.</summary>
		[Generated]
		public TreeListBuilder<T> ItemsExpr(JS value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Configures keyboard navigation.</summary>
		[Generated]
		public TreeListBuilder<T> KeyboardNavigation(Action<TreeListKeyboardNavigationBuilder> configurator)
		{
			NestedOptions("keyboardNavigation", configurator);
			return this;
		}

		/// <summary>Specifies which data field provides keys for nodes.</summary>
		[Generated]
		public TreeListBuilder<T> KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for nodes.</summary>
		[Generated]
		public TreeListBuilder<T> KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Configures the load panel.</summary>
		[Generated]
		public TreeListBuilder<T> LoadPanel(Action<TreeListLoadPanelBuilder> configurator)
		{
			NestedOptions("loadPanel", configurator);
			return this;
		}

		/// <summary>Specifies text shown when the widget does not display any data.</summary>
		[Generated]
		public TreeListBuilder<T> NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>Specifies text shown when the widget does not display any data.</summary>
		[Generated]
		public TreeListBuilder<T> NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed before an adaptive detail row is rendered.</summary>
		[Generated]
		public TreeListBuilder<T> OnAdaptiveDetailRowPreparing(string jsFunc)
		{
			AssignJS("onAdaptiveDetailRowPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an adaptive detail row is rendered.</summary>
		[Generated]
		public TreeListBuilder<T> OnAdaptiveDetailRowPreparing(RazorBlock jsFunc)
		{
			return OnAdaptiveDetailRowPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a cell is clicked or tapped. Executed before onRowClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellClick(string jsFunc)
		{
			AssignJS("onCellClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a cell is clicked or tapped. Executed before onRowClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellClick(RazorBlock jsFunc)
		{
			return OnCellClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a cell is double-clicked or double-tapped. Executed before onRowDblClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellDblClick(string jsFunc)
		{
			AssignJS("onCellDblClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a cell is double-clicked or double-tapped. Executed before onRowDblClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellDblClick(RazorBlock jsFunc)
		{
			return OnCellDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a cell.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellHoverChanged(string jsFunc)
		{
			AssignJS("onCellHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a cell.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellHoverChanged(RazorBlock jsFunc)
		{
			return OnCellHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a grid cell is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellPrepared(string jsFunc)
		{
			AssignJS("onCellPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a grid cell is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnCellPrepared(RazorBlock jsFunc)
		{
			return OnCellPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TreeListBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TreeListBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public TreeListBuilder<T> OnContextMenuPreparing(string jsFunc)
		{
			AssignJS("onContextMenuPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public TreeListBuilder<T> OnContextMenuPreparing(RazorBlock jsFunc)
		{
			return OnContextMenuPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error occurs in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnDataErrorOccurred(string jsFunc)
		{
			AssignJS("onDataErrorOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error occurs in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnDataErrorOccurred(RazorBlock jsFunc)
		{
			return OnDataErrorOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeListBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeListBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a cell or row switches to the editing state.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditingStart(string jsFunc)
		{
			AssignJS("onEditingStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a cell or row switches to the editing state.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditingStart(RazorBlock jsFunc)
		{
			return OnEditingStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after an editor is created. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditorPrepared(string jsFunc)
		{
			AssignJS("onEditorPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an editor is created. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditorPrepared(RazorBlock jsFunc)
		{
			return OnEditorPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used to customize or replace default editors. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditorPreparing(string jsFunc)
		{
			AssignJS("onEditorPreparing", jsFunc);
			return this;
		}

		/// <summary>A function used to customize or replace default editors. Not executed for cells with an editCellTemplate.</summary>
		[Generated]
		public TreeListBuilder<T> OnEditorPreparing(RazorBlock jsFunc)
		{
			return OnEditorPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the focused cell changes.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedCellChanged(string jsFunc)
		{
			AssignJS("onFocusedCellChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the focused cell changes.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedCellChanged(RazorBlock jsFunc)
		{
			return OnFocusedCellChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the focused cell changes.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedCellChanging(string jsFunc)
		{
			AssignJS("onFocusedCellChanging", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the focused cell changes.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedCellChanging(RazorBlock jsFunc)
		{
			return OnFocusedCellChanging(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that executed when the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedRowChanged(string jsFunc)
		{
			AssignJS("onFocusedRowChanged", jsFunc);
			return this;
		}

		/// <summary>A function that executed when the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedRowChanged(RazorBlock jsFunc)
		{
			return OnFocusedRowChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedRowChanging(string jsFunc)
		{
			AssignJS("onFocusedRowChanging", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the focused row changes. Applies only when focusedRowEnabled is true.</summary>
		[Generated]
		public TreeListBuilder<T> OnFocusedRowChanging(RazorBlock jsFunc)
		{
			return OnFocusedRowChanging(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeListBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeListBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a new row is added to the widget.</summary>
		[Generated]
		public TreeListBuilder<T> OnInitNewRow(string jsFunc)
		{
			AssignJS("onInitNewRow", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a new row is added to the widget.</summary>
		[Generated]
		public TreeListBuilder<T> OnInitNewRow(RazorBlock jsFunc)
		{
			return OnInitNewRow(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget is in focus and a key has been pressed down.</summary>
		[Generated]
		public TreeListBuilder<T> OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget is in focus and a key has been pressed down.</summary>
		[Generated]
		public TreeListBuilder<T> OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the loaded nodes are initialized.</summary>
		[Generated]
		public TreeListBuilder<T> OnNodesInitialized(string jsFunc)
		{
			AssignJS("onNodesInitialized", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the loaded nodes are initialized.</summary>
		[Generated]
		public TreeListBuilder<T> OnNodesInitialized(RazorBlock jsFunc)
		{
			return OnNodesInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeListBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeListBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a grid row is clicked or tapped.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowClick(string jsFunc)
		{
			AssignJS("onRowClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a grid row is clicked or tapped.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowClick(RazorBlock jsFunc)
		{
			return OnRowClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is collapsed.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowCollapsed(string jsFunc)
		{
			AssignJS("onRowCollapsed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is collapsed.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowCollapsed(RazorBlock jsFunc)
		{
			return OnRowCollapsed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is collapsed.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowCollapsing(string jsFunc)
		{
			AssignJS("onRowCollapsing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is collapsed.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowCollapsing(RazorBlock jsFunc)
		{
			return OnRowCollapsing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a row is double-clicked or double-tapped. Executed after onCellDblClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowDblClick(string jsFunc)
		{
			AssignJS("onRowDblClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a row is double-clicked or double-tapped. Executed after onCellDblClick.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowDblClick(RazorBlock jsFunc)
		{
			return OnRowDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is expanded.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowExpanded(string jsFunc)
		{
			AssignJS("onRowExpanded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is expanded.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowExpanded(RazorBlock jsFunc)
		{
			return OnRowExpanded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is expanded.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowExpanding(string jsFunc)
		{
			AssignJS("onRowExpanding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is expanded.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowExpanding(RazorBlock jsFunc)
		{
			return OnRowExpanding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a new row has been inserted into the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowInserted(string jsFunc)
		{
			AssignJS("onRowInserted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a new row has been inserted into the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowInserted(RazorBlock jsFunc)
		{
			return OnRowInserted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a new row is inserted into the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowInserting(string jsFunc)
		{
			AssignJS("onRowInserting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a new row is inserted into the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowInserting(RazorBlock jsFunc)
		{
			return OnRowInserting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowPrepared(string jsFunc)
		{
			AssignJS("onRowPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowPrepared(RazorBlock jsFunc)
		{
			return OnRowPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row has been removed from the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowRemoved(string jsFunc)
		{
			AssignJS("onRowRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row has been removed from the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowRemoved(RazorBlock jsFunc)
		{
			return OnRowRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is removed from the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowRemoving(string jsFunc)
		{
			AssignJS("onRowRemoving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is removed from the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowRemoving(RazorBlock jsFunc)
		{
			return OnRowRemoving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a row has been updated in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowUpdated(string jsFunc)
		{
			AssignJS("onRowUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a row has been updated in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowUpdated(RazorBlock jsFunc)
		{
			return OnRowUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a row is updated in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowUpdating(string jsFunc)
		{
			AssignJS("onRowUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a row is updated in the data source.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowUpdating(RazorBlock jsFunc)
		{
			return OnRowUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after cells in a row are validated against validation rules.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowValidating(string jsFunc)
		{
			AssignJS("onRowValidating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after cells in a row are validated against validation rules.</summary>
		[Generated]
		public TreeListBuilder<T> OnRowValidating(RazorBlock jsFunc)
		{
			return OnRowValidating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after selecting a row or clearing its selection.</summary>
		[Generated]
		public TreeListBuilder<T> OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after selecting a row or clearing its selection.</summary>
		[Generated]
		public TreeListBuilder<T> OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the toolbar is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnToolbarPreparing(string jsFunc)
		{
			AssignJS("onToolbarPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the toolbar is created.</summary>
		[Generated]
		public TreeListBuilder<T> OnToolbarPreparing(RazorBlock jsFunc)
		{
			return OnToolbarPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Configures the pager.</summary>
		[Generated]
		public TreeListBuilder<T> Pager(Action<TreeListPagerBuilder> configurator)
		{
			NestedOptions("pager", configurator);
			return this;
		}

		/// <summary>Configures paging.</summary>
		[Generated]
		public TreeListBuilder<T> Paging(Action<TreeListPagingBuilder> configurator)
		{
			NestedOptions("paging", configurator);
			return this;
		}

		/// <summary>Specifies which data field provides parent keys.</summary>
		[Generated]
		public TreeListBuilder<T> ParentIdExpr(string value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides parent keys.</summary>
		[Generated]
		public TreeListBuilder<T> ParentIdExpr(JS value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Notifies the TreeList of the server's data processing operations. Applies only if data has a plain structure.</summary>
		[Generated]
		public TreeListBuilder<T> RemoteOperations(Action<TreeListRemoteOperationsBuilder> configurator)
		{
			NestedOptions("remoteOperations", configurator);
			return this;
		}

		/// <summary>Specifies whether to render the filter row, command columns, and columns with showEditorAlways set to true after other elements.</summary>
		[Generated]
		public TreeListBuilder<T> RenderAsync(bool value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the filter row, command columns, and columns with showEditorAlways set to true after other elements.</summary>
		[Generated]
		public TreeListBuilder<T> RenderAsync(JS value)
		{
			base.Options["renderAsync"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those cells whose data changed.</summary>
		[Generated]
		public TreeListBuilder<T> RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those cells whose data changed.</summary>
		[Generated]
		public TreeListBuilder<T> RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies the root node's identifier. Applies if dataStructure is "plain".</summary>
		[Generated]
		public TreeListBuilder<T> RootValue(object value)
		{
			base.Options["rootValue"] = value;
			return this;
		}

		/// <summary>Specifies whether rows should be shaded differently.</summary>
		[Generated]
		public TreeListBuilder<T> RowAlternationEnabled(bool value)
		{
			base.Options["rowAlternationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether rows should be shaded differently.</summary>
		[Generated]
		public TreeListBuilder<T> RowAlternationEnabled(JS value)
		{
			base.Options["rowAlternationEnabled"] = value;
			return this;
		}

		/// <summary>Configures row reordering using drag and drop gestures.</summary>
		[Generated]
		public TreeListBuilder<T> RowDragging(Action<TreeListRowDraggingBuilder> configurator)
		{
			NestedOptions("rowDragging", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeListBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeListBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Configures scrolling.</summary>
		[Generated]
		public TreeListBuilder<T> Scrolling(Action<TreeListScrollingBuilder> configurator)
		{
			NestedOptions("scrolling", configurator);
			return this;
		}

		/// <summary>Configures the search panel.</summary>
		[Generated]
		public TreeListBuilder<T> SearchPanel(Action<TreeListSearchPanelBuilder> configurator)
		{
			NestedOptions("searchPanel", configurator);
			return this;
		}

		/// <summary>Allows you to select rows or determine which rows are selected.</summary>
		[Generated]
		public TreeListBuilder<T> SelectedRowKeys(IEnumerable value)
		{
			base.Options["selectedRowKeys"] = value;
			return this;
		}

		/// <summary>Allows you to select rows or determine which rows are selected.</summary>
		[Generated]
		public TreeListBuilder<T> SelectedRowKeys(JS value)
		{
			base.Options["selectedRowKeys"] = value;
			return this;
		}

		/// <summary>Configures runtime selection.</summary>
		[Generated]
		public TreeListBuilder<T> Selection(Action<TreeListSelectionBuilder> configurator)
		{
			NestedOptions("selection", configurator);
			return this;
		}

		/// <summary>Specifies whether the outer borders of the widget are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowBorders(bool value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether the outer borders of the widget are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowBorders(JS value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether column headers are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowColumnHeaders(bool value)
		{
			base.Options["showColumnHeaders"] = value;
			return this;
		}

		/// <summary>Specifies whether column headers are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowColumnHeaders(JS value)
		{
			base.Options["showColumnHeaders"] = value;
			return this;
		}

		/// <summary>Specifies whether vertical lines that separate one column from another are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowColumnLines(bool value)
		{
			base.Options["showColumnLines"] = value;
			return this;
		}

		/// <summary>Specifies whether vertical lines that separate one column from another are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowColumnLines(JS value)
		{
			base.Options["showColumnLines"] = value;
			return this;
		}

		/// <summary>Specifies whether horizontal lines that separate one row from another are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowRowLines(bool value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Specifies whether horizontal lines that separate one row from another are visible.</summary>
		[Generated]
		public TreeListBuilder<T> ShowRowLines(JS value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Configures runtime sorting.</summary>
		[Generated]
		public TreeListBuilder<T> Sorting(Action<TreeListSortingBuilder> configurator)
		{
			NestedOptions("sorting", configurator);
			return this;
		}

		/// <summary>Configures state storing.</summary>
		[Generated]
		public TreeListBuilder<T> StateStoring(Action<TreeListStateStoringBuilder> configurator)
		{
			NestedOptions("stateStoring", configurator);
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TreeListBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TreeListBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable two-way data binding.</summary>
		[Generated]
		public TreeListBuilder<T> TwoWayBindingEnabled(bool value)
		{
			base.Options["twoWayBindingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable two-way data binding.</summary>
		[Generated]
		public TreeListBuilder<T> TwoWayBindingEnabled(JS value)
		{
			base.Options["twoWayBindingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TreeListBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TreeListBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeListBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeListBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeListBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a column should be wrapped.</summary>
		[Generated]
		public TreeListBuilder<T> WordWrapEnabled(bool value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether text that does not fit into a column should be wrapped.</summary>
		[Generated]
		public TreeListBuilder<T> WordWrapEnabled(JS value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}
	}
}
