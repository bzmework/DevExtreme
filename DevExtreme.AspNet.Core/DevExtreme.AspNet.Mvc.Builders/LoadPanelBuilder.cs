using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The LoadPanel is an overlay widget notifying the viewer that loading is in progress.</summary>
	public class LoadPanelBuilder : WidgetBuilder
	{
		[Generated]
		public LoadPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public LoadPanelBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public LoadPanelBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LoadPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public LoadPanelBuilder Animation(Action<LoadPanelAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public LoadPanelBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the widget if a user clicks outside it.</summary>
		[Generated]
		public LoadPanelBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies the widget's container.</summary>
		[Generated]
		public LoadPanelBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the widget's container.</summary>
		[Generated]
		public LoadPanelBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public LoadPanelBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public LoadPanelBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the load panel is displayed.</summary>
		[Generated]
		public LoadPanelBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the load panel is displayed.</summary>
		[Generated]
		public LoadPanelBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LoadPanelBuilder ElementAttr(string attributeName, object value)
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
		public LoadPanelBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LoadPanelBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LoadPanelBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget can be focused.</summary>
		[Generated]
		public LoadPanelBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget can be focused.</summary>
		[Generated]
		public LoadPanelBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public LoadPanelBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public LoadPanelBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public LoadPanelBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public LoadPanelBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>A URL pointing to an image to be used as a load indicator.</summary>
		[Generated]
		public LoadPanelBuilder IndicatorSrc(string value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>A URL pointing to an image to be used as a load indicator.</summary>
		[Generated]
		public LoadPanelBuilder IndicatorSrc(JS value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxHeight(string value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxWidth(string value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the load panel. Ignored in the Material Design theme.</summary>
		[Generated]
		public LoadPanelBuilder Message(string value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the load panel. Ignored in the Material Design theme.</summary>
		[Generated]
		public LoadPanelBuilder Message(JS value)
		{
			base.Options["message"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinHeight(string value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinWidth(string value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public LoadPanelBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public LoadPanelBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public LoadPanelBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public LoadPanelBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public LoadPanelBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public LoadPanelBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public LoadPanelBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public LoadPanelBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public LoadPanelBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public LoadPanelBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public LoadPanelBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public LoadPanelBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public LoadPanelBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public LoadPanelBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public LoadPanelBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public LoadPanelBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public LoadPanelBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public LoadPanelBuilder Position(PositionAlignment value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Positions the widget.</summary>
		[Generated]
		public LoadPanelBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public LoadPanelBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public LoadPanelBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public LoadPanelBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public LoadPanelBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public LoadPanelBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public LoadPanelBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to show a load indicator.</summary>
		[Generated]
		public LoadPanelBuilder ShowIndicator(bool value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to show a load indicator.</summary>
		[Generated]
		public LoadPanelBuilder ShowIndicator(JS value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to show the pane behind the load indicator.</summary>
		[Generated]
		public LoadPanelBuilder ShowPane(bool value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to show the pane behind the load indicator.</summary>
		[Generated]
		public LoadPanelBuilder ShowPane(JS value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public LoadPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public LoadPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width in pixels.</summary>
		[Generated]
		public LoadPanelBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
