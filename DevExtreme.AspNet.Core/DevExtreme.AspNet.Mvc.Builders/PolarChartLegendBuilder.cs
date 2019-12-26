using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of a chart's legend.</summary>
	public class PolarChartLegendBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartLegendBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartLegendBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public PolarChartLegendBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public PolarChartLegendBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the legend's border.</summary>
		[Generated]
		public PolarChartLegendBuilder Border(Action<PolarChartLegendBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public PolarChartLegendBuilder ColumnCount(int value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public PolarChartLegendBuilder ColumnCount(JS value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder ColumnItemSpacing(double value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder ColumnItemSpacing(JS value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeItems(string jsFunc)
		{
			AssignJS("customizeItems", jsFunc);
			return this;
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeItems(RazorBlock jsFunc)
		{
			return CustomizeItems(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by legend items.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by legend items.</summary>
		[Generated]
		public PolarChartLegendBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the legend items' font options.</summary>
		[Generated]
		public PolarChartLegendBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend's position.</summary>
		[Generated]
		public PolarChartLegendBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies what series elements to highlight when a corresponding item in the legend is hovered over.</summary>
		[Generated]
		public PolarChartLegendBuilder HoverMode(ChartLegendHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Aligns items in the last column or row (depending on the legend's orientation). Applies when legend items are not divided into columns or rows equally.</summary>
		[Generated]
		public PolarChartLegendBuilder ItemsAlignment(HorizontalAlignment value)
		{
			base.Options["itemsAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text's position relative to the marker in a legend item.</summary>
		[Generated]
		public PolarChartLegendBuilder ItemTextPosition(Position value)
		{
			base.Options["itemTextPosition"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public PolarChartLegendBuilder Margin(Action<PolarChartLegendMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public PolarChartLegendBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public PolarChartLegendBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerSize(double value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerSize(JS value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerTemplate(string templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerTemplate(RazorBlock templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerTemplate(TemplateName name)
		{
			AssignTemplate("markerTemplate", name);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public PolarChartLegendBuilder MarkerTemplate(JS value)
		{
			base.Options["markerTemplate"] = value;
			return this;
		}

		/// <summary>Arranges legend items vertically (in a column) or horizontally (in a row). The default value is "horizontal" if the legend.horizontalAlignment is "center". Otherwise, it is "vertical".</summary>
		[Generated]
		public PolarChartLegendBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public PolarChartLegendBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public PolarChartLegendBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public PolarChartLegendBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public PolarChartLegendBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public PolarChartLegendBuilder RowCount(int value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public PolarChartLegendBuilder RowCount(JS value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder RowItemSpacing(double value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public PolarChartLegendBuilder RowItemSpacing(JS value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public PolarChartLegendBuilder Title(Action<PolarChartLegendTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public PolarChartLegendBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public PolarChartLegendBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Along with horizontalAlignment, specifies the legend's position.</summary>
		[Generated]
		public PolarChartLegendBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public PolarChartLegendBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public PolarChartLegendBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
