using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the label that belongs to the horizontal crosshair line.</summary>
	public class ChartCrosshairHorizontalLineLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Paints the background of the label that belongs to the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Paints the background of the label that belongs to the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed by the label that belongs to the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by the label that belongs to the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the label of the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a point value before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Makes the label of the horizontal crosshair line visible. Applies only if the crosshair feature is enabled and the horizontal line is visible.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the label of the horizontal crosshair line visible. Applies only if the crosshair feature is enabled and the horizontal line is visible.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
