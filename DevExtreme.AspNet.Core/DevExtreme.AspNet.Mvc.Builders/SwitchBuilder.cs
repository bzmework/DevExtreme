using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Switch is a widget that can be in two states: "On" and "Off".</summary>
	public class SwitchBuilder : WidgetBuilder
	{
		[Generated]
		public SwitchBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SwitchBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SwitchBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SwitchBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SwitchBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SwitchBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SwitchBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SwitchBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SwitchBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SwitchBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SwitchBuilder ElementAttr(string attributeName, object value)
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
		public SwitchBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SwitchBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SwitchBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SwitchBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SwitchBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SwitchBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SwitchBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SwitchBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SwitchBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SwitchBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SwitchBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SwitchBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public SwitchBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public SwitchBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public SwitchBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public SwitchBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		[Obsolete("Use the switchedOffText option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SwitchBuilder OffText(string value)
		{
			base.Options["offText"] = value;
			return this;
		}

		[Obsolete("Use the switchedOffText option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SwitchBuilder OffText(JS value)
		{
			base.Options["offText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SwitchBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SwitchBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SwitchBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SwitchBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SwitchBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SwitchBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SwitchBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SwitchBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		[Obsolete("Use the switchedOnText option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SwitchBuilder OnText(string value)
		{
			base.Options["onText"] = value;
			return this;
		}

		[Obsolete("Use the switchedOnText option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SwitchBuilder OnText(JS value)
		{
			base.Options["onText"] = value;
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public SwitchBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public SwitchBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public SwitchBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public SwitchBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SwitchBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SwitchBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed when the widget is switched off.</summary>
		[Generated]
		public SwitchBuilder SwitchedOffText(string value)
		{
			base.Options["switchedOffText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed when the widget is switched off.</summary>
		[Generated]
		public SwitchBuilder SwitchedOffText(JS value)
		{
			base.Options["switchedOffText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed when the widget is switched on.</summary>
		[Generated]
		public SwitchBuilder SwitchedOnText(string value)
		{
			base.Options["switchedOnText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed when the widget is switched on.</summary>
		[Generated]
		public SwitchBuilder SwitchedOnText(JS value)
		{
			base.Options["switchedOnText"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SwitchBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SwitchBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public SwitchBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public SwitchBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public SwitchBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public SwitchBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public SwitchBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether the current switch state is "On" or "Off".</summary>
		[Generated]
		public SwitchBuilder Value(bool? value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether the current switch state is "On" or "Off".</summary>
		[Generated]
		public SwitchBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SwitchBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SwitchBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SwitchBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SwitchBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SwitchBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
