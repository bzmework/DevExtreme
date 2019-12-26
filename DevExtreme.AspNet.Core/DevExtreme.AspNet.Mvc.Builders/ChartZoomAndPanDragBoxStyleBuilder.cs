namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the box that appears when users zoom the chart by selecting an area with the drag gesture. Applies only if dragToZoom is true.</summary>
	public class ChartZoomAndPanDragBoxStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the drag box's color.</summary>
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the drag box's color.</summary>
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the drag box's transparency.</summary>
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the drag box's transparency.</summary>
		[Generated]
		public ChartZoomAndPanDragBoxStyleBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
