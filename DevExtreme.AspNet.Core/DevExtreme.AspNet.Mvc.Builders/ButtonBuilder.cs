using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Button widget is a simple button that performs specified commands when a user clicks it.</summary>
	public class ButtonBuilder : WidgetBuilder
	{
		protected override void OnBeforeRendering()
		{
			base.OnBeforeRendering();
			AppendValidationGroup();
		}

		[Generated]
		public ButtonBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ButtonBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ButtonBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ButtonBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public ButtonBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public ButtonBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ButtonBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ButtonBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ButtonBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ButtonBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ButtonBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ButtonBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonBuilder ElementAttr(string attributeName, object value)
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
		public ButtonBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ButtonBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ButtonBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ButtonBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ButtonBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ButtonBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ButtonBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed on the button.</summary>
		[Generated]
		public ButtonBuilder Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed on the button.</summary>
		[Generated]
		public ButtonBuilder Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>A function that is executed when the Button is clicked or tapped.</summary>
		[Generated]
		public ButtonBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Button is clicked or tapped.</summary>
		[Generated]
		public ButtonBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ButtonBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ButtonBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ButtonBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ButtonBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ButtonBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ButtonBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ButtonBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ButtonBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ButtonBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ButtonBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies how the button is styled.</summary>
		[Generated]
		public ButtonBuilder StylingMode(ButtonStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ButtonBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ButtonBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the Button widget.</summary>
		[Generated]
		public ButtonBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the Button widget.</summary>
		[Generated]
		public ButtonBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the Button widget.</summary>
		[Generated]
		public ButtonBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom template for the Button widget.</summary>
		[Generated]
		public ButtonBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>The text displayed on the button.</summary>
		[Generated]
		public ButtonBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>The text displayed on the button.</summary>
		[Generated]
		public ButtonBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the button type.</summary>
		[Generated]
		public ButtonBuilder Type(ButtonType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies whether the button submits an HTML form.</summary>
		[Generated]
		public ButtonBuilder UseSubmitBehavior(bool value)
		{
			base.Options["useSubmitBehavior"] = value;
			return this;
		}

		/// <summary>Specifies whether the button submits an HTML form.</summary>
		[Generated]
		public ButtonBuilder UseSubmitBehavior(JS value)
		{
			base.Options["useSubmitBehavior"] = value;
			return this;
		}

		/// <summary>Specifies the name of the validation group to be accessed in the click event handler.</summary>
		[Generated]
		public ButtonBuilder ValidationGroup(string value)
		{
			base.Options["validationGroup"] = value;
			return this;
		}

		/// <summary>Specifies the name of the validation group to be accessed in the click event handler.</summary>
		[Generated]
		public ButtonBuilder ValidationGroup(JS value)
		{
			base.Options["validationGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ButtonBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ButtonBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
