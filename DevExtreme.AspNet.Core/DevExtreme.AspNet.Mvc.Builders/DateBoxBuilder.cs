using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The DateBox is a widget that displays date and time in a specified format, and enables a user to pick or type in the required date/time value.</summary>
	public class DateBoxBuilder : WidgetBuilder
	{
		[Generated]
		public DateBoxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DateBoxBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DateBoxBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DateBoxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget allows an end-user to enter a custom value.</summary>
		[Generated]
		public DateBoxBuilder AcceptCustomValue(bool value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget allows an end-user to enter a custom value.</summary>
		[Generated]
		public DateBoxBuilder AcceptCustomValue(JS value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DateBoxBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DateBoxBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DateBoxBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DateBoxBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not adaptive widget rendering is enabled on a small screen.</summary>
		[Generated]
		public DateBoxBuilder AdaptivityEnabled(bool value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not adaptive widget rendering is enabled on a small screen.</summary>
		[Generated]
		public DateBoxBuilder AdaptivityEnabled(JS value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>The text displayed on the Apply button.</summary>
		[Generated]
		public DateBoxBuilder ApplyButtonText(string value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the Apply button.</summary>
		[Generated]
		public DateBoxBuilder ApplyButtonText(JS value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the way an end-user applies the selected value.</summary>
		[Generated]
		public DateBoxBuilder ApplyValueMode(EditorApplyValueMode value)
		{
			base.Options["applyValueMode"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public DateBoxBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public DateBoxBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Configures the calendar's value picker. Applies only if the pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder CalendarOptions(Action<CalendarBuilder> configurator)
		{
			NestedOptions("calendarOptions", configurator);
			return this;
		}

		/// <summary>The text displayed on the Cancel button.</summary>
		[Generated]
		public DateBoxBuilder CancelButtonText(string value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the Cancel button.</summary>
		[Generated]
		public DateBoxBuilder CancelButtonText(JS value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed if the specified date is later than the max value or earlier than the min value.</summary>
		[Generated]
		public DateBoxBuilder DateOutOfRangeMessage(string value)
		{
			base.Options["dateOutOfRangeMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed if the specified date is later than the max value or earlier than the min value.</summary>
		[Generated]
		public DateBoxBuilder DateOutOfRangeMessage(JS value)
		{
			base.Options["dateOutOfRangeMessage"] = value;
			return this;
		}

		/// <summary>Specifies the date-time value serialization format. Use it only if you do not specify the value at design time.</summary>
		[Generated]
		public DateBoxBuilder DateSerializationFormat(string value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date-time value serialization format. Use it only if you do not specify the value at design time.</summary>
		[Generated]
		public DateBoxBuilder DateSerializationFormat(JS value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public DateBoxBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public DateBoxBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DateBoxBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DateBoxBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies dates to be disabled. Applies only if pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder DisabledDates(string jsFunc)
		{
			AssignJS("disabledDates", jsFunc);
			return this;
		}

		/// <summary>Specifies dates to be disabled. Applies only if pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder DisabledDates(RazorBlock jsFunc)
		{
			return DisabledDates(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies dates to be disabled. Applies only if pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder DisabledDates(IEnumerable<DateTime> value)
		{
			base.Options["disabledDates"] = value;
			return this;
		}

		/// <summary>Specifies dates to be disabled. Applies only if pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder DisabledDates(JS value)
		{
			base.Options["disabledDates"] = value;
			return this;
		}

		/// <summary>Specifies the date display format. Ignored if the pickerType option is "native"</summary>
		[Generated]
		public DateBoxBuilder DisplayFormat(Format value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date display format. Ignored if the pickerType option is "native"</summary>
		[Generated]
		public DateBoxBuilder DisplayFormat(string value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date display format. Ignored if the pickerType option is "native"</summary>
		[Generated]
		public DateBoxBuilder DisplayFormat(JS value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date display format. Ignored if the pickerType option is "native"</summary>
		[Generated]
		public DateBoxBuilder DisplayFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("displayFormat", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DateBoxBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DateBoxBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DateBoxBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public DateBoxBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DateBoxBuilder ElementAttr(string attributeName, object value)
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
		public DateBoxBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DateBoxBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DateBoxBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DateBoxBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DateBoxBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DateBoxBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DateBoxBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DateBoxBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DateBoxBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DateBoxBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DateBoxBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DateBoxBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DateBoxBuilder InputAttr(string attributeName, object value)
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
		public DateBoxBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DateBoxBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public DateBoxBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the interval between neighboring values in the popup list in minutes.</summary>
		[Generated]
		public DateBoxBuilder Interval(double value)
		{
			base.Options["interval"] = value;
			return this;
		}

		/// <summary>Specifies the interval between neighboring values in the popup list in minutes.</summary>
		[Generated]
		public DateBoxBuilder Interval(JS value)
		{
			base.Options["interval"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed if the typed value is not a valid date or time.</summary>
		[Generated]
		public DateBoxBuilder InvalidDateMessage(string value)
		{
			base.Options["invalidDateMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message displayed if the typed value is not a valid date or time.</summary>
		[Generated]
		public DateBoxBuilder InvalidDateMessage(JS value)
		{
			base.Options["invalidDateMessage"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public DateBoxBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public DateBoxBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>The last date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The last date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The last date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Max(string value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The last date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public DateBoxBuilder MaxLength(int value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public DateBoxBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		[Obsolete("Use the calendarOptions option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DateBoxBuilder MaxZoomLevel(CalendarZoomLevel value)
		{
			base.Options["maxZoomLevel"] = value;
			return this;
		}

		/// <summary>The minimum date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The minimum date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The minimum date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Min(string value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The minimum date that can be selected within the widget.</summary>
		[Generated]
		public DateBoxBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		[Obsolete("Use the calendarOptions option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DateBoxBuilder MinZoomLevel(CalendarZoomLevel value)
		{
			base.Options["minZoomLevel"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public DateBoxBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public DateBoxBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public DateBoxBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public DateBoxBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DateBoxBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DateBoxBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public DateBoxBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been copied.</summary>
		[Generated]
		public DateBoxBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public DateBoxBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been cut.</summary>
		[Generated]
		public DateBoxBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DateBoxBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DateBoxBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public DateBoxBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public DateBoxBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public DateBoxBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public DateBoxBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public DateBoxBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public DateBoxBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DateBoxBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DateBoxBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public DateBoxBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public DateBoxBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public DateBoxBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public DateBoxBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public DateBoxBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DateBoxBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DateBoxBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public DateBoxBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's input has been pasted.</summary>
		[Generated]
		public DateBoxBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public DateBoxBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public DateBoxBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public DateBoxBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public DateBoxBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public DateBoxBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public DateBoxBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>Specifies the type of the date/time picker.</summary>
		[Generated]
		public DateBoxBuilder PickerType(DateBoxPickerType value)
		{
			base.Options["pickerType"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the input field.</summary>
		[Generated]
		public DateBoxBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies a placeholder for the input field.</summary>
		[Generated]
		public DateBoxBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public DateBoxBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public DateBoxBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DateBoxBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DateBoxBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the analog clock in the value picker. Applies only if type is "datetime" and pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder ShowAnalogClock(bool value)
		{
			base.Options["showAnalogClock"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the analog clock in the value picker. Applies only if type is "datetime" and pickerType is "calendar".</summary>
		[Generated]
		public DateBoxBuilder ShowAnalogClock(JS value)
		{
			base.Options["showAnalogClock"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public DateBoxBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public DateBoxBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public DateBoxBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public DateBoxBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget checks the inner text for spelling mistakes.</summary>
		[Generated]
		public DateBoxBuilder Spellcheck(bool value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget checks the inner text for spelling mistakes.</summary>
		[Generated]
		public DateBoxBuilder Spellcheck(JS value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public DateBoxBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DateBoxBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DateBoxBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>A format used to display date/time information.</summary>
		[Generated]
		public DateBoxBuilder Type(DateBoxType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies whether to control user input using a mask created based on the displayFormat.</summary>
		[Generated]
		public DateBoxBuilder UseMaskBehavior(bool value)
		{
			base.Options["useMaskBehavior"] = value;
			return this;
		}

		/// <summary>Specifies whether to control user input using a mask created based on the displayFormat.</summary>
		[Generated]
		public DateBoxBuilder UseMaskBehavior(JS value)
		{
			base.Options["useMaskBehavior"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public DateBoxBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public DateBoxBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public DateBoxBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public DateBoxBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public DateBoxBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected using the date box.</summary>
		[Generated]
		public DateBoxBuilder Value(DateTime? value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected using the date box.</summary>
		[Generated]
		public DateBoxBuilder Value(double? value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected using the date box.</summary>
		[Generated]
		public DateBoxBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected using the date box.</summary>
		[Generated]
		public DateBoxBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public DateBoxBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public DateBoxBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DateBoxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DateBoxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DateBoxBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DateBoxBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DateBoxBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
