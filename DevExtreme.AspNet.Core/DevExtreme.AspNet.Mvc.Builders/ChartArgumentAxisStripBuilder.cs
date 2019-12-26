using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Declares a collection of strips belonging to the argument axis.</summary>
	public class ChartArgumentAxisStripBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartArgumentAxisStripBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Configures the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder Label(Action<ChartArgumentAxisStripsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the strip.</summary>
		[Generated]
		public ChartArgumentAxisStripBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
