using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The DropDownButton is a button that opens a drop-down menu.</summary>
	public class DropDownButtonBuilder : WidgetBuilder
	{
		[Generated]
		public DropDownButtonBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DropDownButtonBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DropDownButtonBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DropDownButtonBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DropDownButtonBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DropDownButtonBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DropDownButtonBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DropDownButtonBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Provides data for the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Provides data for the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Provides data for the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Provides data for the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Provides data for the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether to wait until the drop-down menu is opened the first time to render its content.</summary>
		[Generated]
		public DropDownButtonBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to wait until the drop-down menu is opened the first time to render its content.</summary>
		[Generated]
		public DropDownButtonBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DropDownButtonBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DropDownButtonBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed in the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed in the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies custom content for the drop-down field.</summary>
		[Generated]
		public DropDownButtonBuilder DropDownContentTemplate(string templateContent)
		{
			AssignTemplate("dropDownContentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom content for the drop-down field.</summary>
		[Generated]
		public DropDownButtonBuilder DropDownContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownContentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom content for the drop-down field.</summary>
		[Generated]
		public DropDownButtonBuilder DropDownContentTemplate(TemplateName name)
		{
			AssignTemplate("dropDownContentTemplate", name);
			return this;
		}

		/// <summary>Specifies custom content for the drop-down field.</summary>
		[Generated]
		public DropDownButtonBuilder DropDownContentTemplate(JS value)
		{
			base.Options["dropDownContentTemplate"] = value;
			return this;
		}

		/// <summary>Configures the drop-down field.</summary>
		[Generated]
		public DropDownButtonBuilder DropDownOptions(Action<PopupBuilder> configurator)
		{
			NestedOptions("dropDownOptions", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownButtonBuilder ElementAttr(string attributeName, object value)
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
		public DropDownButtonBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownButtonBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownButtonBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether users can use keyboard to focus the widget.</summary>
		[Generated]
		public DropDownButtonBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether users can use keyboard to focus the widget.</summary>
		[Generated]
		public DropDownButtonBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownButtonBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownButtonBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownButtonBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DropDownButtonBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DropDownButtonBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user hovers the mouse pointer over it.</summary>
		[Generated]
		public DropDownButtonBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user hovers the mouse pointer over it.</summary>
		[Generated]
		public DropDownButtonBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the button's icon.</summary>
		[Generated]
		public DropDownButtonBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the button's icon.</summary>
		[Generated]
		public DropDownButtonBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Provides drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder Items(Action<CollectionFactory<DropDownButtonItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys used to distinguish between the selected drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys used to distinguish between the selected drop-down menu items.</summary>
		[Generated]
		public DropDownButtonBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies text or HTML markup displayed in the drop-down menu when it does not contain any items.</summary>
		[Generated]
		public DropDownButtonBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>Specifies text or HTML markup displayed in the drop-down menu when it does not contain any items.</summary>
		[Generated]
		public DropDownButtonBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the button is clicked or tapped. If splitButton is true, this function is executed for the action button only.</summary>
		[Generated]
		public DropDownButtonBuilder OnButtonClick(string jsFunc)
		{
			AssignJS("onButtonClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the button is clicked or tapped. If splitButton is true, this function is executed for the action button only.</summary>
		[Generated]
		public DropDownButtonBuilder OnButtonClick(RazorBlock jsFunc)
		{
			return OnButtonClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DropDownButtonBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DropDownButtonBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DropDownButtonBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DropDownButtonBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DropDownButtonBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DropDownButtonBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a drop-down menu item is clicked.</summary>
		[Generated]
		public DropDownButtonBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a drop-down menu item is clicked.</summary>
		[Generated]
		public DropDownButtonBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DropDownButtonBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DropDownButtonBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an item is selected or selection is canceled. In effect when useSelectMode is true.</summary>
		[Generated]
		public DropDownButtonBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an item is selected or selection is canceled. In effect when useSelectMode is true.</summary>
		[Generated]
		public DropDownButtonBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the drop-down menu is opened.</summary>
		[Generated]
		public DropDownButtonBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down menu is opened.</summary>
		[Generated]
		public DropDownButtonBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DropDownButtonBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DropDownButtonBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Contains the selected item's key and allows you to specify the initially selected item. Applies when useSelectMode is true.</summary>
		[Generated]
		public DropDownButtonBuilder SelectedItemKey(double value)
		{
			base.Options["selectedItemKey"] = value;
			return this;
		}

		/// <summary>Contains the selected item's key and allows you to specify the initially selected item. Applies when useSelectMode is true.</summary>
		[Generated]
		public DropDownButtonBuilder SelectedItemKey(string value)
		{
			base.Options["selectedItemKey"] = value;
			return this;
		}

		/// <summary>Contains the selected item's key and allows you to specify the initially selected item. Applies when useSelectMode is true.</summary>
		[Generated]
		public DropDownButtonBuilder SelectedItemKey(JS value)
		{
			base.Options["selectedItemKey"] = value;
			return this;
		}

		/// <summary>Specifies whether the arrow icon should be displayed.</summary>
		[Generated]
		public DropDownButtonBuilder ShowArrowIcon(bool value)
		{
			base.Options["showArrowIcon"] = value;
			return this;
		}

		/// <summary>Specifies whether the arrow icon should be displayed.</summary>
		[Generated]
		public DropDownButtonBuilder ShowArrowIcon(JS value)
		{
			base.Options["showArrowIcon"] = value;
			return this;
		}

		/// <summary>Specifies whether to split the button in two: one executes an action, the other opens and closes the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder SplitButton(bool value)
		{
			base.Options["splitButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to split the button in two: one executes an action, the other opens and closes the drop-down menu.</summary>
		[Generated]
		public DropDownButtonBuilder SplitButton(JS value)
		{
			base.Options["splitButton"] = value;
			return this;
		}

		/// <summary>Specifies how the button is styled.</summary>
		[Generated]
		public DropDownButtonBuilder StylingMode(ButtonStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DropDownButtonBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DropDownButtonBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the button's text. Applies only if useSelectMode is false.</summary>
		[Generated]
		public DropDownButtonBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the button's text. Applies only if useSelectMode is false.</summary>
		[Generated]
		public DropDownButtonBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget stores the selected drop-down menu item.</summary>
		[Generated]
		public DropDownButtonBuilder UseSelectMode(bool value)
		{
			base.Options["useSelectMode"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget stores the selected drop-down menu item.</summary>
		[Generated]
		public DropDownButtonBuilder UseSelectMode(JS value)
		{
			base.Options["useSelectMode"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DropDownButtonBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DropDownButtonBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownButtonBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownButtonBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownButtonBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public DropDownButtonBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public DropDownButtonBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
