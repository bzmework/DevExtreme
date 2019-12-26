using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options for the range selector's background.</summary>
	public class RangeSelectorBackgroundBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorBackgroundBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the background color for the RangeSelector.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the background color for the RangeSelector.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies image options.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Image(Action<RangeSelectorBackgroundImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>Indicates whether or not the background (background color and/or image) is visible.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the background (background color and/or image) is visible.</summary>
		[Generated]
		public RangeSelectorBackgroundBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
