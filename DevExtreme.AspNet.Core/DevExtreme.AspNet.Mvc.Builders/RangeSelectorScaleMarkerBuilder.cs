using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for the date-time scale's markers.</summary>
	public class RangeSelectorScaleMarkerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleMarkerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Defines the options that can be set for the text that is displayed by the scale markers.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder Label(Action<RangeSelectorScaleMarkerLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies the height of the marker's separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder SeparatorHeight(double value)
		{
			base.Options["separatorHeight"] = value;
			return this;
		}

		/// <summary>Specifies the height of the marker's separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder SeparatorHeight(JS value)
		{
			base.Options["separatorHeight"] = value;
			return this;
		}

		/// <summary>Specifies the space between the marker label and the marker separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TextLeftIndent(double value)
		{
			base.Options["textLeftIndent"] = value;
			return this;
		}

		/// <summary>Specifies the space between the marker label and the marker separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TextLeftIndent(JS value)
		{
			base.Options["textLeftIndent"] = value;
			return this;
		}

		/// <summary>Specifies the space between the marker's label and the top edge of the marker's separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TextTopIndent(double value)
		{
			base.Options["textTopIndent"] = value;
			return this;
		}

		/// <summary>Specifies the space between the marker's label and the top edge of the marker's separator.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TextTopIndent(JS value)
		{
			base.Options["textTopIndent"] = value;
			return this;
		}

		/// <summary>Specified the indent between the marker and the scale labels.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TopIndent(double value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		/// <summary>Specified the indent between the marker and the scale labels.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder TopIndent(JS value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		/// <summary>Indicates whether scale markers are visible.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale markers are visible.</summary>
		[Generated]
		public RangeSelectorScaleMarkerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
