using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Tabs is a tab strip used to switch between pages or views. This widget is included in the TabPanel widget, but you can use the Tabs separately as well.</summary>
	public class TabsBuilder : WidgetBuilder
	{
		[Generated]
		public TabsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TabsBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TabsBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TabsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TabsBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TabsBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TabsBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TabsBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TabsBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TabsBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TabsBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TabsBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TabsBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TabsBuilder ElementAttr(string attributeName, object value)
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
		public TabsBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TabsBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TabsBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TabsBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TabsBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TabsBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TabsBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TabsBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TabsBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TabsBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TabsBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TabsBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public TabsBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public TabsBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public TabsBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public TabsBuilder Items(Action<CollectionFactory<TabsItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TabsBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TabsBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TabsBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TabsBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public TabsBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public TabsBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TabsBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TabsBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TabsBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TabsBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TabsBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TabsBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TabsBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TabsBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public TabsBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public TabsBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public TabsBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public TabsBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public TabsBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public TabsBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public TabsBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public TabsBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TabsBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TabsBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public TabsBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public TabsBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public TabsBuilder RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public TabsBuilder RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TabsBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TabsBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs by swiping.</summary>
		[Generated]
		public TabsBuilder ScrollByContent(bool value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs by swiping.</summary>
		[Generated]
		public TabsBuilder ScrollByContent(JS value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs.</summary>
		[Generated]
		public TabsBuilder ScrollingEnabled(bool value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs.</summary>
		[Generated]
		public TabsBuilder ScrollingEnabled(JS value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>The index of the currently selected widget item.</summary>
		[Generated]
		public TabsBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The index of the currently selected widget item.</summary>
		[Generated]
		public TabsBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public TabsBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public TabsBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public TabsBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public TabsBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public TabsBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget enables an end-user to select only a single item or multiple items.</summary>
		[Generated]
		public TabsBuilder SelectionMode(NavSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether navigation buttons should be available when tabs exceed the widget's width.</summary>
		[Generated]
		public TabsBuilder ShowNavButtons(bool value)
		{
			base.Options["showNavButtons"] = value;
			return this;
		}

		/// <summary>Specifies whether navigation buttons should be available when tabs exceed the widget's width.</summary>
		[Generated]
		public TabsBuilder ShowNavButtons(JS value)
		{
			base.Options["showNavButtons"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TabsBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TabsBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TabsBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TabsBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TabsBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TabsBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TabsBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
