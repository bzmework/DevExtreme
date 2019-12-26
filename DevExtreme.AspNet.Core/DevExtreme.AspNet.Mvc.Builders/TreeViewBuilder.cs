using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The TreeView widget is a tree-like representation of textual data.</summary>
	public class TreeViewBuilder : WidgetBuilder
	{
		[Generated]
		public TreeViewBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TreeViewBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TreeViewBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeViewBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TreeViewBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TreeViewBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TreeViewBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TreeViewBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to animate item collapsing and expanding.</summary>
		[Generated]
		public TreeViewBuilder AnimationEnabled(bool value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to animate item collapsing and expanding.</summary>
		[Generated]
		public TreeViewBuilder AnimationEnabled(JS value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Allows you to load nodes on demand.</summary>
		[Generated]
		public TreeViewBuilder CreateChildren(string jsFunc)
		{
			AssignJS("createChildren", jsFunc);
			return this;
		}

		/// <summary>Allows you to load nodes on demand.</summary>
		[Generated]
		public TreeViewBuilder CreateChildren(RazorBlock jsFunc)
		{
			return CreateChildren(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeViewBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeViewBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeViewBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeViewBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeViewBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Notifies the widget of the used data structure.</summary>
		[Generated]
		public TreeViewBuilder DataStructure(TreeViewDataStructure value)
		{
			base.Options["dataStructure"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TreeViewBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TreeViewBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public TreeViewBuilder DisabledExpr(string value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public TreeViewBuilder DisabledExpr(JS value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public TreeViewBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public TreeViewBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeViewBuilder ElementAttr(string attributeName, object value)
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
		public TreeViewBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeViewBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeViewBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a user can expand all tree view items by the "*" hot key.</summary>
		[Generated]
		public TreeViewBuilder ExpandAllEnabled(bool value)
		{
			base.Options["expandAllEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a user can expand all tree view items by the "*" hot key.</summary>
		[Generated]
		public TreeViewBuilder ExpandAllEnabled(JS value)
		{
			base.Options["expandAllEnabled"] = value;
			return this;
		}

		/// <summary>Specifies which data source field specifies whether an item is expanded.</summary>
		[Generated]
		public TreeViewBuilder ExpandedExpr(string value)
		{
			base.Options["expandedExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data source field specifies whether an item is expanded.</summary>
		[Generated]
		public TreeViewBuilder ExpandedExpr(JS value)
		{
			base.Options["expandedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the event on which to expand/collapse a node.</summary>
		[Generated]
		public TreeViewBuilder ExpandEvent(TreeViewExpandEvent value)
		{
			base.Options["expandEvent"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all parent nodes of an initially expanded node are displayed expanded.</summary>
		[Generated]
		public TreeViewBuilder ExpandNodesRecursive(bool value)
		{
			base.Options["expandNodesRecursive"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all parent nodes of an initially expanded node are displayed expanded.</summary>
		[Generated]
		public TreeViewBuilder ExpandNodesRecursive(JS value)
		{
			base.Options["expandNodesRecursive"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TreeViewBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TreeViewBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding node includes child nodes.</summary>
		[Generated]
		public TreeViewBuilder HasItemsExpr(string value)
		{
			base.Options["hasItemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding node includes child nodes.</summary>
		[Generated]
		public TreeViewBuilder HasItemsExpr(JS value)
		{
			base.Options["hasItemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeViewBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeViewBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TreeViewBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TreeViewBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TreeViewBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TreeViewBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TreeViewBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public TreeViewBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public TreeViewBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public TreeViewBuilder Items(Action<CollectionFactory<TreeViewItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public TreeViewBuilder ItemsExpr(string value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public TreeViewBuilder ItemsExpr(JS value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TreeViewBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TreeViewBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TreeViewBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TreeViewBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for TreeView items.</summary>
		[Generated]
		public TreeViewBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for TreeView items.</summary>
		[Generated]
		public TreeViewBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TreeViewBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TreeViewBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TreeViewBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TreeViewBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeViewBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeViewBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeViewBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeViewBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public TreeViewBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public TreeViewBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tree view item is collapsed.</summary>
		[Generated]
		public TreeViewBuilder OnItemCollapsed(string jsFunc)
		{
			AssignJS("onItemCollapsed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tree view item is collapsed.</summary>
		[Generated]
		public TreeViewBuilder OnItemCollapsed(RazorBlock jsFunc)
		{
			return OnItemCollapsed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public TreeViewBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public TreeViewBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tree view item is expanded.</summary>
		[Generated]
		public TreeViewBuilder OnItemExpanded(string jsFunc)
		{
			AssignJS("onItemExpanded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tree view item is expanded.</summary>
		[Generated]
		public TreeViewBuilder OnItemExpanded(RazorBlock jsFunc)
		{
			return OnItemExpanded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public TreeViewBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public TreeViewBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public TreeViewBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public TreeViewBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tree view item is selected or selection is canceled.</summary>
		[Generated]
		public TreeViewBuilder OnItemSelectionChanged(string jsFunc)
		{
			AssignJS("onItemSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tree view item is selected or selection is canceled.</summary>
		[Generated]
		public TreeViewBuilder OnItemSelectionChanged(RazorBlock jsFunc)
		{
			return OnItemSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeViewBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeViewBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if showCheckBoxesMode is "selectAll" and selectionMode is "multiple".</summary>
		[Generated]
		public TreeViewBuilder OnSelectAllValueChanged(string jsFunc)
		{
			AssignJS("onSelectAllValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if showCheckBoxesMode is "selectAll" and selectionMode is "multiple".</summary>
		[Generated]
		public TreeViewBuilder OnSelectAllValueChanged(RazorBlock jsFunc)
		{
			return OnSelectAllValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tree view item is selected or selection is canceled.</summary>
		[Generated]
		public TreeViewBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tree view item is selected or selection is canceled.</summary>
		[Generated]
		public TreeViewBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the name of the data source item field for holding the parent key of the corresponding node.</summary>
		[Generated]
		public TreeViewBuilder ParentIdExpr(string value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field for holding the parent key of the corresponding node.</summary>
		[Generated]
		public TreeViewBuilder ParentIdExpr(JS value)
		{
			base.Options["parentIdExpr"] = value;
			return this;
		}

		/// <summary>Specifies the parent ID value of the root item.</summary>
		[Generated]
		public TreeViewBuilder RootValue(object value)
		{
			base.Options["rootValue"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeViewBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeViewBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>A string value specifying available scrolling directions.</summary>
		[Generated]
		public TreeViewBuilder ScrollDirection(ScrollDirection value)
		{
			base.Options["scrollDirection"] = value;
			return this;
		}

		/// <summary>Configures the search panel.</summary>
		[Generated]
		public TreeViewBuilder SearchEditorOptions(Action<TextBoxBuilder> configurator)
		{
			NestedOptions("searchEditorOptions", configurator);
			return this;
		}

		/// <summary>Specifies whether the search panel is visible.</summary>
		[Generated]
		public TreeViewBuilder SearchEnabled(bool value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the search panel is visible.</summary>
		[Generated]
		public TreeViewBuilder SearchEnabled(JS value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public TreeViewBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public TreeViewBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public TreeViewBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search widget items.</summary>
		[Generated]
		public TreeViewBuilder SearchMode(CollectionSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing, and the search is executed.</summary>
		[Generated]
		public TreeViewBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing, and the search is executed.</summary>
		[Generated]
		public TreeViewBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the current search string.</summary>
		[Generated]
		public TreeViewBuilder SearchValue(string value)
		{
			base.Options["searchValue"] = value;
			return this;
		}

		/// <summary>Specifies the current search string.</summary>
		[Generated]
		public TreeViewBuilder SearchValue(JS value)
		{
			base.Options["searchValue"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed at the "Select All" check box.</summary>
		[Generated]
		public TreeViewBuilder SelectAllText(string value)
		{
			base.Options["selectAllText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed at the "Select All" check box.</summary>
		[Generated]
		public TreeViewBuilder SelectAllText(JS value)
		{
			base.Options["selectAllText"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public TreeViewBuilder SelectByClick(bool value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public TreeViewBuilder SelectByClick(JS value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public TreeViewBuilder SelectedExpr(string value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public TreeViewBuilder SelectedExpr(JS value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>Specifies item selection mode.</summary>
		[Generated]
		public TreeViewBuilder SelectionMode(NavSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to select nodes recursively.</summary>
		[Generated]
		public TreeViewBuilder SelectNodesRecursive(bool value)
		{
			base.Options["selectNodesRecursive"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to select nodes recursively.</summary>
		[Generated]
		public TreeViewBuilder SelectNodesRecursive(JS value)
		{
			base.Options["selectNodesRecursive"] = value;
			return this;
		}

		/// <summary>Specifies the current check boxes display mode.</summary>
		[Generated]
		public TreeViewBuilder ShowCheckBoxesMode(TreeViewCheckBoxMode value)
		{
			base.Options["showCheckBoxesMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TreeViewBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TreeViewBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Enables the virtual mode in which nodes are loaded on demand. Use it to enhance the performance on large datasets.</summary>
		[Generated]
		public TreeViewBuilder VirtualModeEnabled(bool value)
		{
			base.Options["virtualModeEnabled"] = value;
			return this;
		}

		/// <summary>Enables the virtual mode in which nodes are loaded on demand. Use it to enhance the performance on large datasets.</summary>
		[Generated]
		public TreeViewBuilder VirtualModeEnabled(JS value)
		{
			base.Options["virtualModeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TreeViewBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TreeViewBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeViewBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeViewBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TreeViewBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
