using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of a chart's legend.</summary>
	public class ChartLegendBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartLegendBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartLegendBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public ChartLegendBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public ChartLegendBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the legend's border.</summary>
		[Generated]
		public ChartLegendBuilder Border(Action<ChartLegendBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public ChartLegendBuilder ColumnCount(int value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public ChartLegendBuilder ColumnCount(JS value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public ChartLegendBuilder ColumnItemSpacing(double value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public ChartLegendBuilder ColumnItemSpacing(JS value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeItems(string jsFunc)
		{
			AssignJS("customizeItems", jsFunc);
			return this;
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeItems(RazorBlock jsFunc)
		{
			return CustomizeItems(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by a legend item.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by a legend item.</summary>
		[Generated]
		public ChartLegendBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the legend items' font options.</summary>
		[Generated]
		public ChartLegendBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend's position.</summary>
		[Generated]
		public ChartLegendBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies what series elements to highlight when a corresponding item in the legend is hovered over.</summary>
		[Generated]
		public ChartLegendBuilder HoverMode(ChartLegendHoverMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Aligns items in the last column or row (depending on the legend's orientation). Applies when legend items are not divided into columns or rows equally.</summary>
		[Generated]
		public ChartLegendBuilder ItemsAlignment(HorizontalAlignment value)
		{
			base.Options["itemsAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text's position relative to the marker in a legend item.</summary>
		[Generated]
		public ChartLegendBuilder ItemTextPosition(Position value)
		{
			base.Options["itemTextPosition"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public ChartLegendBuilder Margin(Action<ChartLegendMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public ChartLegendBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public ChartLegendBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public ChartLegendBuilder MarkerSize(double value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public ChartLegendBuilder MarkerSize(JS value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public ChartLegendBuilder MarkerTemplate(string templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public ChartLegendBuilder MarkerTemplate(RazorBlock templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public ChartLegendBuilder MarkerTemplate(TemplateName name)
		{
			AssignTemplate("markerTemplate", name);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public ChartLegendBuilder MarkerTemplate(JS value)
		{
			base.Options["markerTemplate"] = value;
			return this;
		}

		/// <summary>Arranges legend items vertically (in a column) or horizontally (in a row). The default value is "horizontal" if the legend.horizontalAlignment is "center". Otherwise, it is "vertical".</summary>
		[Generated]
		public ChartLegendBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public ChartLegendBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public ChartLegendBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public ChartLegendBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public ChartLegendBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies whether the legend is located outside or inside the chart's plot.</summary>
		[Generated]
		public ChartLegendBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public ChartLegendBuilder RowCount(int value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public ChartLegendBuilder RowCount(JS value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public ChartLegendBuilder RowItemSpacing(double value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public ChartLegendBuilder RowItemSpacing(JS value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public ChartLegendBuilder Title(Action<ChartLegendTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public ChartLegendBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public ChartLegendBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Along with horizontalAlignment, specifies the legend's position.</summary>
		[Generated]
		public ChartLegendBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public ChartLegendBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public ChartLegendBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
