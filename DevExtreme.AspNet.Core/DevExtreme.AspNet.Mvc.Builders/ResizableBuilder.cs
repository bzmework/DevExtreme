using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Resizable widget enables its content to be resizable in the UI.</summary>
	public class ResizableBuilder : WidgetBuilder
	{
		[Generated]
		public ResizableBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ResizableBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ResizableBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ResizableBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public ResizableBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public ResizableBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ResizableBuilder ElementAttr(string attributeName, object value)
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
		public ResizableBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ResizableBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ResizableBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies which borders of the widget element are used as a handle.</summary>
		[Generated]
		public ResizableBuilder Handles(params ResizeHandle[] values)
		{
			base.Options["handles"] = string.Join(" ", values).ToLower();
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ResizableBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ResizableBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ResizableBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the upper height boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MaxHeight(double value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the upper height boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MaxHeight(JS value)
		{
			base.Options["maxHeight"] = value;
			return this;
		}

		/// <summary>Specifies the upper width boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MaxWidth(double value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the upper width boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MaxWidth(JS value)
		{
			base.Options["maxWidth"] = value;
			return this;
		}

		/// <summary>Specifies the lower height boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MinHeight(double value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the lower height boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MinHeight(JS value)
		{
			base.Options["minHeight"] = value;
			return this;
		}

		/// <summary>Specifies the lower width boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MinWidth(double value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>Specifies the lower width boundary for resizing.</summary>
		[Generated]
		public ResizableBuilder MinWidth(JS value)
		{
			base.Options["minWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ResizableBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ResizableBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ResizableBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ResizableBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ResizableBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ResizableBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget is resized by one pixel.</summary>
		[Generated]
		public ResizableBuilder OnResize(string jsFunc)
		{
			AssignJS("onResize", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget is resized by one pixel.</summary>
		[Generated]
		public ResizableBuilder OnResize(RazorBlock jsFunc)
		{
			return OnResize(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when resizing ends.</summary>
		[Generated]
		public ResizableBuilder OnResizeEnd(string jsFunc)
		{
			AssignJS("onResizeEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when resizing ends.</summary>
		[Generated]
		public ResizableBuilder OnResizeEnd(RazorBlock jsFunc)
		{
			return OnResizeEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when resizing starts.</summary>
		[Generated]
		public ResizableBuilder OnResizeStart(string jsFunc)
		{
			AssignJS("onResizeStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when resizing starts.</summary>
		[Generated]
		public ResizableBuilder OnResizeStart(RazorBlock jsFunc)
		{
			return OnResizeStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ResizableBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ResizableBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ResizableBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ResizableBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ResizableBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
