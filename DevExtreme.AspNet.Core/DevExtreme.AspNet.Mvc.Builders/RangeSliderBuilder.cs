using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The RangeSlider is a widget that allows an end user to choose a range of numeric values.</summary>
	public class RangeSliderBuilder : WidgetBuilder
	{
		[Generated]
		public RangeSliderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public RangeSliderBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public RangeSliderBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSliderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public RangeSliderBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public RangeSliderBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public RangeSliderBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public RangeSliderBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public RangeSliderBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public RangeSliderBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSliderBuilder ElementAttr(string attributeName, object value)
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
		public RangeSliderBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSliderBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSliderBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>The right edge of the interval currently selected using the range slider.</summary>
		[Generated]
		public RangeSliderBuilder End(double value)
		{
			base.Options["end"] = value;
			return this;
		}

		/// <summary>The right edge of the interval currently selected using the range slider.</summary>
		[Generated]
		public RangeSliderBuilder End(JS value)
		{
			base.Options["end"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the name attribute of the underlying `` element.</summary>
		[Generated]
		public RangeSliderBuilder EndName(string value)
		{
			base.Options["endName"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the name attribute of the underlying `` element.</summary>
		[Generated]
		public RangeSliderBuilder EndName(JS value)
		{
			base.Options["endName"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public RangeSliderBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public RangeSliderBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public RangeSliderBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public RangeSliderBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public RangeSliderBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public RangeSliderBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public RangeSliderBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public RangeSliderBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public RangeSliderBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public RangeSliderBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public RangeSliderBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies the step by which a handle moves when a user presses Page Up or Page Down.</summary>
		[Generated]
		public RangeSliderBuilder KeyStep(double value)
		{
			base.Options["keyStep"] = value;
			return this;
		}

		/// <summary>Specifies the step by which a handle moves when a user presses Page Up or Page Down.</summary>
		[Generated]
		public RangeSliderBuilder KeyStep(JS value)
		{
			base.Options["keyStep"] = value;
			return this;
		}

		/// <summary>Configures the labels displayed at the min and max values.</summary>
		[Generated]
		public RangeSliderBuilder Label(Action<RangeSliderLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>The maximum value the widget can accept.</summary>
		[Generated]
		public RangeSliderBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The maximum value the widget can accept.</summary>
		[Generated]
		public RangeSliderBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The minimum value the widget can accept.</summary>
		[Generated]
		public RangeSliderBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The minimum value the widget can accept.</summary>
		[Generated]
		public RangeSliderBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public RangeSliderBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public RangeSliderBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public RangeSliderBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public RangeSliderBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public RangeSliderBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public RangeSliderBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public RangeSliderBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public RangeSliderBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public RangeSliderBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight the selected range.</summary>
		[Generated]
		public RangeSliderBuilder ShowRange(bool value)
		{
			base.Options["showRange"] = value;
			return this;
		}

		/// <summary>Specifies whether to highlight the selected range.</summary>
		[Generated]
		public RangeSliderBuilder ShowRange(JS value)
		{
			base.Options["showRange"] = value;
			return this;
		}

		/// <summary>The left edge of the interval currently selected using the range slider.</summary>
		[Generated]
		public RangeSliderBuilder Start(double value)
		{
			base.Options["start"] = value;
			return this;
		}

		/// <summary>The left edge of the interval currently selected using the range slider.</summary>
		[Generated]
		public RangeSliderBuilder Start(JS value)
		{
			base.Options["start"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the name attribute of the underlying `` element.</summary>
		[Generated]
		public RangeSliderBuilder StartName(string value)
		{
			base.Options["startName"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the name attribute of the underlying `` element.</summary>
		[Generated]
		public RangeSliderBuilder StartName(JS value)
		{
			base.Options["startName"] = value;
			return this;
		}

		/// <summary>Specifies the step by which the widget's value changes when a user drags a handler.</summary>
		[Generated]
		public RangeSliderBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the step by which the widget's value changes when a user drags a handler.</summary>
		[Generated]
		public RangeSliderBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public RangeSliderBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public RangeSliderBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Configures a tooltip.</summary>
		[Generated]
		public RangeSliderBuilder Tooltip(Action<RangeSliderTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public RangeSliderBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public RangeSliderBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public RangeSliderBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public RangeSliderBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public RangeSliderBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the widget's value.</summary>
		[Generated]
		public RangeSliderBuilder Value(IEnumerable<double> value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the widget's value.</summary>
		[Generated]
		public RangeSliderBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public RangeSliderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public RangeSliderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public RangeSliderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public RangeSliderBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public RangeSliderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
