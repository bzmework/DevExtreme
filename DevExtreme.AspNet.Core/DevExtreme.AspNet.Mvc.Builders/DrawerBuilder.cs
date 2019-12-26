using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Drawer is a dismissible or permanently visible panel used for navigation in responsive web application layouts.</summary>
	public class DrawerBuilder : WidgetBuilder
	{
		[Generated]
		public DrawerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DrawerBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DrawerBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DrawerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public DrawerBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public DrawerBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DrawerBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DrawerBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the duration of the drawer's opening and closing animation (in milliseconds). Applies only if animationEnabled is true.</summary>
		[Generated]
		public DrawerBuilder AnimationDuration(double value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>Specifies the duration of the drawer's opening and closing animation (in milliseconds). Applies only if animationEnabled is true.</summary>
		[Generated]
		public DrawerBuilder AnimationDuration(JS value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>Specifies whether to use an opening and closing animation.</summary>
		[Generated]
		public DrawerBuilder AnimationEnabled(bool value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to use an opening and closing animation.</summary>
		[Generated]
		public DrawerBuilder AnimationEnabled(JS value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the drawer if a user clicks or taps the view area.</summary>
		[Generated]
		public DrawerBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the drawer if a user clicks or taps the view area.</summary>
		[Generated]
		public DrawerBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DrawerBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DrawerBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DrawerBuilder ElementAttr(string attributeName, object value)
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
		public DrawerBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DrawerBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DrawerBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DrawerBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DrawerBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DrawerBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DrawerBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DrawerBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DrawerBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DrawerBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's width or height (depending on the drawer's position) in the opened state.</summary>
		[Generated]
		public DrawerBuilder MaxSize(double value)
		{
			base.Options["maxSize"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's width or height (depending on the drawer's position) in the opened state.</summary>
		[Generated]
		public DrawerBuilder MaxSize(JS value)
		{
			base.Options["maxSize"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's width or height (depending on the drawer's position) in the closed state.</summary>
		[Generated]
		public DrawerBuilder MinSize(double value)
		{
			base.Options["minSize"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's width or height (depending on the drawer's position) in the closed state.</summary>
		[Generated]
		public DrawerBuilder MinSize(JS value)
		{
			base.Options["minSize"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DrawerBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DrawerBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DrawerBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DrawerBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DrawerBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DrawerBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the drawer is opened.</summary>
		[Generated]
		public DrawerBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether the drawer is opened.</summary>
		[Generated]
		public DrawerBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies how the drawer interacts with the view in the opened state.</summary>
		[Generated]
		public DrawerBuilder OpenedStateMode(DrawerOpenedStateMode value)
		{
			base.Options["openedStateMode"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's position in relation to the view.</summary>
		[Generated]
		public DrawerBuilder Position(DrawerPosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's reveal mode.</summary>
		[Generated]
		public DrawerBuilder RevealMode(DrawerRevealMode value)
		{
			base.Options["revealMode"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DrawerBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DrawerBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the view when the drawer is opened.</summary>
		[Generated]
		public DrawerBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the view when the drawer is opened.</summary>
		[Generated]
		public DrawerBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for the element in which the drawer should be rendered. Applies only when the openedStateMode is "overlap".</summary>
		[Generated]
		public DrawerBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for the element in which the drawer should be rendered. Applies only when the openedStateMode is "overlap".</summary>
		[Generated]
		public DrawerBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>Specifies the drawer's content.</summary>
		[Generated]
		public DrawerBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies the drawer's content.</summary>
		[Generated]
		public DrawerBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies the drawer's content.</summary>
		[Generated]
		public DrawerBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies the drawer's content.</summary>
		[Generated]
		public DrawerBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DrawerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DrawerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DrawerBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DrawerBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DrawerBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
