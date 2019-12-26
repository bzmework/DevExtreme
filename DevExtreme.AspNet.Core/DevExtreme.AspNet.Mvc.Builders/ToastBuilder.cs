using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Toast is a widget that provides pop-up notifications.</summary>
	public class ToastBuilder : WidgetBuilder
	{
		[Generated]
		public ToastBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ToastBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ToastBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ToastBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ToastBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ToastBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public ToastBuilder Animation(Action<ToastAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the toast is closed if a user clicks it.</summary>
		[Generated]
		public ToastBuilder CloseOnClick(bool value)
		{
			base.Options["closeOnClick"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the toast is closed if a user clicks it.</summary>
		[Generated]
		public ToastBuilder CloseOnClick(JS value)
		{
			base.Options["closeOnClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public ToastBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public ToastBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the toast is closed if a user swipes it out of the screen boundaries.</summary>
		[Generated]
		public ToastBuilder CloseOnSwipe(bool value)
		{
			base.Options["closeOnSwipe"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the toast is closed if a user swipes it out of the screen boundaries.</summary>
		[Generated]
		public ToastBuilder CloseOnSwipe(JS value)
		{
			base.Options["closeOnSwipe"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public ToastBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public ToastBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public ToastBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public ToastBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public ToastBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public ToastBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>The time span in milliseconds during which the Toast widget is visible.</summary>
		[Generated]
		public ToastBuilder DisplayTime(double value)
		{
			base.Options["displayTime"] = value;
			return this;
		}

		/// <summary>The time span in milliseconds during which the Toast widget is visible.</summary>
		[Generated]
		public ToastBuilder DisplayTime(JS value)
		{
			base.Options["displayTime"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToastBuilder ElementAttr(string attributeName, object value)
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
		public ToastBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToastBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToastBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ToastBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ToastBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public ToastBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public ToastBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public ToastBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ToastBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ToastBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ToastBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ToastBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxHeight(string value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxWidth(string value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>The Toast message text.</summary>
		[Generated]
		public ToastBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>The Toast message text.</summary>
		[Generated]
		public ToastBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinHeight(string value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinWidth(string value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public ToastBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ToastBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ToastBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ToastBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ToastBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public ToastBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public ToastBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public ToastBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public ToastBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ToastBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ToastBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ToastBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ToastBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public ToastBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public ToastBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public ToastBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public ToastBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public ToastBuilder Position(string value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public ToastBuilder Position(JS value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public ToastBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ToastBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ToastBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public ToastBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public ToastBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public ToastBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public ToastBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ToastBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ToastBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the Toast widget type.</summary>
		[Generated]
		public ToastBuilder Type(ToastType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public ToastBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public ToastBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public ToastBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public ToastBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public ToastBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
