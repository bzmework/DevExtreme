using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the labels displayed at the min and max values.</summary>
	public class SliderLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SliderLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SliderLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public SliderLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public SliderLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public SliderLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a label.</summary>
		[Generated]
		public SliderLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies whether labels are over or under the scale.</summary>
		[Generated]
		public SliderLabelBuilder Position(VerticalEdge value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies whether slider labels are visible.</summary>
		[Generated]
		public SliderLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether slider labels are visible.</summary>
		[Generated]
		public SliderLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
