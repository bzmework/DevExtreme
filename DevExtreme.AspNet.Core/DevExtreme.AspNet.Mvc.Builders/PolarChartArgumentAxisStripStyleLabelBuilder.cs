using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for a strip label style.</summary>
	public class PolarChartArgumentAxisStripStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisStripStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisStripStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a strip label.</summary>
		[Generated]
		public PolarChartArgumentAxisStripStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}
	}
}
