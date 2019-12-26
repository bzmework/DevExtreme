using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for argument axis strips.</summary>
	public class PolarChartArgumentAxisStripBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PolarChartArgumentAxisStripBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>An object that defines the label configuration options of a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder Label(Action<PolarChartArgumentAxisStripsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
