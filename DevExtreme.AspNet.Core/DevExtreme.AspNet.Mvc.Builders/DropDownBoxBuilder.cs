using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The DropDownBox widget consists of a text field, which displays the current value, and a drop-down field, which can contain any UI element.</summary>
	public class DropDownBoxBuilder : WidgetBuilder
	{
		[Generated]
		public DropDownBoxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DropDownBoxBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DropDownBoxBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DropDownBoxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public DropDownBoxBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public DropDownBoxBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value.</summary>
		[Generated]
		public DropDownBoxBuilder AcceptCustomValue(bool value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value.</summary>
		[Generated]
		public DropDownBoxBuilder AcceptCustomValue(JS value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DropDownBoxBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DropDownBoxBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DropDownBoxBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DropDownBoxBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public DropDownBoxBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public DropDownBoxBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down content.</summary>
		[Generated]
		public DropDownBoxBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down content.</summary>
		[Generated]
		public DropDownBoxBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down content.</summary>
		[Generated]
		public DropDownBoxBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down content.</summary>
		[Generated]
		public DropDownBoxBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DropDownBoxBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DropDownBoxBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DropDownBoxBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DropDownBoxBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public DropDownBoxBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public DropDownBoxBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public DropDownBoxBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DropDownBoxBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DropDownBoxBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public DropDownBoxBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public DropDownBoxBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Customizes text before it is displayed in the input field.</summary>
		[Generated]
		public DropDownBoxBuilder DisplayValueFormatter(string jsFunc)
		{
			AssignJS("displayValueFormatter", jsFunc);
			return this;
		}

		/// <summary>Customizes text before it is displayed in the input field.</summary>
		[Generated]
		public DropDownBoxBuilder DisplayValueFormatter(RazorBlock jsFunc)
		{
			return DisplayValueFormatter(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DropDownBoxBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DropDownBoxBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DropDownBoxBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DropDownBoxBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>Configures the drop-down field which holds the content.</summary>
		[Generated]
		public DropDownBoxBuilder DropDownOptions(Action<PopupBuilder> configurator)
		{
			NestedOptions("dropDownOptions", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownBoxBuilder ElementAttr(string attributeName, object value)
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
		public DropDownBoxBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownBoxBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DropDownBoxBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public DropDownBoxBuilder FieldTemplate(string templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public DropDownBoxBuilder FieldTemplate(RazorBlock templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public DropDownBoxBuilder FieldTemplate(TemplateName name)
		{
			AssignTemplate("fieldTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public DropDownBoxBuilder FieldTemplate(JS value)
		{
			base.Options["fieldTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DropDownBoxBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DropDownBoxBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownBoxBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownBoxBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DropDownBoxBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DropDownBoxBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DropDownBoxBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DropDownBoxBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DropDownBoxBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DropDownBoxBuilder InputAttr(string attributeName, object value)
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
		public DropDownBoxBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DropDownBoxBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DropDownBoxBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public DropDownBoxBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public DropDownBoxBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public DropDownBoxBuilder Items(Action<CollectionFactory<DropDownBoxItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public DropDownBoxBuilder MaxLength(double value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public DropDownBoxBuilder MaxLength(string value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public DropDownBoxBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public DropDownBoxBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public DropDownBoxBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public DropDownBoxBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public DropDownBoxBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public DropDownBoxBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public DropDownBoxBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public DropDownBoxBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public DropDownBoxBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DropDownBoxBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DropDownBoxBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public DropDownBoxBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public DropDownBoxBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public DropDownBoxBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public DropDownBoxBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public DropDownBoxBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public DropDownBoxBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DropDownBoxBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DropDownBoxBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public DropDownBoxBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public DropDownBoxBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public DropDownBoxBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public DropDownBoxBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public DropDownBoxBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DropDownBoxBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DropDownBoxBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public DropDownBoxBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public DropDownBoxBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public DropDownBoxBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public DropDownBoxBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public DropDownBoxBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public DropDownBoxBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public DropDownBoxBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public DropDownBoxBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when the widget value is empty.</summary>
		[Generated]
		public DropDownBoxBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when the widget value is empty.</summary>
		[Generated]
		public DropDownBoxBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public DropDownBoxBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public DropDownBoxBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DropDownBoxBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DropDownBoxBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public DropDownBoxBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public DropDownBoxBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public DropDownBoxBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public DropDownBoxBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public DropDownBoxBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DropDownBoxBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DropDownBoxBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public DropDownBoxBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public DropDownBoxBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public DropDownBoxBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public DropDownBoxBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public DropDownBoxBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the currently selected value. May be an object if dataSource contains objects and valueExpr is not set.</summary>
		[Generated]
		public DropDownBoxBuilder Value(object value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public DropDownBoxBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public DropDownBoxBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public DropDownBoxBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public DropDownBoxBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DropDownBoxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DropDownBoxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownBoxBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownBoxBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DropDownBoxBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
