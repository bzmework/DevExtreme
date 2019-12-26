using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Draggable is a user interface utility that allows widget elements to be dragged and dropped.</summary>
	public class DraggableBuilder : WidgetBuilder
	{
		[Generated]
		public DraggableBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DraggableBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DraggableBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DraggableBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public DraggableBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public DraggableBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an item beyond the viewport.</summary>
		[Generated]
		public DraggableBuilder AutoScroll(bool value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an item beyond the viewport.</summary>
		[Generated]
		public DraggableBuilder AutoScroll(JS value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public DraggableBuilder Boundary(string value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public DraggableBuilder Boundary(JS value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Allows a user to drag clones of items instead of actual items.</summary>
		[Generated]
		public DraggableBuilder Clone(bool value)
		{
			base.Options["clone"] = value;
			return this;
		}

		/// <summary>Allows a user to drag clones of items instead of actual items.</summary>
		[Generated]
		public DraggableBuilder Clone(JS value)
		{
			base.Options["clone"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable item should be rendered.</summary>
		[Generated]
		public DraggableBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable item should be rendered.</summary>
		[Generated]
		public DraggableBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public DraggableBuilder CursorOffset(Action<DraggableCursorOffsetBuilder> configurator)
		{
			NestedOptions("cursorOffset", configurator);
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public DraggableBuilder CursorOffset(string value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public DraggableBuilder CursorOffset(JS value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public DraggableBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Specifies the directions in which an item can be dragged.</summary>
		[Generated]
		public DraggableBuilder DragDirection(DragDirection value)
		{
			base.Options["dragDirection"] = value;
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DraggableBuilder DragTemplate(string templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DraggableBuilder DragTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DraggableBuilder DragTemplate(TemplateName name)
		{
			AssignTemplate("dragTemplate", name);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DraggableBuilder DragTemplate(JS value)
		{
			base.Options["dragTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DraggableBuilder ElementAttr(string attributeName, object value)
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
		public DraggableBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DraggableBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DraggableBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets, so that users can drag and drop items between them.</summary>
		[Generated]
		public DraggableBuilder Group(string value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets, so that users can drag and drop items between them.</summary>
		[Generated]
		public DraggableBuilder Group(JS value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) that should act as the drag handle(s) for the item(s).</summary>
		[Generated]
		public DraggableBuilder Handle(string value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) that should act as the drag handle(s) for the item(s).</summary>
		[Generated]
		public DraggableBuilder Handle(JS value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DraggableBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DraggableBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DraggableBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DraggableBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DraggableBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when drag gesture is finished.</summary>
		[Generated]
		public DraggableBuilder OnDragEnd(string jsFunc)
		{
			AssignJS("onDragEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when drag gesture is finished.</summary>
		[Generated]
		public DraggableBuilder OnDragEnd(RazorBlock jsFunc)
		{
			return OnDragEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called every time a draggable item is moved.</summary>
		[Generated]
		public DraggableBuilder OnDragMove(string jsFunc)
		{
			AssignJS("onDragMove", jsFunc);
			return this;
		}

		/// <summary>A function that is called every time a draggable item is moved.</summary>
		[Generated]
		public DraggableBuilder OnDragMove(RazorBlock jsFunc)
		{
			return OnDragMove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public DraggableBuilder OnDragStart(string jsFunc)
		{
			AssignJS("onDragStart", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public DraggableBuilder OnDragStart(RazorBlock jsFunc)
		{
			return OnDragStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DraggableBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DraggableBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DraggableBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DraggableBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DraggableBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DraggableBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public DraggableBuilder ScrollSensitivity(double value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public DraggableBuilder ScrollSensitivity(JS value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an item beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public DraggableBuilder ScrollSpeed(double value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an item beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public DraggableBuilder ScrollSpeed(JS value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DraggableBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DraggableBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DraggableBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
