using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class VizRangeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VizRangeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VizRangeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The range's end value.</summary>
		[Generated]
		public VizRangeBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>The range's end value.</summary>
		[Generated]
		public VizRangeBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>The range's end value.</summary>
		[Generated]
		public VizRangeBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>The range's end value.</summary>
		[Generated]
		public VizRangeBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>The range's length.</summary>
		[Generated]
		public VizRangeBuilder Length(Action<VizRangeLengthBuilder> configurator)
		{
			NestedOptions("length", configurator);
			return this;
		}

		/// <summary>The range's length.</summary>
		[Generated]
		public VizRangeBuilder Length(VizTimeInterval value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>The range's length.</summary>
		[Generated]
		public VizRangeBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>The range's length.</summary>
		[Generated]
		public VizRangeBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>The range's start value.</summary>
		[Generated]
		public VizRangeBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>The range's start value.</summary>
		[Generated]
		public VizRangeBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>The range's start value.</summary>
		[Generated]
		public VizRangeBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>The range's start value.</summary>
		[Generated]
		public VizRangeBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
