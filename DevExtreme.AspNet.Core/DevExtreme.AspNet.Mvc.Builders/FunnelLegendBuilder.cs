using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend.</summary>
	public class FunnelLegendBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLegendBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLegendBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public FunnelLegendBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public FunnelLegendBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the legend's border.</summary>
		[Generated]
		public FunnelLegendBuilder Border(Action<FunnelLegendBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public FunnelLegendBuilder ColumnCount(int value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public FunnelLegendBuilder ColumnCount(JS value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder ColumnItemSpacing(double value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder ColumnItemSpacing(JS value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeItems(string jsFunc)
		{
			AssignJS("customizeItems", jsFunc);
			return this;
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeItems(RazorBlock jsFunc)
		{
			return CustomizeItems(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the text displayed by legend items.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by legend items.</summary>
		[Generated]
		public FunnelLegendBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the legend items' font options.</summary>
		[Generated]
		public FunnelLegendBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend's position.</summary>
		[Generated]
		public FunnelLegendBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Aligns items in the last column or row (depending on the legend's orientation). Applies when legend items are not divided into columns or rows equally.</summary>
		[Generated]
		public FunnelLegendBuilder ItemsAlignment(HorizontalAlignment value)
		{
			base.Options["itemsAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text's position relative to the marker in a legend item.</summary>
		[Generated]
		public FunnelLegendBuilder ItemTextPosition(Position value)
		{
			base.Options["itemTextPosition"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public FunnelLegendBuilder Margin(Action<FunnelLegendMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public FunnelLegendBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public FunnelLegendBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerSize(double value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerSize(JS value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerTemplate(string templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerTemplate(RazorBlock templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerTemplate(TemplateName name)
		{
			AssignTemplate("markerTemplate", name);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public FunnelLegendBuilder MarkerTemplate(JS value)
		{
			base.Options["markerTemplate"] = value;
			return this;
		}

		/// <summary>Arranges legend items vertically (in a column) or horizontally (in a row). The default value is "horizontal" if the legend.horizontalAlignment is "center". Otherwise, it is "vertical".</summary>
		[Generated]
		public FunnelLegendBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public FunnelLegendBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public FunnelLegendBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public FunnelLegendBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public FunnelLegendBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public FunnelLegendBuilder RowCount(int value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public FunnelLegendBuilder RowCount(JS value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder RowItemSpacing(double value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public FunnelLegendBuilder RowItemSpacing(JS value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public FunnelLegendBuilder Title(Action<FunnelLegendTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public FunnelLegendBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public FunnelLegendBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Along with horizontalAlignment, specifies the legend's position.</summary>
		[Generated]
		public FunnelLegendBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public FunnelLegendBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public FunnelLegendBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
