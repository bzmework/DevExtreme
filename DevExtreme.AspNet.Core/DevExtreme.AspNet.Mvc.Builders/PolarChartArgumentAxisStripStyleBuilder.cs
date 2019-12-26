using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for strip style.</summary>
	public class PolarChartArgumentAxisStripStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisStripStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisStripStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for a strip label style.</summary>
		[Generated]
		public PolarChartArgumentAxisStripStyleBuilder Label(Action<PolarChartArgumentAxisStripStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}
	}
}
