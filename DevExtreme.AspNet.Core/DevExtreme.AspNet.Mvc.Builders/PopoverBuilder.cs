using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Popover is a widget that shows notifications within a box with an arrow pointing to a specified UI element.</summary>
	public class PopoverBuilder : WidgetBuilder
	{
		[Generated]
		public PopoverBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public PopoverBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public PopoverBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PopoverBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public PopoverBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public PopoverBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public PopoverBuilder Animation(Action<PopoverAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is closed if a user clicks outside of the popover window and outside the target element.</summary>
		[Generated]
		public PopoverBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is closed if a user clicks outside of the popover window and outside the target element.</summary>
		[Generated]
		public PopoverBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public PopoverBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to place the widget.</summary>
		[Generated]
		public PopoverBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopoverBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopoverBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopoverBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public PopoverBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public PopoverBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the widget's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public PopoverBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PopoverBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PopoverBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopoverBuilder ElementAttr(string attributeName, object value)
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
		public PopoverBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopoverBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PopoverBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PopoverBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PopoverBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PopoverBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public PopoverBuilder HideEvent(Action<PopoverHideEventBuilder> configurator)
		{
			NestedOptions("hideEvent", configurator);
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public PopoverBuilder HideEvent(string value)
		{
			base.Options["hideEvent"] = value;
			return this;
		}

		/// <summary>Specifies options of popover hiding.</summary>
		[Generated]
		public PopoverBuilder HideEvent(JS value)
		{
			base.Options["hideEvent"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PopoverBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PopoverBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public PopoverBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public PopoverBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxHeight(string value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxWidth(string value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the maximum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinHeight(string value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum height the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinWidth(string value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the minimum width the widget can reach while resizing.</summary>
		[Generated]
		public PopoverBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PopoverBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PopoverBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PopoverBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PopoverBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public PopoverBuilder OnHidden(string jsFunc)
		{
			AssignJS("onHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is hidden.</summary>
		[Generated]
		public PopoverBuilder OnHidden(RazorBlock jsFunc)
		{
			return OnHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public PopoverBuilder OnHiding(string jsFunc)
		{
			AssignJS("onHiding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is hidden.</summary>
		[Generated]
		public PopoverBuilder OnHiding(RazorBlock jsFunc)
		{
			return OnHiding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PopoverBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PopoverBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PopoverBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PopoverBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public PopoverBuilder OnShowing(string jsFunc)
		{
			AssignJS("onShowing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is displayed.</summary>
		[Generated]
		public PopoverBuilder OnShowing(RazorBlock jsFunc)
		{
			return OnShowing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public PopoverBuilder OnShown(string jsFunc)
		{
			AssignJS("onShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is displayed.</summary>
		[Generated]
		public PopoverBuilder OnShown(RazorBlock jsFunc)
		{
			return OnShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's title is rendered.</summary>
		[Generated]
		public PopoverBuilder OnTitleRendered(string jsFunc)
		{
			AssignJS("onTitleRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's title is rendered.</summary>
		[Generated]
		public PopoverBuilder OnTitleRendered(RazorBlock jsFunc)
		{
			return OnTitleRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public PopoverBuilder Position(Position value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public PopoverBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PopoverBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PopoverBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public PopoverBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the background when the widget is active.</summary>
		[Generated]
		public PopoverBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public PopoverBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color.</summary>
		[Generated]
		public PopoverBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the Close button.</summary>
		[Generated]
		public PopoverBuilder ShowCloseButton(bool value)
		{
			base.Options["showCloseButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays the Close button.</summary>
		[Generated]
		public PopoverBuilder ShowCloseButton(JS value)
		{
			base.Options["showCloseButton"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public PopoverBuilder ShowEvent(Action<PopoverShowEventBuilder> configurator)
		{
			NestedOptions("showEvent", configurator);
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public PopoverBuilder ShowEvent(string value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>Specifies options for displaying the widget.</summary>
		[Generated]
		public PopoverBuilder ShowEvent(JS value)
		{
			base.Options["showEvent"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the overlay window.</summary>
		[Generated]
		public PopoverBuilder ShowTitle(bool value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the overlay window.</summary>
		[Generated]
		public PopoverBuilder ShowTitle(JS value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>The target element associated with the widget.</summary>
		[Generated]
		public PopoverBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>The target element associated with the widget.</summary>
		[Generated]
		public PopoverBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>The title in the overlay window.</summary>
		[Generated]
		public PopoverBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>The title in the overlay window.</summary>
		[Generated]
		public PopoverBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopoverBuilder TitleTemplate(string templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopoverBuilder TitleTemplate(RazorBlock templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopoverBuilder TitleTemplate(TemplateName name)
		{
			AssignTemplate("titleTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget title. Does not apply if the title is defined.</summary>
		[Generated]
		public PopoverBuilder TitleTemplate(JS value)
		{
			base.Options["titleTemplate"] = value;
			return this;
		}

		/// <summary>Configures toolbar items.</summary>
		[Generated]
		public PopoverBuilder ToolbarItems(Action<CollectionFactory<PopoverToolbarItemBuilder>> configurator)
		{
			Collection("toolbarItems", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public PopoverBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is visible.</summary>
		[Generated]
		public PopoverBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PopoverBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PopoverBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PopoverBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
