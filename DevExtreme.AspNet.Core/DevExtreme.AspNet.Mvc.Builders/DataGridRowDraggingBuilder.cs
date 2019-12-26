using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures row reordering using drag and drop gestures.</summary>
	public class DataGridRowDraggingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridRowDraggingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Allows dropping a row inside another row.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AllowDropInsideItem(bool value)
		{
			base.Options["allowDropInsideItem"] = value;
			return this;
		}

		/// <summary>Allows dropping a row inside another row.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AllowDropInsideItem(JS value)
		{
			base.Options["allowDropInsideItem"] = value;
			return this;
		}

		/// <summary>Allows row reordering using drag and drop gestures.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AllowReordering(bool value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Allows row reordering using drag and drop gestures.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AllowReordering(JS value)
		{
			base.Options["allowReordering"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging a row beyond the viewport.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AutoScroll(bool value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging a row beyond the viewport.</summary>
		[Generated]
		public DataGridRowDraggingBuilder AutoScroll(JS value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Boundary(string value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Specifies a DOM element that limits the dragging area.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Boundary(JS value)
		{
			base.Options["boundary"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable row should be rendered.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom container in which the draggable row should be rendered.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged row.</summary>
		[Generated]
		public DataGridRowDraggingBuilder CursorOffset(Action<DataGridRowDraggingCursorOffsetBuilder> configurator)
		{
			NestedOptions("cursorOffset", configurator);
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged row.</summary>
		[Generated]
		public DataGridRowDraggingBuilder CursorOffset(string value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>Specifies the cursor offset from the dragged row.</summary>
		[Generated]
		public DataGridRowDraggingBuilder CursorOffset(JS value)
		{
			base.Options["cursorOffset"] = value;
			return this;
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Specifies the directions in which a row can be dragged.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DragDirection(DragDirection value)
		{
			base.Options["dragDirection"] = value;
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DragTemplate(string templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DragTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dragTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DragTemplate(TemplateName name)
		{
			AssignTemplate("dragTemplate", name);
			return this;
		}

		/// <summary>Specifies custom markup to be shown instead of the item being dragged.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DragTemplate(JS value)
		{
			base.Options["dragTemplate"] = value;
			return this;
		}

		/// <summary>Specifies how to highlight the row's drop position.</summary>
		[Generated]
		public DataGridRowDraggingBuilder DropFeedbackMode(DropFeedbackMode value)
		{
			base.Options["dropFeedbackMode"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for draggable rows.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Filter(string value)
		{
			base.Options["filter"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector for draggable rows.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Filter(JS value)
		{
			base.Options["filter"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets so that users can drag and drop rows between them.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Group(string value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets so that users can drag and drop rows between them.</summary>
		[Generated]
		public DataGridRowDraggingBuilder Group(JS value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) for the element(s) that should act as the drag handle(s).</summary>
		[Generated]
		public DataGridRowDraggingBuilder Handle(string value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>Specifies a CSS selector (ID or class) for the element(s) that should act as the drag handle(s).</summary>
		[Generated]
		public DataGridRowDraggingBuilder Handle(JS value)
		{
			base.Options["handle"] = value;
			return this;
		}

		/// <summary>A function that is called when a new row is added.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnAdd(string jsFunc)
		{
			AssignJS("onAdd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a new row is added.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnAdd(RazorBlock jsFunc)
		{
			return OnAdd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the dragged row's position is changed.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragChange(string jsFunc)
		{
			AssignJS("onDragChange", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the dragged row's position is changed.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragChange(RazorBlock jsFunc)
		{
			return OnDragChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the drag gesture is finished.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragEnd(string jsFunc)
		{
			AssignJS("onDragEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the drag gesture is finished.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragEnd(RazorBlock jsFunc)
		{
			return OnDragEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called every time a draggable row is moved.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragMove(string jsFunc)
		{
			AssignJS("onDragMove", jsFunc);
			return this;
		}

		/// <summary>A function that is called every time a draggable row is moved.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragMove(RazorBlock jsFunc)
		{
			return OnDragMove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragStart(string jsFunc)
		{
			AssignJS("onDragStart", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnDragStart(RazorBlock jsFunc)
		{
			return OnDragStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when a draggable row is removed.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnRemove(string jsFunc)
		{
			AssignJS("onRemove", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a draggable row is removed.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnRemove(RazorBlock jsFunc)
		{
			return OnRemove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the draggable rows are reordered.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnReorder(string jsFunc)
		{
			AssignJS("onReorder", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the draggable rows are reordered.</summary>
		[Generated]
		public DataGridRowDraggingBuilder OnReorder(RazorBlock jsFunc)
		{
			return OnReorder(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ScrollSensitivity(double value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ScrollSensitivity(JS value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging a row beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ScrollSpeed(double value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging a row beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ScrollSpeed(JS value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Shows or hides row dragging icons.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ShowDragIcons(bool value)
		{
			base.Options["showDragIcons"] = value;
			return this;
		}

		/// <summary>Shows or hides row dragging icons.</summary>
		[Generated]
		public DataGridRowDraggingBuilder ShowDragIcons(JS value)
		{
			base.Options["showDragIcons"] = value;
			return this;
		}
	}
}
