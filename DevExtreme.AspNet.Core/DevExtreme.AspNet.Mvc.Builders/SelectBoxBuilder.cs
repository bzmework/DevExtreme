using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The SelectBox widget is an editor that allows an end user to select an item from a drop-down list.</summary>
	public class SelectBoxBuilder : WidgetBuilder
	{
		[Obsolete("The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SelectBoxBuilder DisplayValue(string value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Obsolete("The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public SelectBoxBuilder DisplayValue(JS value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Generated]
		public SelectBoxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SelectBoxBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SelectBoxBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SelectBoxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value. Requires the onCustomItemCreating handler implementation.</summary>
		[Generated]
		public SelectBoxBuilder AcceptCustomValue(bool value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value. Requires the onCustomItemCreating handler implementation.</summary>
		[Generated]
		public SelectBoxBuilder AcceptCustomValue(JS value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SelectBoxBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SelectBoxBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SelectBoxBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SelectBoxBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public SelectBoxBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public SelectBoxBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SelectBoxBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SelectBoxBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SelectBoxBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SelectBoxBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SelectBoxBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public SelectBoxBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public SelectBoxBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SelectBoxBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SelectBoxBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public SelectBoxBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public SelectBoxBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public SelectBoxBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public SelectBoxBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public SelectBoxBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public SelectBoxBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SelectBoxBuilder ElementAttr(string attributeName, object value)
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
		public SelectBoxBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SelectBoxBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SelectBoxBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public SelectBoxBuilder FieldTemplate(string templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public SelectBoxBuilder FieldTemplate(RazorBlock templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public SelectBoxBuilder FieldTemplate(TemplateName name)
		{
			AssignTemplate("fieldTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public SelectBoxBuilder FieldTemplate(JS value)
		{
			base.Options["fieldTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SelectBoxBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SelectBoxBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public SelectBoxBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public SelectBoxBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SelectBoxBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SelectBoxBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SelectBoxBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public SelectBoxBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SelectBoxBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SelectBoxBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SelectBoxBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SelectBoxBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SelectBoxBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SelectBoxBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SelectBoxBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder InputAttr(string attributeName, object value)
		{
			base.Options["inputAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public SelectBoxBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public SelectBoxBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public SelectBoxBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public SelectBoxBuilder Items(Action<CollectionFactory<SelectBoxItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SelectBoxBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SelectBoxBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SelectBoxBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public SelectBoxBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public SelectBoxBuilder MaxLength(int value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public SelectBoxBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public SelectBoxBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public SelectBoxBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public SelectBoxBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public SelectBoxBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public SelectBoxBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public SelectBoxBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public SelectBoxBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public SelectBoxBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public SelectBoxBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user adds a custom item. Requires acceptCustomValue to be set to true.</summary>
		[Generated]
		public SelectBoxBuilder OnCustomItemCreating(string jsFunc)
		{
			AssignJS("onCustomItemCreating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user adds a custom item. Requires acceptCustomValue to be set to true.</summary>
		[Generated]
		public SelectBoxBuilder OnCustomItemCreating(RazorBlock jsFunc)
		{
			return OnCustomItemCreating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public SelectBoxBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public SelectBoxBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SelectBoxBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SelectBoxBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public SelectBoxBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public SelectBoxBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public SelectBoxBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public SelectBoxBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public SelectBoxBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public SelectBoxBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SelectBoxBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SelectBoxBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public SelectBoxBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public SelectBoxBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public SelectBoxBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public SelectBoxBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public SelectBoxBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public SelectBoxBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public SelectBoxBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public SelectBoxBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public SelectBoxBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public SelectBoxBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public SelectBoxBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public SelectBoxBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public SelectBoxBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public SelectBoxBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public SelectBoxBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public SelectBoxBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the select box editor.</summary>
		[Generated]
		public SelectBoxBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the select box editor.</summary>
		[Generated]
		public SelectBoxBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public SelectBoxBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public SelectBoxBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SelectBoxBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SelectBoxBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow searching.</summary>
		[Generated]
		public SelectBoxBuilder SearchEnabled(bool value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow searching.</summary>
		[Generated]
		public SelectBoxBuilder SearchEnabled(JS value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public SelectBoxBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public SelectBoxBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public SelectBoxBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search widget items.</summary>
		[Generated]
		public SelectBoxBuilder SearchMode(DropDownSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public SelectBoxBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public SelectBoxBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public SelectBoxBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public SelectBoxBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public SelectBoxBuilder ShowDataBeforeSearch(bool value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public SelectBoxBuilder ShowDataBeforeSearch(JS value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public SelectBoxBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public SelectBoxBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display selection controls.</summary>
		[Generated]
		public SelectBoxBuilder ShowSelectionControls(bool value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display selection controls.</summary>
		[Generated]
		public SelectBoxBuilder ShowSelectionControls(JS value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget checks the inner text for spelling mistakes.</summary>
		[Generated]
		public SelectBoxBuilder Spellcheck(bool value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget checks the inner text for spelling mistakes.</summary>
		[Generated]
		public SelectBoxBuilder Spellcheck(JS value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public SelectBoxBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SelectBoxBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SelectBoxBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public SelectBoxBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public SelectBoxBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public SelectBoxBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public SelectBoxBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public SelectBoxBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the currently selected value. May be an object if dataSource contains objects and valueExpr is not set.</summary>
		[Generated]
		public SelectBoxBuilder Value(object value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated. Applies only if acceptCustomValue is set to true.</summary>
		[Generated]
		public SelectBoxBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated. Applies only if acceptCustomValue is set to true.</summary>
		[Generated]
		public SelectBoxBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public SelectBoxBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public SelectBoxBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SelectBoxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SelectBoxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SelectBoxBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SelectBoxBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SelectBoxBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public SelectBoxBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public SelectBoxBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
