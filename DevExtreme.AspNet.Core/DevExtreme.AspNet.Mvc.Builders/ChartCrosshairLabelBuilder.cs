using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the crosshair labels.</summary>
	public class ChartCrosshairLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Paints the background of the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Paints the background of the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Customizes the text displayed by the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a point value/argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value/argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value/argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a point value/argument before it is displayed in the crosshair label.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Makes the crosshair labels visible. Applies only if the crosshair feature is enabled.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the crosshair labels visible. Applies only if the crosshair feature is enabled.</summary>
		[Generated]
		public ChartCrosshairLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
