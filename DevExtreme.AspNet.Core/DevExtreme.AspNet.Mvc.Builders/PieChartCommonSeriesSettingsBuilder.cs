using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options that are common for all series of the PieChart widget.</summary>
	public class PieChartCommonSeriesSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the required type for series arguments.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder ArgumentType(ChartDataType value)
		{
			base.Options["argumentType"] = value;
			return this;
		}

		/// <summary>An object defining the series border configuration options.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder Border(Action<PieChartCommonSeriesSettingsBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the chart elements to highlight when a series is hovered over.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder HoverMode(PieChartSeriesInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered series.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder HoverStyle(Action<PieChartCommonSeriesSettingsHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>An object defining the label configuration options.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder Label(Action<PieChartCommonSeriesSettingsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies a minimal size of a displayed pie segment.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder MinSegmentSize(double value)
		{
			base.Options["minSegmentSize"] = value;
			return this;
		}

		/// <summary>Specifies a minimal size of a displayed pie segment.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder MinSegmentSize(JS value)
		{
			base.Options["minSegmentSize"] = value;
			return this;
		}

		/// <summary>Specifies the chart elements to highlight when the series is selected.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder SelectionMode(PieChartSeriesInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for the series when it is selected.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder SelectionStyle(Action<PieChartCommonSeriesSettingsSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies chart segment grouping options.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder SmallValuesGrouping(Action<PieChartCommonSeriesSettingsSmallValuesGroupingBuilder> configurator)
		{
			NestedOptions("smallValuesGrouping", configurator);
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}
	}
}
