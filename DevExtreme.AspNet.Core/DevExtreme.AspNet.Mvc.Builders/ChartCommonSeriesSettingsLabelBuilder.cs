using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures point labels.</summary>
	public class ChartCommonSeriesSettingsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns point labels in relation to their points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ArgumentFormat(Format value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ArgumentFormat(string value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ArgumentFormat(JS value)
		{
			base.Options["argumentFormat"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the point label. To format the point value, use the format option.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ArgumentFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("argumentFormat", configurator);
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the point labels' background. The default color is inherited from the points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the borders of point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Border(Action<ChartCommonSeriesSettingsLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Configures the label connectors.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Connector(Action<ChartCommonSeriesSettingsLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Customizes the text displayed by point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point value before it will be displayed in the point label.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Along with verticalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder HorizontalOffset(double value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Along with verticalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder HorizontalOffset(JS value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Specifies whether to display point labels inside or outside of series points. Applies only to bubble, range-like and bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Rotates point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Rotates point labels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show labels for points with zero value. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ShowForZeroValues(bool value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show labels for points with zero value. Applies only to bar-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder ShowForZeroValues(JS value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Along with horizontalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder VerticalOffset(double value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Along with horizontalOffset, shifts point labels from their initial positions.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder VerticalOffset(JS value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Makes the point labels visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the point labels visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
