using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The NavBar is a widget that navigates the application views.</summary>
	public class NavBarBuilder : WidgetBuilder
	{
		[Generated]
		public NavBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public NavBarBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public NavBarBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public NavBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public NavBarBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public NavBarBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public NavBarBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public NavBarBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public NavBarBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public NavBarBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public NavBarBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public NavBarBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public NavBarBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public NavBarBuilder ElementAttr(string attributeName, object value)
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
		public NavBarBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public NavBarBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public NavBarBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public NavBarBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public NavBarBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public NavBarBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public NavBarBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public NavBarBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public NavBarBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public NavBarBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public NavBarBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public NavBarBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public NavBarBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public NavBarBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public NavBarBuilder Items(Action<CollectionFactory<NavBarItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public NavBarBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public NavBarBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public NavBarBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public NavBarBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public NavBarBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys for widget items.</summary>
		[Generated]
		public NavBarBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public NavBarBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public NavBarBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public NavBarBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public NavBarBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public NavBarBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public NavBarBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public NavBarBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public NavBarBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public NavBarBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public NavBarBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public NavBarBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public NavBarBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public NavBarBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public NavBarBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public NavBarBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public NavBarBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public NavBarBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public NavBarBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public NavBarBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public NavBarBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public NavBarBuilder RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether to repaint only those elements whose data changed.</summary>
		[Generated]
		public NavBarBuilder RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public NavBarBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public NavBarBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs by swiping.</summary>
		[Generated]
		public NavBarBuilder ScrollByContent(bool value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll tabs by swiping.</summary>
		[Generated]
		public NavBarBuilder ScrollByContent(JS value)
		{
			base.Options["scrollByContent"] = value;
			return this;
		}

		/// <summary>The index of the currently selected widget item.</summary>
		[Generated]
		public NavBarBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The index of the currently selected widget item.</summary>
		[Generated]
		public NavBarBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public NavBarBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public NavBarBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>Specifies an array of currently selected item keys.</summary>
		[Generated]
		public NavBarBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public NavBarBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Generated]
		public NavBarBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget enables an end-user to select only a single item or multiple items.</summary>
		[Generated]
		public NavBarBuilder SelectionMode(NavSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public NavBarBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public NavBarBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public NavBarBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public NavBarBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public NavBarBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public NavBarBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public NavBarBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
