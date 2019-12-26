using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures point labels.</summary>
	public class ChartSeriesLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns point labels in relation to their points.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ArgumentFormat(Format value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ArgumentFormat(string value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ArgumentFormat(JS value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ArgumentFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("argumentFormat", configurator);
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public ChartSeriesLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public ChartSeriesLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the borders of point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Border(Action<ChartSeriesLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Configures the label connectors.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Connector(Action<ChartSeriesLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Customizes the text displayed by point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Along with verticalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartSeriesLabelBuilder HorizontalOffset(double value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Along with verticalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartSeriesLabelBuilder HorizontalOffset(JS value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Specifies whether to display point labels inside or outside of series points. Applies only to bubble, range-like and bar-like series.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Rotates point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Rotates point labels.</summary>
		[Generated]
		public ChartSeriesLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show labels for points with zero value. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ShowForZeroValues(bool value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show labels for points with zero value. Applies only to bar-like series.</summary>
		[Generated]
		public ChartSeriesLabelBuilder ShowForZeroValues(JS value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Along with horizontalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartSeriesLabelBuilder VerticalOffset(double value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Along with horizontalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartSeriesLabelBuilder VerticalOffset(JS value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Makes the point labels visible.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the point labels visible.</summary>
		[Generated]
		public ChartSeriesLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
