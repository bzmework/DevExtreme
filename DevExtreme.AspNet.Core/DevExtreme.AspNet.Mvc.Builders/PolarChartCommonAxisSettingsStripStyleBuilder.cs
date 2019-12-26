using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for strip style.</summary>
	public class PolarChartCommonAxisSettingsStripStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for a strip label style.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsStripStyleBuilder Label(Action<PolarChartCommonAxisSettingsStripStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}
	}
}
