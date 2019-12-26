using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Menu widget is a panel with clickable items. A click on an item opens a drop-down menu, which can contain several submenus.</summary>
	public class MenuBuilder : WidgetBuilder
	{
		[Generated]
		public MenuBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public MenuBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public MenuBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public MenuBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public MenuBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public MenuBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public MenuBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether adaptive widget rendering is enabled on small screens. Applies only if the orientation is "horizontal".</summary>
		[Generated]
		public MenuBuilder AdaptivityEnabled(bool value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether adaptive widget rendering is enabled on small screens. Applies only if the orientation is "horizontal".</summary>
		[Generated]
		public MenuBuilder AdaptivityEnabled(JS value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public MenuBuilder Animation(Action<MenuAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies the name of the CSS class to be applied to the root menu level and all submenus.</summary>
		[Generated]
		public MenuBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies the name of the CSS class to be applied to the root menu level and all submenus.</summary>
		[Generated]
		public MenuBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public MenuBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public MenuBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public MenuBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public MenuBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public MenuBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public MenuBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public MenuBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public MenuBuilder DisabledExpr(string value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public MenuBuilder DisabledExpr(JS value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public MenuBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public MenuBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MenuBuilder ElementAttr(string attributeName, object value)
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
		public MenuBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MenuBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MenuBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public MenuBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public MenuBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MenuBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MenuBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MenuBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the submenu is hidden when the mouse pointer leaves it.</summary>
		[Generated]
		public MenuBuilder HideSubmenuOnMouseLeave(bool value)
		{
			base.Options["hideSubmenuOnMouseLeave"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the submenu is hidden when the mouse pointer leaves it.</summary>
		[Generated]
		public MenuBuilder HideSubmenuOnMouseLeave(JS value)
		{
			base.Options["hideSubmenuOnMouseLeave"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public MenuBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public MenuBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public MenuBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public MenuBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Holds an array of menu items.</summary>
		[Generated]
		public MenuBuilder Items(Action<CollectionFactory<MenuItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public MenuBuilder ItemsExpr(string value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public MenuBuilder ItemsExpr(JS value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public MenuBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public MenuBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public MenuBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public MenuBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public MenuBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public MenuBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public MenuBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public MenuBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public MenuBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public MenuBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public MenuBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public MenuBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public MenuBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public MenuBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public MenuBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public MenuBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public MenuBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public MenuBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public MenuBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public MenuBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a submenu is hidden.</summary>
		[Generated]
		public MenuBuilder OnSubmenuHidden(string jsFunc)
		{
			AssignJS("onSubmenuHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a submenu is hidden.</summary>
		[Generated]
		public MenuBuilder OnSubmenuHidden(RazorBlock jsFunc)
		{
			return OnSubmenuHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a submenu is hidden.</summary>
		[Generated]
		public MenuBuilder OnSubmenuHiding(string jsFunc)
		{
			AssignJS("onSubmenuHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a submenu is hidden.</summary>
		[Generated]
		public MenuBuilder OnSubmenuHiding(RazorBlock jsFunc)
		{
			return OnSubmenuHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a submenu is displayed.</summary>
		[Generated]
		public MenuBuilder OnSubmenuShowing(string jsFunc)
		{
			AssignJS("onSubmenuShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a submenu is displayed.</summary>
		[Generated]
		public MenuBuilder OnSubmenuShowing(RazorBlock jsFunc)
		{
			return OnSubmenuShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a submenu is displayed.</summary>
		[Generated]
		public MenuBuilder OnSubmenuShown(string jsFunc)
		{
			AssignJS("onSubmenuShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a submenu is displayed.</summary>
		[Generated]
		public MenuBuilder OnSubmenuShown(RazorBlock jsFunc)
		{
			return OnSubmenuShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the menu has horizontal or vertical orientation.</summary>
		[Generated]
		public MenuBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public MenuBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public MenuBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public MenuBuilder SelectByClick(bool value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public MenuBuilder SelectByClick(JS value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public MenuBuilder SelectedExpr(string value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public MenuBuilder SelectedExpr(JS value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public MenuBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>Specifies the selection mode supported by the menu.</summary>
		[Generated]
		public MenuBuilder SelectionMode(MenuSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies options for showing and hiding the first level submenu.</summary>
		[Generated]
		public MenuBuilder ShowFirstSubmenuMode(Action<MenuShowFirstSubmenuModeBuilder> configurator)
		{
			NestedOptions("showFirstSubmenuMode", configurator);
			return this;
		}

		/// <summary>Specifies options for showing and hiding the first level submenu.</summary>
		[Generated]
		public MenuBuilder ShowFirstSubmenuMode(ShowSubmenuMode value)
		{
			base.Options["showFirstSubmenuMode"] = value;
			return this;
		}

		/// <summary>Specifies options of submenu showing and hiding.</summary>
		[Generated]
		public MenuBuilder ShowSubmenuMode(Action<MenuShowSubmenuModeBuilder> configurator)
		{
			NestedOptions("showSubmenuMode", configurator);
			return this;
		}

		/// <summary>Specifies options of submenu showing and hiding.</summary>
		[Generated]
		public MenuBuilder ShowSubmenuMode(ShowSubmenuMode value)
		{
			base.Options["showSubmenuMode"] = value;
			return this;
		}

		/// <summary>Specifies the direction at which the submenus are displayed.</summary>
		[Generated]
		public MenuBuilder SubmenuDirection(SubmenuDirection value)
		{
			base.Options["submenuDirection"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public MenuBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public MenuBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public MenuBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public MenuBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MenuBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MenuBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MenuBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
