using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.</summary>
	public class ColorBoxBuilder : WidgetBuilder
	{
		[Generated]
		public ColorBoxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ColorBoxBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ColorBoxBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ColorBoxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget allows an end-user to enter a custom value.</summary>
		[Generated]
		public ColorBoxBuilder AcceptCustomValue(bool value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget allows an end-user to enter a custom value.</summary>
		[Generated]
		public ColorBoxBuilder AcceptCustomValue(JS value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ColorBoxBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ColorBoxBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ColorBoxBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ColorBoxBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed on the button that applies changes and closes the drop-down editor.</summary>
		[Generated]
		public ColorBoxBuilder ApplyButtonText(string value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed on the button that applies changes and closes the drop-down editor.</summary>
		[Generated]
		public ColorBoxBuilder ApplyButtonText(JS value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the way an end-user applies the selected value.</summary>
		[Generated]
		public ColorBoxBuilder ApplyValueMode(EditorApplyValueMode value)
		{
			base.Options["applyValueMode"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public ColorBoxBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public ColorBoxBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Specifies the text displayed on the button that cancels changes and closes the drop-down editor.</summary>
		[Generated]
		public ColorBoxBuilder CancelButtonText(string value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed on the button that cancels changes and closes the drop-down editor.</summary>
		[Generated]
		public ColorBoxBuilder CancelButtonText(JS value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public ColorBoxBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public ColorBoxBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ColorBoxBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ColorBoxBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public ColorBoxBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public ColorBoxBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public ColorBoxBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public ColorBoxBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget value includes the alpha channel component.</summary>
		[Generated]
		public ColorBoxBuilder EditAlphaChannel(bool value)
		{
			base.Options["editAlphaChannel"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget value includes the alpha channel component.</summary>
		[Generated]
		public ColorBoxBuilder EditAlphaChannel(JS value)
		{
			base.Options["editAlphaChannel"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ColorBoxBuilder ElementAttr(string attributeName, object value)
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
		public ColorBoxBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ColorBoxBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ColorBoxBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the input field. Must contain the TextBox widget.</summary>
		[Generated]
		public ColorBoxBuilder FieldTemplate(string templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the input field. Must contain the TextBox widget.</summary>
		[Generated]
		public ColorBoxBuilder FieldTemplate(RazorBlock templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the input field. Must contain the TextBox widget.</summary>
		[Generated]
		public ColorBoxBuilder FieldTemplate(TemplateName name)
		{
			AssignTemplate("fieldTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the input field. Must contain the TextBox widget.</summary>
		[Generated]
		public ColorBoxBuilder FieldTemplate(JS value)
		{
			base.Options["fieldTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ColorBoxBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ColorBoxBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ColorBoxBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ColorBoxBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ColorBoxBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ColorBoxBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ColorBoxBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ColorBoxBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ColorBoxBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public ColorBoxBuilder InputAttr(string attributeName, object value)
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
		public ColorBoxBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public ColorBoxBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public ColorBoxBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public ColorBoxBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public ColorBoxBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies the size of a step by which a handle is moved using a keyboard shortcut.</summary>
		[Generated]
		public ColorBoxBuilder KeyStep(double value)
		{
			base.Options["keyStep"] = value;
			return this;
		}

		/// <summary>Specifies the size of a step by which a handle is moved using a keyboard shortcut.</summary>
		[Generated]
		public ColorBoxBuilder KeyStep(JS value)
		{
			base.Options["keyStep"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public ColorBoxBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public ColorBoxBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public ColorBoxBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public ColorBoxBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public ColorBoxBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public ColorBoxBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public ColorBoxBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public ColorBoxBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ColorBoxBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ColorBoxBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public ColorBoxBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public ColorBoxBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public ColorBoxBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public ColorBoxBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public ColorBoxBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public ColorBoxBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ColorBoxBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ColorBoxBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public ColorBoxBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public ColorBoxBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public ColorBoxBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public ColorBoxBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public ColorBoxBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ColorBoxBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ColorBoxBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public ColorBoxBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public ColorBoxBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public ColorBoxBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public ColorBoxBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public ColorBoxBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public ColorBoxBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when the widget value is empty.</summary>
		[Generated]
		public ColorBoxBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when the widget value is empty.</summary>
		[Generated]
		public ColorBoxBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public ColorBoxBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public ColorBoxBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ColorBoxBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ColorBoxBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public ColorBoxBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public ColorBoxBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public ColorBoxBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ColorBoxBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ColorBoxBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public ColorBoxBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public ColorBoxBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public ColorBoxBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public ColorBoxBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public ColorBoxBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the currently selected value.</summary>
		[Generated]
		public ColorBoxBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the currently selected value.</summary>
		[Generated]
		public ColorBoxBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ColorBoxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ColorBoxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ColorBoxBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ColorBoxBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ColorBoxBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
