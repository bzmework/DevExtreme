using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Calendar is a widget that displays a calendar and allows an end user to select the required date within a specified date range.</summary>
	public class CalendarBuilder : WidgetBuilder
	{
		[Generated]
		public CalendarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public CalendarBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public CalendarBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CalendarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public CalendarBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public CalendarBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public CalendarBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public CalendarBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for calendar cells.</summary>
		[Generated]
		public CalendarBuilder CellTemplate(string templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for calendar cells.</summary>
		[Generated]
		public CalendarBuilder CellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("cellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for calendar cells.</summary>
		[Generated]
		public CalendarBuilder CellTemplate(TemplateName name)
		{
			AssignTemplate("cellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for calendar cells.</summary>
		[Generated]
		public CalendarBuilder CellTemplate(JS value)
		{
			base.Options["cellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the date-time value serialization format. Use it only if you do not specify the value at design time.</summary>
		[Generated]
		public CalendarBuilder DateSerializationFormat(string value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date-time value serialization format. Use it only if you do not specify the value at design time.</summary>
		[Generated]
		public CalendarBuilder DateSerializationFormat(JS value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public CalendarBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public CalendarBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies dates to be disabled.</summary>
		[Generated]
		public CalendarBuilder DisabledDates(string jsFunc)
		{
			AssignJS("disabledDates", jsFunc);
			return this;
		}

		/// <summary>Specifies dates to be disabled.</summary>
		[Generated]
		public CalendarBuilder DisabledDates(RazorBlock jsFunc)
		{
			return DisabledDates(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies dates to be disabled.</summary>
		[Generated]
		public CalendarBuilder DisabledDates(IEnumerable<DateTime> value)
		{
			base.Options["disabledDates"] = value;
			return this;
		}

		/// <summary>Specifies dates to be disabled.</summary>
		[Generated]
		public CalendarBuilder DisabledDates(JS value)
		{
			base.Options["disabledDates"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CalendarBuilder ElementAttr(string attributeName, object value)
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
		public CalendarBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CalendarBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CalendarBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the first day of a week.</summary>
		[Generated]
		public CalendarBuilder FirstDayOfWeek(FirstDayOfWeek value)
		{
			base.Options["firstDayOfWeek"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public CalendarBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public CalendarBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public CalendarBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public CalendarBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public CalendarBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public CalendarBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public CalendarBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public CalendarBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public CalendarBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public CalendarBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public CalendarBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Max(string value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the maximum zoom level of the calendar.</summary>
		[Generated]
		public CalendarBuilder MaxZoomLevel(CalendarZoomLevel value)
		{
			base.Options["maxZoomLevel"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Min(string value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows to select.</summary>
		[Generated]
		public CalendarBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>Specifies the minimum zoom level of the calendar.</summary>
		[Generated]
		public CalendarBuilder MinZoomLevel(CalendarZoomLevel value)
		{
			base.Options["minZoomLevel"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public CalendarBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public CalendarBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public CalendarBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public CalendarBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public CalendarBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public CalendarBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public CalendarBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public CalendarBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public CalendarBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public CalendarBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public CalendarBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public CalendarBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public CalendarBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public CalendarBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays a button that selects the current date.</summary>
		[Generated]
		public CalendarBuilder ShowTodayButton(bool value)
		{
			base.Options["showTodayButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays a button that selects the current date.</summary>
		[Generated]
		public CalendarBuilder ShowTodayButton(JS value)
		{
			base.Options["showTodayButton"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public CalendarBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public CalendarBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public CalendarBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public CalendarBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public CalendarBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public CalendarBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public CalendarBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected in the calendar.</summary>
		[Generated]
		public CalendarBuilder Value(DateTime? value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected in the calendar.</summary>
		[Generated]
		public CalendarBuilder Value(double? value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected in the calendar.</summary>
		[Generated]
		public CalendarBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>An object or a value specifying the date and time currently selected in the calendar.</summary>
		[Generated]
		public CalendarBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public CalendarBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public CalendarBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public CalendarBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public CalendarBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public CalendarBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the current calendar zoom level.</summary>
		[Generated]
		public CalendarBuilder ZoomLevel(CalendarZoomLevel value)
		{
			base.Options["zoomLevel"] = value;
			return this;
		}
	}
}
