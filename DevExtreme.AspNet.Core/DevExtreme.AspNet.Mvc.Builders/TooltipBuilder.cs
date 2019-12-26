using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Tooltip widget displays a tooltip for a specified element on the page.</summary>
	public class TooltipBuilder : WidgetBuilder
	{
		[Generated]
		public TooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TooltipBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TooltipBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public TooltipBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public TooltipBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public TooltipBuilder Animation(Action<TooltipAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is closed if a user clicks outside of the popover window and outside the target element.</summary>
		[Generated]
		public TooltipBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is closed if a user clicks outside of the popover window and outside the target element.</summary>
		[Generated]
		public TooltipBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public TooltipBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public TooltipBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public TooltipBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public TooltipBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public TooltipBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public TooltipBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public TooltipBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public TooltipBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TooltipBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TooltipBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TooltipBuilder ElementAttr(string attributeName, object value)
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
		public TooltipBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TooltipBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TooltipBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TooltipBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TooltipBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TooltipBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public TooltipBuilder HideEvent(Action<TooltipHideEventBuilder> configurator)
		{
			NestedOptions("hideEvent", configurator);
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public TooltipBuilder HideEvent(string value)
		{
			base.Options["hideEvent"] = value;
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public TooltipBuilder HideEvent(JS value)
		{
			base.Options["hideEvent"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TooltipBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TooltipBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TooltipBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TooltipBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxHeight(string value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxWidth(string value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinHeight(string value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinWidth(string value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public TooltipBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TooltipBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TooltipBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TooltipBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TooltipBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public TooltipBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public TooltipBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public TooltipBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public TooltipBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TooltipBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TooltipBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TooltipBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TooltipBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public TooltipBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public TooltipBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public TooltipBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public TooltipBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public TooltipBuilder Position(Position value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public TooltipBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TooltipBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TooltipBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public TooltipBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public TooltipBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public TooltipBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public TooltipBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public TooltipBuilder ShowEvent(Action<TooltipShowEventBuilder> configurator)
		{
			NestedOptions("showEvent", configurator);
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public TooltipBuilder ShowEvent(string value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public TooltipBuilder ShowEvent(JS value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>The target element associated with the widget.</summary>
		[Generated]
		public TooltipBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>The target element associated with the widget.</summary>
		[Generated]
		public TooltipBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public TooltipBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public TooltipBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TooltipBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TooltipBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TooltipBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
