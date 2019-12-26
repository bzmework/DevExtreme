using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for the series when it is selected.</summary>
	public class PieChartCommonSeriesSettingsSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder Border(Action<PieChartCommonSeriesSettingsSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a point is selected.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsSelectionStyleBuilder Hatching(Action<PieChartCommonSeriesSettingsSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
