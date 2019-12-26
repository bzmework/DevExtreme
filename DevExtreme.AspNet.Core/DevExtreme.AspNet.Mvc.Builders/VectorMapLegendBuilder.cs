using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures map legends.</summary>
	public class VectorMapLegendBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public VectorMapLegendBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLegendBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public VectorMapLegendBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the legend's background.</summary>
		[Generated]
		public VectorMapLegendBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the legend's border.</summary>
		[Generated]
		public VectorMapLegendBuilder Border(Action<VectorMapLegendsBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public VectorMapLegendBuilder ColumnCount(int value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items into several columns.</summary>
		[Generated]
		public VectorMapLegendBuilder ColumnCount(JS value)
		{
			base.Options["columnCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder ColumnItemSpacing(double value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item columns in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder ColumnItemSpacing(JS value)
		{
			base.Options["columnItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user hovers the mouse pointer over the text of a legend item.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user hovers the mouse pointer over the text of a legend item.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to change the order and visibility of legend items.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeItems(string jsFunc)
		{
			AssignJS("customizeItems", jsFunc);
			return this;
		}

		/// <summary>Allows you to change the order and visibility of legend items.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeItems(RazorBlock jsFunc)
		{
			return CustomizeItems(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies text for legend items.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies text for legend items.</summary>
		[Generated]
		public VectorMapLegendBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the legend items' font options.</summary>
		[Generated]
		public VectorMapLegendBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend's position.</summary>
		[Generated]
		public VectorMapLegendBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Aligns items in the last column or row (depending on the legend's orientation). Applies when legend items are not divided into columns or rows equally.</summary>
		[Generated]
		public VectorMapLegendBuilder ItemsAlignment(HorizontalAlignment value)
		{
			base.Options["itemsAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text's position relative to the marker in a legend item.</summary>
		[Generated]
		public VectorMapLegendBuilder ItemTextPosition(Position value)
		{
			base.Options["itemTextPosition"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public VectorMapLegendBuilder Margin(Action<VectorMapLegendsMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public VectorMapLegendBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, around the legend.</summary>
		[Generated]
		public VectorMapLegendBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the color of item markers in the legend. The specified color applied only when the legend uses 'size' source.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerColor(string value)
		{
			base.Options["markerColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of item markers in the legend. The specified color applied only when the legend uses 'size' source.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerColor(JS value)
		{
			base.Options["markerColor"] = value;
			return this;
		}

		/// <summary>Specifies the shape of item markers.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerShape(VectorMapMarkerShape value)
		{
			base.Options["markerShape"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerSize(double value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies the marker's size in a legend item in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerSize(JS value)
		{
			base.Options["markerSize"] = value;
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerTemplate(string templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerTemplate(RazorBlock templateContent)
		{
			AssignTemplate("markerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerTemplate(TemplateName name)
		{
			AssignTemplate("markerTemplate", name);
			return this;
		}

		/// <summary>Specifies an SVG element that serves as a custom legend item marker.</summary>
		[Generated]
		public VectorMapLegendBuilder MarkerTemplate(JS value)
		{
			base.Options["markerTemplate"] = value;
			return this;
		}

		/// <summary>Arranges legend items vertically (in a column) or horizontally (in a row). The default value is "horizontal" if the legend.horizontalAlignment is "center". Otherwise, it is "vertical".</summary>
		[Generated]
		public VectorMapLegendBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public VectorMapLegendBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's left/right border and its items.</summary>
		[Generated]
		public VectorMapLegendBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public VectorMapLegendBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between the legend's top/bottom border and its items.</summary>
		[Generated]
		public VectorMapLegendBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public VectorMapLegendBuilder RowCount(int value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Arranges legend items in several rows.</summary>
		[Generated]
		public VectorMapLegendBuilder RowCount(JS value)
		{
			base.Options["rowCount"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder RowItemSpacing(double value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies an empty space between item rows in pixels.</summary>
		[Generated]
		public VectorMapLegendBuilder RowItemSpacing(JS value)
		{
			base.Options["rowItemSpacing"] = value;
			return this;
		}

		/// <summary>Specifies the source of data for the legend.</summary>
		[Generated]
		public VectorMapLegendBuilder Source(Action<VectorMapLegendsSourceBuilder> configurator)
		{
			NestedOptions("source", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public VectorMapLegendBuilder Title(Action<VectorMapLegendsTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public VectorMapLegendBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the legend title.</summary>
		[Generated]
		public VectorMapLegendBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Along with horizontalAlignment, specifies the legend's position.</summary>
		[Generated]
		public VectorMapLegendBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public VectorMapLegendBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the legend's visibility.</summary>
		[Generated]
		public VectorMapLegendBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
