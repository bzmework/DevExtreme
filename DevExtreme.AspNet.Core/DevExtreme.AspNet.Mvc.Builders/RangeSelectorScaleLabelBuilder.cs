using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies common options for scale labels.</summary>
	public class RangeSelectorScaleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale labels.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in scale labels.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for the text displayed in the range selector's scale labels.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in a scale label.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Decides how to arrange scale labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder OverlappingBehavior(ScaleLabelOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Specifies a spacing between scale labels and the background bottom edge.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder TopIndent(double value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		/// <summary>Specifies a spacing between scale labels and the background bottom edge.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder TopIndent(JS value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the scale's labels are visible.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the scale's labels are visible.</summary>
		[Generated]
		public RangeSelectorScaleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
