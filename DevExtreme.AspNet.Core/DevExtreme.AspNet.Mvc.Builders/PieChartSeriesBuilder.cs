using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for the series of the PieChart widget.</summary>
	public class PieChartSeriesBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public PieChartSeriesBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PieChartSeriesBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for series points.</summary>
		[Generated]
		public PieChartSeriesBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the required type for series arguments.</summary>
		[Generated]
		public PieChartSeriesBuilder ArgumentType(ChartDataType value)
		{
			base.Options["argumentType"] = value;
			return this;
		}

		/// <summary>An object defining the series border configuration options.</summary>
		[Generated]
		public PieChartSeriesBuilder Border(Action<PieChartSeriesBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PieChartSeriesBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a series color.</summary>
		[Generated]
		public PieChartSeriesBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the chart elements to highlight when a series is hovered over.</summary>
		[Generated]
		public PieChartSeriesBuilder HoverMode(PieChartSeriesInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered series.</summary>
		[Generated]
		public PieChartSeriesBuilder HoverStyle(Action<PieChartSeriesHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>An object defining the label configuration options.</summary>
		[Generated]
		public PieChartSeriesBuilder Label(Action<PieChartSeriesLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PieChartSeriesBuilder MaxLabelCount(int value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies how many points are acceptable to be in a series to display all labels for these points. Otherwise, the labels will not be displayed.</summary>
		[Generated]
		public PieChartSeriesBuilder MaxLabelCount(JS value)
		{
			base.Options["maxLabelCount"] = value;
			return this;
		}

		/// <summary>Specifies a minimal size of a displayed pie segment.</summary>
		[Generated]
		public PieChartSeriesBuilder MinSegmentSize(double value)
		{
			base.Options["minSegmentSize"] = value;
			return this;
		}

		/// <summary>Specifies a minimal size of a displayed pie segment.</summary>
		[Generated]
		public PieChartSeriesBuilder MinSegmentSize(JS value)
		{
			base.Options["minSegmentSize"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public PieChartSeriesBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the name that identifies the series.</summary>
		[Generated]
		public PieChartSeriesBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the chart elements to highlight when the series is selected.</summary>
		[Generated]
		public PieChartSeriesBuilder SelectionMode(PieChartSeriesInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for the series when it is selected.</summary>
		[Generated]
		public PieChartSeriesBuilder SelectionStyle(Action<PieChartSeriesSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies chart segment grouping options.</summary>
		[Generated]
		public PieChartSeriesBuilder SmallValuesGrouping(Action<PieChartSeriesSmallValuesGroupingBuilder> configurator)
		{
			NestedOptions("smallValuesGrouping", configurator);
			return this;
		}

		/// <summary>Specifies data about a series.</summary>
		[Generated]
		public PieChartSeriesBuilder Tag(object value)
		{
			base.Options["tag"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PieChartSeriesBuilder TagField(string value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides data about a point.</summary>
		[Generated]
		public PieChartSeriesBuilder TagField(JS value)
		{
			base.Options["tagField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PieChartSeriesBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for series points.</summary>
		[Generated]
		public PieChartSeriesBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}
	}
}
