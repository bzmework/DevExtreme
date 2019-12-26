using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The SlideOutView widget is a classic slide-out menu paired with a view. This widget is very similar to the SlideOut with only one difference - the SlideOut always contains the List in the slide-out menu, while the SlideOutView can hold any collection there.</summary>
	public class SlideOutViewBuilder : WidgetBuilder
	{
		[Generated]
		public SlideOutViewBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SlideOutViewBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SlideOutViewBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SlideOutViewBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public SlideOutViewBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public SlideOutViewBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SlideOutViewBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public SlideOutViewBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SlideOutViewBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SlideOutViewBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutViewBuilder ElementAttr(string attributeName, object value)
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
		public SlideOutViewBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutViewBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SlideOutViewBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutViewBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutViewBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SlideOutViewBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SlideOutViewBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SlideOutViewBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SlideOutViewBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public SlideOutViewBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the current menu position.</summary>
		[Generated]
		public SlideOutViewBuilder MenuPosition(SlideOutMenuPosition value)
		{
			base.Options["menuPosition"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the menu content.</summary>
		[Generated]
		public SlideOutViewBuilder MenuTemplate(string templateContent)
		{
			AssignTemplate("menuTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the menu content.</summary>
		[Generated]
		public SlideOutViewBuilder MenuTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the menu content.</summary>
		[Generated]
		public SlideOutViewBuilder MenuTemplate(TemplateName name)
		{
			AssignTemplate("menuTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the menu content.</summary>
		[Generated]
		public SlideOutViewBuilder MenuTemplate(JS value)
		{
			base.Options["menuTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu panel is visible.</summary>
		[Generated]
		public SlideOutViewBuilder MenuVisible(bool value)
		{
			base.Options["menuVisible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu panel is visible.</summary>
		[Generated]
		public SlideOutViewBuilder MenuVisible(JS value)
		{
			base.Options["menuVisible"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SlideOutViewBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SlideOutViewBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SlideOutViewBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SlideOutViewBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SlideOutViewBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SlideOutViewBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SlideOutViewBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SlideOutViewBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu is shown when a user swipes the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder SwipeEnabled(bool value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the menu is shown when a user swipes the widget content.</summary>
		[Generated]
		public SlideOutViewBuilder SwipeEnabled(JS value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SlideOutViewBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SlideOutViewBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutViewBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutViewBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SlideOutViewBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
