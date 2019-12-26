using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for a strip label style.</summary>
	public class PolarChartValueAxisStripStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisStripStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisStripStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a strip label.</summary>
		[Generated]
		public PolarChartValueAxisStripStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}
	}
}
