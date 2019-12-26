using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The SlideOut widget is a classic slide-out menu paired with a view. An end user opens the menu by swiping away the view.</summary>
	public class SlideOutBuilder : WidgetBuilder
	{
		[Generated]
		public SlideOutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SlideOutBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SlideOutBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SlideOutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SlideOutBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SlideOutBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content. Rendered only once - when the widget is created.</summary>
		[Generated]
		public SlideOutBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content. Rendered only once - when the widget is created.</summary>
		[Generated]
		public SlideOutBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content. Rendered only once - when the widget is created.</summary>
		[Generated]
		public SlideOutBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content. Rendered only once - when the widget is created.</summary>
		[Generated]
		public SlideOutBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SlideOutBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SlideOutBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SlideOutBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SlideOutBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SlideOutBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SlideOutBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SlideOutBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutBuilder ElementAttr(string attributeName, object value)
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
		public SlideOutBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SlideOutBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SlideOutBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SlideOutBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SlideOutBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public SlideOutBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public SlideOutBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public SlideOutBuilder Items(Action<CollectionFactory<SlideOutItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SlideOutBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SlideOutBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SlideOutBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SlideOutBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display a grouped menu.</summary>
		[Generated]
		public SlideOutBuilder MenuGrouped(bool value)
		{
			base.Options["menuGrouped"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display a grouped menu.</summary>
		[Generated]
		public SlideOutBuilder MenuGrouped(JS value)
		{
			base.Options["menuGrouped"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SlideOutBuilder MenuGroupTemplate(string templateContent)
		{
			AssignTemplate("menuGroupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SlideOutBuilder MenuGroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuGroupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SlideOutBuilder MenuGroupTemplate(TemplateName name)
		{
			AssignTemplate("menuGroupTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SlideOutBuilder MenuGroupTemplate(JS value)
		{
			base.Options["menuGroupTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public SlideOutBuilder MenuItemTemplate(string templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public SlideOutBuilder MenuItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public SlideOutBuilder MenuItemTemplate(TemplateName name)
		{
			AssignTemplate("menuItemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public SlideOutBuilder MenuItemTemplate(JS value)
		{
			base.Options["menuItemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the current menu position.</summary>
		[Generated]
		public SlideOutBuilder MenuPosition(SlideOutMenuPosition value)
		{
			base.Options["menuPosition"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the slide-out menu is displayed.</summary>
		[Generated]
		public SlideOutBuilder MenuVisible(bool value)
		{
			base.Options["menuVisible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the slide-out menu is displayed.</summary>
		[Generated]
		public SlideOutBuilder MenuVisible(JS value)
		{
			base.Options["menuVisible"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public SlideOutBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public SlideOutBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SlideOutBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SlideOutBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SlideOutBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SlideOutBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SlideOutBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SlideOutBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public SlideOutBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public SlideOutBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public SlideOutBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public SlideOutBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public SlideOutBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public SlideOutBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a group menu item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnMenuGroupRendered(string jsFunc)
		{
			AssignJS("onMenuGroupRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a group menu item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnMenuGroupRendered(RazorBlock jsFunc)
		{
			return OnMenuGroupRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a regular menu item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnMenuItemRendered(string jsFunc)
		{
			AssignJS("onMenuItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a regular menu item is rendered.</summary>
		[Generated]
		public SlideOutBuilder OnMenuItemRendered(RazorBlock jsFunc)
		{
			return OnMenuItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SlideOutBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SlideOutBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public SlideOutBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public SlideOutBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SlideOutBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SlideOutBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>The index number of the currently selected item.</summary>
		[Generated]
		public SlideOutBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The index number of the currently selected item.</summary>
		[Generated]
		public SlideOutBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public SlideOutBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>Indicates whether the menu can be shown/hidden by swiping the widget's main panel.</summary>
		[Generated]
		public SlideOutBuilder SwipeEnabled(bool value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether the menu can be shown/hidden by swiping the widget's main panel.</summary>
		[Generated]
		public SlideOutBuilder SwipeEnabled(JS value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SlideOutBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SlideOutBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
