using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the labels displayed at the min and max values.</summary>
	public class RangeSliderLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSliderLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSliderLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public RangeSliderLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public RangeSliderLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public RangeSliderLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public RangeSliderLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies whether labels are over or under the scale.</summary>
		[Generated]
		public RangeSliderLabelBuilder Position(VerticalEdge value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies whether slider labels are visible.</summary>
		[Generated]
		public RangeSliderLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether slider labels are visible.</summary>
		[Generated]
		public RangeSliderLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
