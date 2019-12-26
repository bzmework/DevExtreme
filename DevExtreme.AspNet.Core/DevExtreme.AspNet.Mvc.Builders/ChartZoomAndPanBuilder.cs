using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures zooming and panning.</summary>
	public class ChartZoomAndPanBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartZoomAndPanBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartZoomAndPanBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether users can use the mouse wheel to zoom the chart. Applies only if zoom is allowed for the argument or value axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder AllowMouseWheel(bool value)
		{
			base.Options["allowMouseWheel"] = value;
			return this;
		}

		/// <summary>Specifies whether users can use the mouse wheel to zoom the chart. Applies only if zoom is allowed for the argument or value axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder AllowMouseWheel(JS value)
		{
			base.Options["allowMouseWheel"] = value;
			return this;
		}

		/// <summary>Specifies whether users can use touch gestures to zoom or pan the chart. Applies only if zoom and pan are allowed for the argument or value axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder AllowTouchGestures(bool value)
		{
			base.Options["allowTouchGestures"] = value;
			return this;
		}

		/// <summary>Specifies whether users can use touch gestures to zoom or pan the chart. Applies only if zoom and pan are allowed for the argument or value axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder AllowTouchGestures(JS value)
		{
			base.Options["allowTouchGestures"] = value;
			return this;
		}

		/// <summary>Specifies whether users are allowed to zoom and/or pan the argument axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder ArgumentAxis(ChartZoomAndPanMode value)
		{
			base.Options["argumentAxis"] = value;
			return this;
		}

		/// <summary>Configures the box that appears when users zoom the chart by selecting an area with the drag gesture. Applies only if dragToZoom is true.</summary>
		[Generated]
		public ChartZoomAndPanBuilder DragBoxStyle(Action<ChartZoomAndPanDragBoxStyleBuilder> configurator)
		{
			NestedOptions("dragBoxStyle", configurator);
			return this;
		}

		/// <summary>Enables users to zoom the chart by selecting an area with the drag gesture. Applies only on devices that use a mouse.</summary>
		[Generated]
		public ChartZoomAndPanBuilder DragToZoom(bool value)
		{
			base.Options["dragToZoom"] = value;
			return this;
		}

		/// <summary>Enables users to zoom the chart by selecting an area with the drag gesture. Applies only on devices that use a mouse.</summary>
		[Generated]
		public ChartZoomAndPanBuilder DragToZoom(JS value)
		{
			base.Options["dragToZoom"] = value;
			return this;
		}

		/// <summary>Specifies the key that enables panning when dragToZoom is true. Applies only on devices that use a mouse.</summary>
		[Generated]
		public ChartZoomAndPanBuilder PanKey(EventKeyModifier value)
		{
			base.Options["panKey"] = value;
			return this;
		}

		/// <summary>Specifies whether users are allowed to zoom and/or pan the value axis.</summary>
		[Generated]
		public ChartZoomAndPanBuilder ValueAxis(ChartZoomAndPanMode value)
		{
			base.Options["valueAxis"] = value;
			return this;
		}
	}
}
