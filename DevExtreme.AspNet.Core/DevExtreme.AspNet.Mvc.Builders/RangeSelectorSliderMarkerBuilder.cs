using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines the options of the range selector slider markers.</summary>
	public class RangeSelectorSliderMarkerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorSliderMarkerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the slider markers.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the slider markers.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by slider markers.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by slider markers.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed by the range selector slider markers.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the color used for the slider marker text when the currently selected range does not match the minRange and maxRange values.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder InvalidRangeColor(string value)
		{
			base.Options["invalidRangeColor"] = value;
			return this;
		}

		/// <summary>Specifies the color used for the slider marker text when the currently selected range does not match the minRange and maxRange values.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder InvalidRangeColor(JS value)
		{
			base.Options["invalidRangeColor"] = value;
			return this;
		}

		/// <summary>Specifies the empty space between the marker's left and right borders and the marker's text.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Specifies the empty space between the marker's left and right borders and the marker's text.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Specifies the empty space between the marker's top and bottom borders and the marker's text.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the empty space between the marker's top and bottom borders and the marker's text.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder height of the slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PlaceholderHeight(double value)
		{
			base.Options["placeholderHeight"] = value;
			return this;
		}

		/// <summary>Specifies the placeholder height of the slider marker.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder PlaceholderHeight(JS value)
		{
			base.Options["placeholderHeight"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the slider markers are visible.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the slider markers are visible.</summary>
		[Generated]
		public RangeSelectorSliderMarkerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
