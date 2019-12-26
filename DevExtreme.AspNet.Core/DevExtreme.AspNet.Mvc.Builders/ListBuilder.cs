using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The List is a widget that represents a collection of items in a scrollable list.</summary>
	public class ListBuilder : WidgetBuilder
	{
		[Generated]
		public ListBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ListBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ListBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ListBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ListBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ListBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ListBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ListBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end user can delete list items.</summary>
		[Generated]
		public ListBuilder AllowItemDeleting(bool value)
		{
			base.Options["allowItemDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end user can delete list items.</summary>
		[Generated]
		public ListBuilder AllowItemDeleting(JS value)
		{
			base.Options["allowItemDeleting"] = value;
			return this;
		}

		[Obsolete("Use the itemDragging option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ListBuilder AllowItemReordering(bool value)
		{
			base.Options["allowItemReordering"] = value;
			return this;
		}

		[Obsolete("Use the itemDragging option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ListBuilder AllowItemReordering(JS value)
		{
			base.Options["allowItemReordering"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable the bounce-back effect.</summary>
		[Generated]
		public ListBuilder BounceEnabled(bool value)
		{
			base.Options["bounceEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable the bounce-back effect.</summary>
		[Generated]
		public ListBuilder BounceEnabled(JS value)
		{
			base.Options["bounceEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can collapse groups.</summary>
		[Generated]
		public ListBuilder CollapsibleGroups(bool value)
		{
			base.Options["collapsibleGroups"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can collapse groups.</summary>
		[Generated]
		public ListBuilder CollapsibleGroups(JS value)
		{
			base.Options["collapsibleGroups"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ListBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ListBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ListBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ListBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ListBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ListBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ListBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed. Defaults to "text" when the data source contains objects.</summary>
		[Generated]
		public ListBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed. Defaults to "text" when the data source contains objects.</summary>
		[Generated]
		public ListBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ListBuilder ElementAttr(string attributeName, object value)
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
		public ListBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ListBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ListBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ListBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ListBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public ListBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public ListBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public ListBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public ListBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public ListBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public ListBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ListBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ListBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ListBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ListBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ListBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ListBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ListBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the loading panel when the DataSource bound to the widget is loading data.</summary>
		[Generated]
		public ListBuilder IndicateLoading(bool value)
		{
			base.Options["indicateLoading"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the loading panel when the DataSource bound to the widget is loading data.</summary>
		[Generated]
		public ListBuilder IndicateLoading(JS value)
		{
			base.Options["indicateLoading"] = value;
			return this;
		}

		/// <summary>Specifies the way a user can delete items from the list.</summary>
		[Generated]
		public ListBuilder ItemDeleteMode(ListItemDeleteMode value)
		{
			base.Options["itemDeleteMode"] = value;
			return this;
		}

		/// <summary>Configures item reordering using drag and drop gestures.</summary>
		[Generated]
		public ListBuilder ItemDragging(Action<SortableBuilder> configurator)
		{
			NestedOptions("itemDragging", configurator);
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public ListBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public ListBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public ListBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public ListBuilder Items(Action<CollectionFactory<ListItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ListBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ListBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ListBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ListBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public ListBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public ListBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies the array of items for a context menu called for a list item.</summary>
		[Generated]
		public ListBuilder MenuItems(Action<CollectionFactory<ListMenuItemBuilder>> configurator)
		{
			Collection("menuItems", configurator);
			return this;
		}

		/// <summary>Specifies whether an item context menu is shown when a user holds or swipes an item.</summary>
		[Generated]
		public ListBuilder MenuMode(ListMenuMode value)
		{
			base.Options["menuMode"] = value;
			return this;
		}

		/// <summary>The text displayed on the button used to load the next page from the data source.</summary>
		[Generated]
		public ListBuilder NextButtonText(string value)
		{
			base.Options["nextButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the button used to load the next page from the data source.</summary>
		[Generated]
		public ListBuilder NextButtonText(JS value)
		{
			base.Options["nextButtonText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public ListBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public ListBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ListBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ListBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ListBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ListBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a group element is rendered.</summary>
		[Generated]
		public ListBuilder OnGroupRendered(string jsFunc)
		{
			AssignJS("onGroupRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a group element is rendered.</summary>
		[Generated]
		public ListBuilder OnGroupRendered(RazorBlock jsFunc)
		{
			return OnGroupRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ListBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ListBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ListBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ListBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ListBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ListBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a list item is deleted from the data source.</summary>
		[Generated]
		public ListBuilder OnItemDeleted(string jsFunc)
		{
			AssignJS("onItemDeleted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a list item is deleted from the data source.</summary>
		[Generated]
		public ListBuilder OnItemDeleted(RazorBlock jsFunc)
		{
			return OnItemDeleted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a collection item is deleted from the data source.</summary>
		[Generated]
		public ListBuilder OnItemDeleting(string jsFunc)
		{
			AssignJS("onItemDeleting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a collection item is deleted from the data source.</summary>
		[Generated]
		public ListBuilder OnItemDeleting(RazorBlock jsFunc)
		{
			return OnItemDeleting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public ListBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public ListBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ListBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ListBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a list item is moved to another position.</summary>
		[Generated]
		public ListBuilder OnItemReordered(string jsFunc)
		{
			AssignJS("onItemReordered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a list item is moved to another position.</summary>
		[Generated]
		public ListBuilder OnItemReordered(RazorBlock jsFunc)
		{
			return OnItemReordered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is swiped.</summary>
		[Generated]
		public ListBuilder OnItemSwipe(string jsFunc)
		{
			AssignJS("onItemSwipe", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is swiped.</summary>
		[Generated]
		public ListBuilder OnItemSwipe(RazorBlock jsFunc)
		{
			return OnItemSwipe(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ListBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ListBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the next page is loaded.</summary>
		[Generated]
		public ListBuilder OnPageLoading(string jsFunc)
		{
			AssignJS("onPageLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the next page is loaded.</summary>
		[Generated]
		public ListBuilder OnPageLoading(RazorBlock jsFunc)
		{
			return OnPageLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed. Supported in mobile themes only.</summary>
		[Generated]
		public ListBuilder OnPullRefresh(string jsFunc)
		{
			AssignJS("onPullRefresh", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed. Supported in mobile themes only.</summary>
		[Generated]
		public ListBuilder OnPullRefresh(RazorBlock jsFunc)
		{
			return OnPullRefresh(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed on each scroll gesture.</summary>
		[Generated]
		public ListBuilder OnScroll(string jsFunc)
		{
			AssignJS("onScroll", jsFunc);
			return this;
		}

		/// <summary>A function that is executed on each scroll gesture.</summary>
		[Generated]
		public ListBuilder OnScroll(RazorBlock jsFunc)
		{
			return OnScroll(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if the selectionMode is "all".</summary>
		[Generated]
		public ListBuilder OnSelectAllValueChanged(string jsFunc)
		{
			AssignJS("onSelectAllValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if the selectionMode is "all".</summary>
		[Generated]
		public ListBuilder OnSelectAllValueChanged(RazorBlock jsFunc)
		{
			return OnSelectAllValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public ListBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public ListBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the text shown in the pullDown panel, which is displayed when the list is scrolled to the bottom.</summary>
		[Generated]
		public ListBuilder PageLoadingText(string value)
		{
			base.Options["pageLoadingText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel, which is displayed when the list is scrolled to the bottom.</summary>
		[Generated]
		public ListBuilder PageLoadingText(JS value)
		{
			base.Options["pageLoadingText"] = value;
			return this;
		}

		/// <summary>Specifies whether the next page is loaded when a user scrolls the widget to the bottom or when the "next" button is clicked.</summary>
		[Generated]
		public ListBuilder PageLoadMode(ListPageLoadMode value)
		{
			base.Options["pageLoadMode"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel when the list is pulled below the refresh threshold.</summary>
		[Generated]
		public ListBuilder PulledDownText(string value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel when the list is pulled below the refresh threshold.</summary>
		[Generated]
		public ListBuilder PulledDownText(JS value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while the list is being pulled down to the refresh threshold.</summary>
		[Generated]
		public ListBuilder PullingDownText(string value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while the list is being pulled down to the refresh threshold.</summary>
		[Generated]
		public ListBuilder PullingDownText(JS value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget supports the "pull down to refresh" gesture.</summary>
		[Generated]
		public ListBuilder PullRefreshEnabled(bool value)
		{
			base.Options["pullRefreshEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget supports the "pull down to refresh" gesture.</summary>
		[Generated]
		public ListBuilder PullRefreshEnabled(JS value)
		{
			base.Options["pullRefreshEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel while the list is being refreshed.</summary>
		[Generated]
		public ListBuilder RefreshingText(string value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel while the list is being refreshed.</summary>
		[Generated]
		public ListBuilder RefreshingText(JS value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public ListBuilder RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public ListBuilder RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ListBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ListBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying if the list is scrolled by content.</summary>
		[Generated]
		public ListBuilder ScrollByContent(bool value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying if the list is scrolled by content.</summary>
		[Generated]
		public ListBuilder ScrollByContent(JS value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying if the list is scrolled using the scrollbar.</summary>
		[Generated]
		public ListBuilder ScrollByThumb(bool value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying if the list is scrolled using the scrollbar.</summary>
		[Generated]
		public ListBuilder ScrollByThumb(JS value)
		{
			base.Options["scrollByThumb"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable list scrolling.</summary>
		[Generated]
		public ListBuilder ScrollingEnabled(bool value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable list scrolling.</summary>
		[Generated]
		public ListBuilder ScrollingEnabled(JS value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>Configures the search panel.</summary>
		[Generated]
		public ListBuilder SearchEditorOptions(Action<TextBoxBuilder> configurator)
		{
			NestedOptions("searchEditorOptions", configurator);
			return this;
		}

		/// <summary>Specifies whether the search panel is visible.</summary>
		[Generated]
		public ListBuilder SearchEnabled(bool value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the search panel is visible.</summary>
		[Generated]
		public ListBuilder SearchEnabled(JS value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public ListBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public ListBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a data object's field name or an expression whose value is compared to the search string.</summary>
		[Generated]
		public ListBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search widget items.</summary>
		[Generated]
		public ListBuilder SearchMode(CollectionSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing, and the search is executed.</summary>
		[Generated]
		public ListBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing, and the search is executed.</summary>
		[Generated]
		public ListBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the current search string.</summary>
		[Generated]
		public ListBuilder SearchValue(string value)
		{
			base.Options["searchValue"] = value;
			return this;
		}

		/// <summary>Specifies the current search string.</summary>
		[Generated]
		public ListBuilder SearchValue(JS value)
		{
			base.Options["searchValue"] = value;
			return this;
		}

		/// <summary>Specifies the mode in which all items are selected.</summary>
		[Generated]
		public ListBuilder SelectAllMode(SelectAllMode value)
		{
			base.Options["selectAllMode"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public ListBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public ListBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public ListBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public ListBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>Specifies item selection mode.</summary>
		[Generated]
		public ListBuilder SelectionMode(ListSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies when the widget shows the scrollbar.</summary>
		[Generated]
		public ListBuilder ShowScrollbar(ShowScrollbarMode value)
		{
			base.Options["showScrollbar"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display controls used to select list items.</summary>
		[Generated]
		public ListBuilder ShowSelectionControls(bool value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display controls used to select list items.</summary>
		[Generated]
		public ListBuilder ShowSelectionControls(JS value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ListBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ListBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public ListBuilder UseNativeScrolling(bool value)
		{
			base.Options["useNativeScrolling"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public ListBuilder UseNativeScrolling(JS value)
		{
			base.Options["useNativeScrolling"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ListBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ListBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ListBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ListBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ListBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
