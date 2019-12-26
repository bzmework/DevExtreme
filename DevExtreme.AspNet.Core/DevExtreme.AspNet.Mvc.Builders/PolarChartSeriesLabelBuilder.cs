using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the label configuration options.</summary>
	public class PolarChartSeriesLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ArgumentFormat(Format value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ArgumentFormat(string value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ArgumentFormat(JS value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ArgumentFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("argumentFormat", configurator);
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies border options for point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Border(Action<PolarChartSeriesLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies connector options for series point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Connector(Action<PolarChartSeriesLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed in point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies a label position in bar-like series.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a label when the point has a zero value.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ShowForZeroValues(bool value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a label when the point has a zero value.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder ShowForZeroValues(JS value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
