using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for value axis strips.</summary>
	public class PolarChartValueAxisStripBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PolarChartValueAxisStripBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>An object that defines the label configuration options of a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder Label(Action<PolarChartValueAxisStripsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
