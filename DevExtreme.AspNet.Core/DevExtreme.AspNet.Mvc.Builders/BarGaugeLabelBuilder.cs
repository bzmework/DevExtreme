using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the labels that accompany gauge bars.</summary>
	public class BarGaugeLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the label connector text.</summary>
		[Generated]
		public BarGaugeLabelBuilder ConnectorColor(string value)
		{
			base.Options["connectorColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the label connector text.</summary>
		[Generated]
		public BarGaugeLabelBuilder ConnectorColor(JS value)
		{
			base.Options["connectorColor"] = value;
			return this;
		}

		/// <summary>Specifies the width of the label connector in pixels.</summary>
		[Generated]
		public BarGaugeLabelBuilder ConnectorWidth(double value)
		{
			base.Options["connectorWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the label connector in pixels.</summary>
		[Generated]
		public BarGaugeLabelBuilder ConnectorWidth(JS value)
		{
			base.Options["connectorWidth"] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns a text for labels.</summary>
		[Generated]
		public BarGaugeLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns a text for labels.</summary>
		[Generated]
		public BarGaugeLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for bar labels.</summary>
		[Generated]
		public BarGaugeLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label. Accepts only numeric formats.</summary>
		[Generated]
		public BarGaugeLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label. Accepts only numeric formats.</summary>
		[Generated]
		public BarGaugeLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label. Accepts only numeric formats.</summary>
		[Generated]
		public BarGaugeLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label. Accepts only numeric formats.</summary>
		[Generated]
		public BarGaugeLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the distance between the upper bar and bar labels in pixels.</summary>
		[Generated]
		public BarGaugeLabelBuilder Indent(double value)
		{
			base.Options["indent"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the upper bar and bar labels in pixels.</summary>
		[Generated]
		public BarGaugeLabelBuilder Indent(JS value)
		{
			base.Options["indent"] = value;
			return this;
		}

		/// <summary>Specifies whether bar labels appear on a gauge or not.</summary>
		[Generated]
		public BarGaugeLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether bar labels appear on a gauge or not.</summary>
		[Generated]
		public BarGaugeLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
