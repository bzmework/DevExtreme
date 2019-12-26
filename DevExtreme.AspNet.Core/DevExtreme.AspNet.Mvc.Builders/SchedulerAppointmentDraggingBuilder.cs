namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures appointment reordering using drag and drop gestures.</summary>
	public class SchedulerAppointmentDraggingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SchedulerAppointmentDraggingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an appointment beyond the viewport.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder AutoScroll(bool value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>Enables automatic scrolling while dragging an appointment beyond the viewport.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder AutoScroll(JS value)
		{
			base.Options["autoScroll"] = value;
			return this;
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets so that users can drag and drop appointments between them.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder Group(string value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>Allows you to group several widgets so that users can drag and drop appointments between them.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder Group(JS value)
		{
			base.Options["group"] = value;
			return this;
		}

		/// <summary>A function that is called when a new appointment is added.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnAdd(string jsFunc)
		{
			AssignJS("onAdd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a new appointment is added.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnAdd(RazorBlock jsFunc)
		{
			return OnAdd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the dragged appointment's position is changed.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragEnd(string jsFunc)
		{
			AssignJS("onDragEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the dragged appointment's position is changed.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragEnd(RazorBlock jsFunc)
		{
			return OnDragEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called every time a draggable appointment is moved.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragMove(string jsFunc)
		{
			AssignJS("onDragMove", jsFunc);
			return this;
		}

		/// <summary>A function that is called every time a draggable appointment is moved.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragMove(RazorBlock jsFunc)
		{
			return OnDragMove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragStart(string jsFunc)
		{
			AssignJS("onDragStart", jsFunc);
			return this;
		}

		/// <summary>A function that is called when the drag gesture is initialized.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnDragStart(RazorBlock jsFunc)
		{
			return OnDragStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is called when a draggable appointment is removed.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnRemove(string jsFunc)
		{
			AssignJS("onRemove", jsFunc);
			return this;
		}

		/// <summary>A function that is called when a draggable appointment is removed.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder OnRemove(RazorBlock jsFunc)
		{
			return OnRemove(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder ScrollSensitivity(double value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels from the edge of viewport at which scrolling should start. Applies only if autoScroll is true.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder ScrollSensitivity(JS value)
		{
			base.Options["scrollSensitivity"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an appointment beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder ScrollSpeed(double value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}

		/// <summary>Specifies the scrolling speed when dragging an appointment beyond the viewport. Applies only if autoScroll is true.</summary>
		[Generated]
		public SchedulerAppointmentDraggingBuilder ScrollSpeed(JS value)
		{
			base.Options["scrollSpeed"] = value;
			return this;
		}
	}
}
