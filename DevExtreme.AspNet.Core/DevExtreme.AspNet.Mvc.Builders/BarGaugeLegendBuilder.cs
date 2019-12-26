using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend.</summary>
	public class BarGaugeLegendBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeLegendBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeLegendBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public BarGaugeLegendBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public BarGaugeLegendBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the legend's border.</summary>
		[Generated]
		public BarGaugeLegendBuilder Border(Action<BarGaugeLegendBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public BarGaugeLegendBuilder ColumnCount(int value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public BarGaugeLegendBuilder ColumnCount(JS value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder ColumnItemSpacing(double value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder ColumnItemSpacing(JS value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the hint that appears when a user hovers the mouse pointer over a legend item.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeItems(string jsFunc)
		{
			AssignJS("customizeItems", jsFunc);
			return this;
		}

		/// <summary>Allows you to change the order, text, and visibility of legend items.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeItems(RazorBlock jsFunc)
		{
			return CustomizeItems(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the text displayed by legend items.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by legend items.</summary>
		[Generated]
		public BarGaugeLegendBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the legend items' font options.</summary>
		[Generated]
		public BarGaugeLegendBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend's position.</summary>
		[Generated]
		public BarGaugeLegendBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Aligns items in the last column or row (depending on the legend's orientation). Applies when legend items are not divided into columns or rows equally.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemsAlignment(HorizontalAlignment value)
		{
			base.Options["itemsAlignment"] = value;
			return this;
		}

		/// <summary>Formats the item text before it is displayed. Accepts only numeric formats. When unspecified, it inherits the label's format.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemTextFormat(Format value)
		{
			base.Options["itemTextFormat"] = value;
			return this;
		}

		/// <summary>Formats the item text before it is displayed. Accepts only numeric formats. When unspecified, it inherits the label's format.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemTextFormat(string value)
		{
			base.Options["itemTextFormat"] = value;
			return this;
		}

		/// <summary>Formats the item text before it is displayed. Accepts only numeric formats. When unspecified, it inherits the label's format.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemTextFormat(JS value)
		{
			base.Options["itemTextFormat"] = value;
			return this;
		}

		/// <summary>Formats the item text before it is displayed. Accepts only numeric formats. When unspecified, it inherits the label's format.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemTextFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("itemTextFormat", configurator);
			return this;
		}

		/// <summary>Specifies the text's position relative to the marker in a legend item.</summary>
		[Generated]
		public BarGaugeLegendBuilder ItemTextPosition(Position value)
		{
			base.Options["itemTextPosition"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public BarGaugeLegendBuilder Margin(Action<BarGaugeLegendMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public BarGaugeLegendBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public BarGaugeLegendBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerSize(double value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerSize(JS value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerTemplate(string templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerTemplate(RazorBlock templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerTemplate(TemplateName name)
		{
			AssignTemplate("markerTemplate", name);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public BarGaugeLegendBuilder MarkerTemplate(JS value)
		{
			base.Options["markerTemplate"] = value;
			return this;
		}

		/// <summary>Arranges legend items vertically (in a column) or horizontally (in a row). The default value is "horizontal" if the legend.horizontalAlignment is "center". Otherwise, it is "vertical".</summary>
		[Generated]
		public BarGaugeLegendBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public BarGaugeLegendBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public BarGaugeLegendBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public BarGaugeLegendBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public BarGaugeLegendBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public BarGaugeLegendBuilder RowCount(int value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public BarGaugeLegendBuilder RowCount(JS value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder RowItemSpacing(double value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public BarGaugeLegendBuilder RowItemSpacing(JS value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public BarGaugeLegendBuilder Title(Action<BarGaugeLegendTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public BarGaugeLegendBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public BarGaugeLegendBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Along with horizontalAlignment, specifies the legend's position.</summary>
		[Generated]
		public BarGaugeLegendBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public BarGaugeLegendBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public BarGaugeLegendBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
