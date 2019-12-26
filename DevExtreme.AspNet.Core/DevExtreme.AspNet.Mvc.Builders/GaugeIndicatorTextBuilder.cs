using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of the text displayed in an indicator of the rangeBar type.</summary>
	public class GaugeIndicatorTextBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GaugeIndicatorTextBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in an indicator.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in an indicator.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed by the indicator.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in an indicator. Accepts only numeric formats.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an indicator. Accepts only numeric formats.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an indicator. Accepts only numeric formats.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an indicator. Accepts only numeric formats.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the range bar's label indent in pixels.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Indent(double value)
		{
			base.Options["indent"] = value;
			return this;
		}

		/// <summary>Specifies the range bar's label indent in pixels.</summary>
		[Generated]
		public GaugeIndicatorTextBuilder Indent(JS value)
		{
			base.Options["indent"] = value;
			return this;
		}
	}
}
