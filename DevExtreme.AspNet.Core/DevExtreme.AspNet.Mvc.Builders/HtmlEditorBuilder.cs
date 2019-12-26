using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>[tags] ctp HtmlEditor is a WYSIWYG editor that allows you to format textual and visual content and to output it in HTML or Markdown. HtmlEditor is built on top of and requires Quill. #include common-ctp-note with { component: "HtmlEditor" }</summary>
	public class HtmlEditorBuilder : WidgetBuilder
	{
		[Generated]
		public HtmlEditorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public HtmlEditorBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public HtmlEditorBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public HtmlEditorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public HtmlEditorBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public HtmlEditorBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public HtmlEditorBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public HtmlEditorBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public HtmlEditorBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public HtmlEditorBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Allows you to customize Quill and 3rd-party modules.</summary>
		[Generated]
		public HtmlEditorBuilder CustomizeModules(string jsFunc)
		{
			AssignJS("customizeModules", jsFunc);
			return this;
		}

		/// <summary>Allows you to customize Quill and 3rd-party modules.</summary>
		[Generated]
		public HtmlEditorBuilder CustomizeModules(RazorBlock jsFunc)
		{
			return CustomizeModules(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public HtmlEditorBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public HtmlEditorBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public HtmlEditorBuilder ElementAttr(string attributeName, object value)
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
		public HtmlEditorBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public HtmlEditorBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public HtmlEditorBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public HtmlEditorBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public HtmlEditorBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public HtmlEditorBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public HtmlEditorBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public HtmlEditorBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public HtmlEditorBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public HtmlEditorBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public HtmlEditorBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public HtmlEditorBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public HtmlEditorBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public HtmlEditorBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Configures media resizing.</summary>
		[Generated]
		public HtmlEditorBuilder MediaResizing(Action<HtmlEditorMediaResizingBuilder> configurator)
		{
			NestedOptions("mediaResizing", configurator);
			return this;
		}

		/// <summary>Configures mentions.</summary>
		[Generated]
		public HtmlEditorBuilder Mentions(Action<CollectionFactory<HtmlEditorMentionBuilder>> configurator)
		{
			Collection("mentions", configurator);
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public HtmlEditorBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public HtmlEditorBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public HtmlEditorBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public HtmlEditorBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public HtmlEditorBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public HtmlEditorBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public HtmlEditorBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public HtmlEditorBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public HtmlEditorBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public HtmlEditorBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public HtmlEditorBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the text displayed when the input field is empty.</summary>
		[Generated]
		public HtmlEditorBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed when the input field is empty.</summary>
		[Generated]
		public HtmlEditorBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public HtmlEditorBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public HtmlEditorBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public HtmlEditorBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public HtmlEditorBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public HtmlEditorBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public HtmlEditorBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Configures the widget's toolbar.</summary>
		[Generated]
		public HtmlEditorBuilder Toolbar(Action<HtmlEditorToolbarBuilder> configurator)
		{
			NestedOptions("toolbar", configurator);
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public HtmlEditorBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public HtmlEditorBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public HtmlEditorBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public HtmlEditorBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public HtmlEditorBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the widget's value.</summary>
		[Generated]
		public HtmlEditorBuilder Value(object value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies in which markup language the value is stored.</summary>
		[Generated]
		public HtmlEditorBuilder ValueType(HtmlEditorValueType value)
		{
			base.Options["valueType"] = value;
			return this;
		}

		/// <summary>Configures variables, which are placeholders to be replaced with actual values when processing text.</summary>
		[Generated]
		public HtmlEditorBuilder Variables(Action<HtmlEditorVariablesBuilder> configurator)
		{
			NestedOptions("variables", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public HtmlEditorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public HtmlEditorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public HtmlEditorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public HtmlEditorBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public HtmlEditorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
