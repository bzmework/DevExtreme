using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Popup widget is a pop-up window overlaying the current view.</summary>
	public class PopupBuilder : WidgetBuilder
	{
		[Generated]
		public PopupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public PopupBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public PopupBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PopupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public PopupBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public PopupBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public PopupBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public PopupBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public PopupBuilder Animation(Action<PopupAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public PopupBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public PopupBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public PopupBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public PopupBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopupBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopupBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopupBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopupBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public PopupBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public PopupBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PopupBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PopupBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to allow a user to drag the popup window.</summary>
		[Generated]
		public PopupBuilder DragEnabled(bool value)
		{
			base.Options["dragEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to allow a user to drag the popup window.</summary>
		[Generated]
		public PopupBuilder DragEnabled(JS value)
		{
			base.Options["dragEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopupBuilder ElementAttr(string attributeName, object value)
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
		public PopupBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopupBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopupBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public PopupBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public PopupBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the widget in full-screen mode.</summary>
		[Generated]
		public PopupBuilder FullScreen(bool value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the widget in full-screen mode.</summary>
		[Generated]
		public PopupBuilder FullScreen(JS value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public PopupBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public PopupBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public PopupBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PopupBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PopupBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public PopupBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public PopupBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxHeight(string value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxWidth(string value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinHeight(string value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinWidth(string value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopupBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PopupBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PopupBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PopupBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PopupBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public PopupBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public PopupBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public PopupBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public PopupBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PopupBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PopupBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PopupBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PopupBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget is resized by one pixel.</summary>
		[Generated]
		public PopupBuilder OnResize(string jsFunc)
		{
			AssignJS("onResize", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget is resized by one pixel.</summary>
		[Generated]
		public PopupBuilder OnResize(RazorBlock jsFunc)
		{
			return OnResize(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when resizing ends.</summary>
		[Generated]
		public PopupBuilder OnResizeEnd(string jsFunc)
		{
			AssignJS("onResizeEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when resizing ends.</summary>
		[Generated]
		public PopupBuilder OnResizeEnd(RazorBlock jsFunc)
		{
			return OnResizeEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when resizing starts.</summary>
		[Generated]
		public PopupBuilder OnResizeStart(string jsFunc)
		{
			AssignJS("onResizeStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when resizing starts.</summary>
		[Generated]
		public PopupBuilder OnResizeStart(RazorBlock jsFunc)
		{
			return OnResizeStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public PopupBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public PopupBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public PopupBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public PopupBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's title is rendered.</summary>
		[Generated]
		public PopupBuilder OnTitleRendered(string jsFunc)
		{
			AssignJS("onTitleRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's title is rendered.</summary>
		[Generated]
		public PopupBuilder OnTitleRendered(RazorBlock jsFunc)
		{
			return OnTitleRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public PopupBuilder Position(PositionAlignment value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public PopupBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Specifies whether or not an end user can resize the widget.</summary>
		[Generated]
		public PopupBuilder ResizeEnabled(bool value)
		{
			base.Options["resizeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end user can resize the widget.</summary>
		[Generated]
		public PopupBuilder ResizeEnabled(JS value)
		{
			base.Options["resizeEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PopupBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PopupBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public PopupBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public PopupBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public PopupBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public PopupBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the Close button.</summary>
		[Generated]
		public PopupBuilder ShowCloseButton(bool value)
		{
			base.Options["showCloseButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the Close button.</summary>
		[Generated]
		public PopupBuilder ShowCloseButton(JS value)
		{
			base.Options["showCloseButton"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the popup window.</summary>
		[Generated]
		public PopupBuilder ShowTitle(bool value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the popup window.</summary>
		[Generated]
		public PopupBuilder ShowTitle(JS value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public PopupBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public PopupBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>The title in the overlay window.</summary>
		[Generated]
		public PopupBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>The title in the overlay window.</summary>
		[Generated]
		public PopupBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopupBuilder TitleTemplate(string templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopupBuilder TitleTemplate(RazorBlock templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopupBuilder TitleTemplate(TemplateName name)
		{
			AssignTemplate("titleTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopupBuilder TitleTemplate(JS value)
		{
			base.Options["titleTemplate"] = value;
			return this;
		}

		/// <summary>Configures toolbar items.</summary>
		[Generated]
		public PopupBuilder ToolbarItems(Action<CollectionFactory<PopupToolbarItemBuilder>> configurator)
		{
			Collection("toolbarItems", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public PopupBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public PopupBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public PopupBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public PopupBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public PopupBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
