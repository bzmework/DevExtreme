using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies common options for scale labels.</summary>
	public class CircularGaugeScaleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeScaleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale labels.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale labels.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed in the scale labels of the gauge.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label. Accepts only numeric formats.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label. Accepts only numeric formats.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label. Accepts only numeric formats.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label. Accepts only numeric formats.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies which label to hide in case of overlapping.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder HideFirstOrLast(GaugeOverlappingBehavior value)
		{
			base.Options["hideFirstOrLast"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between scale labels and ticks.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder IndentFromTick(double value)
		{
			base.Options["indentFromTick"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between scale labels and ticks.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder IndentFromTick(JS value)
		{
			base.Options["indentFromTick"] = value;
			return this;
		}

		/// <summary>Decides how to arrange scale labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder OverlappingBehavior(ScaleLabelOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Specifies whether or not scale labels should be colored similarly to their corresponding ranges in the range container.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder UseRangeColors(bool value)
		{
			base.Options["useRangeColors"] = value;
			return this;
		}

		/// <summary>Specifies whether or not scale labels should be colored similarly to their corresponding ranges in the range container.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder UseRangeColors(JS value)
		{
			base.Options["useRangeColors"] = value;
			return this;
		}

		/// <summary>Specifies whether or not scale labels are visible on the gauge.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not scale labels are visible on the gauge.</summary>
		[Generated]
		public CircularGaugeScaleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
