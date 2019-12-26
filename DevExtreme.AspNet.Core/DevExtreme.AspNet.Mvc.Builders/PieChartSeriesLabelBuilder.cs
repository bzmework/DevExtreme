using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the label configuration options.</summary>
	public class PieChartSeriesLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder ArgumentFormat(Format value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder ArgumentFormat(string value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder ArgumentFormat(JS value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder ArgumentFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("argumentFormat", configurator);
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies border options for point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Border(Action<PieChartSeriesLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies connector options for series point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Connector(Action<PieChartSeriesLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed in point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies a label position relative to the chart.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Position(PieChartLabelPosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies how to shift labels from their initial position in a radial direction in pixels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder RadialOffset(double value)
		{
			base.Options["radialOffset"] = value;
			return this;
		}

		/// <summary>Specifies how to shift labels from their initial position in a radial direction in pixels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder RadialOffset(JS value)
		{
			base.Options["radialOffset"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies what to do with label texts that overflow the allocated space after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap label texts if they do not fit into a single line.</summary>
		[Generated]
		public PieChartSeriesLabelBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
