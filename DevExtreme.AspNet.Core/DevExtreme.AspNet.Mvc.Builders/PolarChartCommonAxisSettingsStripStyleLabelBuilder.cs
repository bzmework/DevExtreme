using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for a strip label style.</summary>
	public class PolarChartCommonAxisSettingsStripStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a strip label.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}
	}
}
