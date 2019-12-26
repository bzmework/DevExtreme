using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for strip style.</summary>
	public class PolarChartValueAxisStripStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisStripStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisStripStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for a strip label style.</summary>
		[Generated]
		public PolarChartValueAxisStripStyleBuilder Label(Action<PolarChartValueAxisStripStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}
	}
}
