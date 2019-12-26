using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Declares a collection of strips belonging to the value axis.</summary>
	public class ChartValueAxisStripBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartValueAxisStripBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisStripBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Configures the strip label.</summary>
		[Generated]
		public ChartValueAxisStripBuilder Label(Action<ChartValueAxisStripsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartValueAxisStripBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
