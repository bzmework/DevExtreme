using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a hovered series.</summary>
	public class PieChartCommonSeriesSettingsHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a hovered series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder Border(Action<PieChartCommonSeriesSettingsHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a point is hovered over.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsHoverStyleBuilder Hatching(Action<PieChartCommonSeriesSettingsHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
