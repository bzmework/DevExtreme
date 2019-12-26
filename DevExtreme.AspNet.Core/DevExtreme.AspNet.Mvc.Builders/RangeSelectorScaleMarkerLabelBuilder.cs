using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines the options that can be set for the text that is displayed by the scale markers.</summary>
	public class RangeSelectorScaleMarkerLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale markers.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale markers.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Formats a value before it is displayed in a scale marker.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale marker.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale marker.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale marker.</summary>
		[Generated]
		public RangeSelectorScaleMarkerLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}
	}
}
