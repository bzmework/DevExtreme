using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the label configuration options.</summary>
	public class PolarChartCommonSeriesSettingsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ArgumentFormat(Format value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ArgumentFormat(string value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ArgumentFormat(JS value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ArgumentFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("argumentFormat", configurator);
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies border options for point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Border(Action<PolarChartCommonSeriesSettingsLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies connector options for series point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Connector(Action<PolarChartCommonSeriesSettingsLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed in point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a point label.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies a label position in bar-like series.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies the angle used to rotate point labels from their initial position.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a label when the point has a zero value.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ShowForZeroValues(bool value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a label when the point has a zero value.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder ShowForZeroValues(JS value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of point labels.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
