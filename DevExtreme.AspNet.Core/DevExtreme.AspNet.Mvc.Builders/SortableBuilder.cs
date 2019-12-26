using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Sortable is a user interface utility that allows a widget's items to be reordered via drag and drop gestures.</summary>
	public class SortableBuilder : WidgetBuilder
	{
		[Generated]
		public SortableBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SortableBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SortableBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SortableBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		[Generated]
		public SortableBuilder Content(string content)
		{
			AssignContent(content);
			return this;
		}

		[Generated]
		public SortableBuilder Content(RazorBlock content)
		{
			AssignContent(content);
			return this;
		}

		/// <summary>Allows a user to drop an item inside another item.</summary>
		[Generated]
		public SortableBuilder AllowDropInsideItem(bool value)
		{
			base.Options["allowDropInsideItem"] = value;
			return this;
		}

		/// <summary>Allows a user to drop an item inside another item.</summary>
		[Generated]
		public SortableBuilder AllowDropInsideItem(JS value)
		{
			base.Options["allowDropInsideItem"] = value;
			return this;
		}

		/// <summary>Allows a user to reorder sortable items.</summary>
		[Generated]
		public SortableBuilder AllowReordering(bool value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Allows a user to reorder sortable items.</summary>
		[Generated]
		public SortableBuilder AllowReordering(JS value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an item beyond the viewport.</summary>
		[Generated]
		public SortableBuilder AutoScroll(bool value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an item beyond the viewport.</summary>
		[Generated]
		public SortableBuilder AutoScroll(JS value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public SortableBuilder Boundary(string value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public SortableBuilder Boundary(JS value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable item should be rendered.</summary>
		[Generated]
		public SortableBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable item should be rendered.</summary>
		[Generated]
		public SortableBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public SortableBuilder CursorOffset(Action<SortableCursorOffsetBuilder> configurator)
		{
			NestedOptions("cursorOffset", configurator);
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public SortableBuilder CursorOffset(string value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged item.</summary>
		[Generated]
		public SortableBuilder CursorOffset(JS value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public SortableBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Specifies the directions in which an item can be dragged.</summary>
		[Generated]
		public SortableBuilder DragDirection(DragDirection value)
		{
			base.Options["dragDirection"] = value;
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public SortableBuilder DragTemplate(string templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public SortableBuilder DragTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public SortableBuilder DragTemplate(TemplateName name)
		{
			AssignTemplate("dragTemplate", name);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public SortableBuilder DragTemplate(JS value)
		{
			base.Options["dragTemplate"] = value;
			return this;
		}

		/// <summary>Specifies how to highlight the item's drop position.</summary>
		[Generated]
		public SortableBuilder DropFeedbackMode(DropFeedbackMode value)
		{
			base.Options["dropFeedbackMode"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SortableBuilder ElementAttr(string attributeName, object value)
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
		public SortableBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SortableBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SortableBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for the items that can be dragged.</summary>
		[Generated]
		public SortableBuilder Filter(string value)
		{
			base.Options["filter"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for the items that can be dragged.</summary>
		[Generated]
		public SortableBuilder Filter(JS value)
		{
			base.Options["filter"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets, so that users can drag and drop items between them.</summary>
		[Generated]
		public SortableBuilder Group(string value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets, so that users can drag and drop items between them.</summary>
		[Generated]
		public SortableBuilder Group(JS value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) that should act as the drag handle(s) for the item(s).</summary>
		[Generated]
		public SortableBuilder Handle(string value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) that should act as the drag handle(s) for the item(s).</summary>
		[Generated]
		public SortableBuilder Handle(JS value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SortableBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SortableBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SortableBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Notifies the widget of the items' orientation.</summary>
		[Generated]
		public SortableBuilder ItemOrientation(Orientation value)
		{
			base.Options["itemOrientation"] = value;
			return this;
		}

		/// <summary>Moves an element in the HTML markup when it is dropped.</summary>
		[Generated]
		public SortableBuilder MoveItemOnDrop(bool value)
		{
			base.Options["moveItemOnDrop"] = value;
			return this;
		}

		/// <summary>Moves an element in the HTML markup when it is dropped.</summary>
		[Generated]
		public SortableBuilder MoveItemOnDrop(JS value)
		{
			base.Options["moveItemOnDrop"] = value;
			return this;
		}

		/// <summary>A function that is called when a new item is added.</summary>
		[Generated]
		public SortableBuilder OnAdd(string jsFunc)
		{
			AssignJS("onAdd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a new item is added.</summary>
		[Generated]
		public SortableBuilder OnAdd(RazorBlock jsFunc)
		{
			return OnAdd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SortableBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SortableBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the dragged item's position in the list is changed.</summary>
		[Generated]
		public SortableBuilder OnDragChange(string jsFunc)
		{
			AssignJS("onDragChange", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the dragged item's position in the list is changed.</summary>
		[Generated]
		public SortableBuilder OnDragChange(RazorBlock jsFunc)
		{
			return OnDragChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the drag gesture is finished.</summary>
		[Generated]
		public SortableBuilder OnDragEnd(string jsFunc)
		{
			AssignJS("onDragEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the drag gesture is finished.</summary>
		[Generated]
		public SortableBuilder OnDragEnd(RazorBlock jsFunc)
		{
			return OnDragEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called every time a draggable item is moved.</summary>
		[Generated]
		public SortableBuilder OnDragMove(string jsFunc)
		{
			AssignJS("onDragMove", jsFunc);
			return this;
		}

		/// <summary>A function that is called every time a draggable item is moved.</summary>
		[Generated]
		public SortableBuilder OnDragMove(RazorBlock jsFunc)
		{
			return OnDragMove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when drag gesture is initialized.</summary>
		[Generated]
		public SortableBuilder OnDragStart(string jsFunc)
		{
			AssignJS("onDragStart", jsFunc);
			return this;
		}

		/// <summary>A function that is called when drag gesture is initialized.</summary>
		[Generated]
		public SortableBuilder OnDragStart(RazorBlock jsFunc)
		{
			return OnDragStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SortableBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SortableBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SortableBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SortableBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when a draggable item is removed.</summary>
		[Generated]
		public SortableBuilder OnRemove(string jsFunc)
		{
			AssignJS("onRemove", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a draggable item is removed.</summary>
		[Generated]
		public SortableBuilder OnRemove(RazorBlock jsFunc)
		{
			return OnRemove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the draggable items are reordered.</summary>
		[Generated]
		public SortableBuilder OnReorder(string jsFunc)
		{
			AssignJS("onReorder", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the draggable items are reordered.</summary>
		[Generated]
		public SortableBuilder OnReorder(RazorBlock jsFunc)
		{
			return OnReorder(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SortableBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SortableBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public SortableBuilder ScrollSensitivity(double value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public SortableBuilder ScrollSensitivity(JS value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an item beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public SortableBuilder ScrollSpeed(double value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an item beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public SortableBuilder ScrollSpeed(JS value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SortableBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SortableBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SortableBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
