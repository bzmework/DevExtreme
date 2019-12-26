using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the label that belongs to the vertical crosshair line.</summary>
	public class ChartCrosshairVerticalLineLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Paints the background of the label that belongs to the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Paints the background of the label that belongs to the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed by the label that belongs to the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by the label that belongs to the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the label of the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the point argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Makes the label of the vertical crosshair line visible. Applies only if the crosshair feature is enabled and the vertical line is visible.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the label of the vertical crosshair line visible. Applies only if the crosshair feature is enabled and the vertical line is visible.</summary>
		[Generated]
		public ChartCrosshairVerticalLineLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
