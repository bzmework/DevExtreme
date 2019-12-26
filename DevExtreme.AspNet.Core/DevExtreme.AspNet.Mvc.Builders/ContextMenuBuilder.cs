using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The ContextMenu widget displays a single- or multi-level context menu. An end user invokes this menu by a right click or a long press.</summary>
	public class ContextMenuBuilder : WidgetBuilder
	{
		/// <summary>An array of currently selected item objects.</summary>
		[Obsolete("ContextMenu does not support multiple selection. Use SelectedItem(object value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContextMenuBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>An array of currently selected item objects.</summary>
		[Obsolete("ContextMenu does not support multiple selection. Use SelectedItem(object value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ContextMenuBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		[Generated]
		public ContextMenuBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ContextMenuBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ContextMenuBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ContextMenuBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ContextMenuBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ContextMenuBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ContextMenuBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ContextMenuBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public ContextMenuBuilder Animation(Action<ContextMenuAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies whether to close the ContextMenu if a user clicks outside it.</summary>
		[Generated]
		public ContextMenuBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the ContextMenu if a user clicks outside it.</summary>
		[Generated]
		public ContextMenuBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies the name of the CSS class to be applied to the root menu level and all submenus.</summary>
		[Generated]
		public ContextMenuBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies the name of the CSS class to be applied to the root menu level and all submenus.</summary>
		[Generated]
		public ContextMenuBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ContextMenuBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ContextMenuBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ContextMenuBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ContextMenuBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ContextMenuBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ContextMenuBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ContextMenuBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public ContextMenuBuilder DisabledExpr(string value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget item is disabled.</summary>
		[Generated]
		public ContextMenuBuilder DisabledExpr(JS value)
		{
			base.Options["disabledExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public ContextMenuBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public ContextMenuBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ContextMenuBuilder ElementAttr(string attributeName, object value)
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
		public ContextMenuBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ContextMenuBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ContextMenuBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ContextMenuBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ContextMenuBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ContextMenuBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ContextMenuBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ContextMenuBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ContextMenuBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ContextMenuBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ContextMenuBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ContextMenuBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Holds an array of menu items.</summary>
		[Generated]
		public ContextMenuBuilder Items(Action<CollectionFactory<ContextMenuItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public ContextMenuBuilder ItemsExpr(string value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field contains nested items.</summary>
		[Generated]
		public ContextMenuBuilder ItemsExpr(JS value)
		{
			base.Options["itemsExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ContextMenuBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ContextMenuBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ContextMenuBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ContextMenuBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ContextMenuBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ContextMenuBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ContextMenuBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ContextMenuBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the ContextMenu is hidden.</summary>
		[Generated]
		public ContextMenuBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the ContextMenu is hidden.</summary>
		[Generated]
		public ContextMenuBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the ContextMenu is hidden.</summary>
		[Generated]
		public ContextMenuBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the ContextMenu is hidden.</summary>
		[Generated]
		public ContextMenuBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ContextMenuBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ContextMenuBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ContextMenuBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ContextMenuBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ContextMenuBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ContextMenuBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ContextMenuBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ContextMenuBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ContextMenuBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ContextMenuBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the ContextMenu is positioned.</summary>
		[Generated]
		public ContextMenuBuilder OnPositioning(string jsFunc)
		{
			AssignJS("onPositioning", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the ContextMenu is positioned.</summary>
		[Generated]
		public ContextMenuBuilder OnPositioning(RazorBlock jsFunc)
		{
			return OnPositioning(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public ContextMenuBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public ContextMenuBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the ContextMenu is shown.</summary>
		[Generated]
		public ContextMenuBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the ContextMenu is shown.</summary>
		[Generated]
		public ContextMenuBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the ContextMenu is shown.</summary>
		[Generated]
		public ContextMenuBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the ContextMenu is shown.</summary>
		[Generated]
		public ContextMenuBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public ContextMenuBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ContextMenuBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ContextMenuBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public ContextMenuBuilder SelectByClick(bool value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an item becomes selected if a user clicks it.</summary>
		[Generated]
		public ContextMenuBuilder SelectByClick(JS value)
		{
			base.Options["selectByClick"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public ContextMenuBuilder SelectedExpr(string value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding widget items is selected.</summary>
		[Generated]
		public ContextMenuBuilder SelectedExpr(JS value)
		{
			base.Options["selectedExpr"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public ContextMenuBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>Specifies the selection mode supported by the menu.</summary>
		[Generated]
		public ContextMenuBuilder SelectionMode(MenuSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public ContextMenuBuilder ShowEvent(Action<ContextMenuShowEventBuilder> configurator)
		{
			NestedOptions("showEvent", configurator);
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public ContextMenuBuilder ShowEvent(string value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public ContextMenuBuilder ShowEvent(JS value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>Specifies options of submenu showing and hiding.</summary>
		[Generated]
		public ContextMenuBuilder ShowSubmenuMode(Action<ContextMenuShowSubmenuModeBuilder> configurator)
		{
			NestedOptions("showSubmenuMode", configurator);
			return this;
		}

		/// <summary>Specifies options of submenu showing and hiding.</summary>
		[Generated]
		public ContextMenuBuilder ShowSubmenuMode(ShowSubmenuMode value)
		{
			base.Options["showSubmenuMode"] = value;
			return this;
		}

		/// <summary>Specifies the direction at which submenus are displayed.</summary>
		[Generated]
		public ContextMenuBuilder SubmenuDirection(ContextMenuSubmenuDirection value)
		{
			base.Options["submenuDirection"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ContextMenuBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ContextMenuBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>The target element associated with the context menu.</summary>
		[Generated]
		public ContextMenuBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>The target element associated with the context menu.</summary>
		[Generated]
		public ContextMenuBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public ContextMenuBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public ContextMenuBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ContextMenuBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ContextMenuBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ContextMenuBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
