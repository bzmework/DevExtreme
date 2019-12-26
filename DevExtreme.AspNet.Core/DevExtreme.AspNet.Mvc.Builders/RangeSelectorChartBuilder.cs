using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options required to display a chart as the range selector's background.</summary>
	public class RangeSelectorChartBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorChartBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorChartBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public RangeSelectorChartBuilder BarGroupPadding(double value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public RangeSelectorChartBuilder BarGroupPadding(JS value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for groups of bars with the same argument, measured in pixels. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public RangeSelectorChartBuilder BarGroupWidth(double value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for groups of bars with the same argument, measured in pixels. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public RangeSelectorChartBuilder BarGroupWidth(JS value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies an indent from the background's bottom to the lowest chart point. Accepts values from 0 to 1.</summary>
		[Generated]
		public RangeSelectorChartBuilder BottomIndent(double value)
		{
			base.Options["bottomIndent"] = value;
			return this;
		}

		/// <summary>Specifies an indent from the background's bottom to the lowest chart point. Accepts values from 0 to 1.</summary>
		[Generated]
		public RangeSelectorChartBuilder BottomIndent(JS value)
		{
			base.Options["bottomIndent"] = value;
			return this;
		}

		/// <summary>An object defining the common configuration options for the chart’s series.</summary>
		[Generated]
		public RangeSelectorChartBuilder CommonSeriesSettings(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("commonSeriesSettings", configurator);
			return this;
		}

		/// <summary>An object providing options for managing data from a data source.</summary>
		[Generated]
		public RangeSelectorChartBuilder DataPrepareSettings(Action<RangeSelectorChartDataPrepareSettingsBuilder> configurator)
		{
			NestedOptions("dataPrepareSettings", configurator);
			return this;
		}

		[Obsolete("Use CommonSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder EqualBarWidth(bool value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder EqualBarWidth(JS value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the diameter of the largest bubble.</summary>
		[Generated]
		public RangeSelectorChartBuilder MaxBubbleSize(double value)
		{
			base.Options["maxBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient that determines the diameter of the largest bubble.</summary>
		[Generated]
		public RangeSelectorChartBuilder MaxBubbleSize(JS value)
		{
			base.Options["maxBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of the smallest bubble measured in pixels.</summary>
		[Generated]
		public RangeSelectorChartBuilder MinBubbleSize(double value)
		{
			base.Options["minBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of the smallest bubble measured in pixels.</summary>
		[Generated]
		public RangeSelectorChartBuilder MinBubbleSize(JS value)
		{
			base.Options["minBubbleSize"] = value;
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public RangeSelectorChartBuilder NegativesAsZeroes(bool value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public RangeSelectorChartBuilder NegativesAsZeroes(JS value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize series in the chart.</summary>
		[Generated]
		public RangeSelectorChartBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize series in the chart.</summary>
		[Generated]
		public RangeSelectorChartBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize series in the chart.</summary>
		[Generated]
		public RangeSelectorChartBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of series in the chart.</summary>
		[Generated]
		public RangeSelectorChartBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>An object defining the chart’s series.</summary>
		[Generated]
		public RangeSelectorChartBuilder Series(Action<CollectionFactory<ChartSeriesBuilder>> configurator)
		{
			Collection("series", configurator);
			return this;
		}

		/// <summary>Defines options for the series template.</summary>
		[Generated]
		public RangeSelectorChartBuilder SeriesTemplate(Action<RangeSelectorChartSeriesTemplateBuilder> configurator)
		{
			NestedOptions("seriesTemplate", configurator);
			return this;
		}

		/// <summary>Specifies an indent from the background's top to the topmost chart point. Accepts values from 0 to 1.</summary>
		[Generated]
		public RangeSelectorChartBuilder TopIndent(double value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		/// <summary>Specifies an indent from the background's top to the topmost chart point. Accepts values from 0 to 1.</summary>
		[Generated]
		public RangeSelectorChartBuilder TopIndent(JS value)
		{
			base.Options["topIndent"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.aggregation.enabled instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder UseAggregation(bool value)
		{
			base.Options["useAggregation"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.aggregation.enabled instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public RangeSelectorChartBuilder UseAggregation(JS value)
		{
			base.Options["useAggregation"] = value;
			return this;
		}

		/// <summary>Configures the chart value axis.</summary>
		[Generated]
		public RangeSelectorChartBuilder ValueAxis(Action<RangeSelectorChartValueAxisBuilder> configurator)
		{
			NestedOptions("valueAxis", configurator);
			return this;
		}
	}
}
