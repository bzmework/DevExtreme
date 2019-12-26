using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for VectorMap widget layers.</summary>
	public class VectorMapLayerBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public VectorMapLayerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLayerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder BorderColor(string value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder BorderColor(JS value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies the line width (for layers of a line type) or width of the layer elements border in pixels.</summary>
		[Generated]
		public VectorMapLayerBuilder BorderWidth(double value)
		{
			base.Options["borderWidth"] = value;
			return this;
		}

		/// <summary>Specifies the line width (for layers of a line type) or width of the layer elements border in pixels.</summary>
		[Generated]
		public VectorMapLayerBuilder BorderWidth(JS value)
		{
			base.Options["borderWidth"] = value;
			return this;
		}

		/// <summary>Specifies a color for layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the field that provides data to be used for coloring of layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder ColorGroupingField(string value)
		{
			base.Options["colorGroupingField"] = value;
			return this;
		}

		/// <summary>Specifies the field that provides data to be used for coloring of layer elements.</summary>
		[Generated]
		public VectorMapLayerBuilder ColorGroupingField(JS value)
		{
			base.Options["colorGroupingField"] = value;
			return this;
		}

		/// <summary>Allows you to paint layer elements with similar attributes in the same color.</summary>
		[Generated]
		public VectorMapLayerBuilder ColorGroups(IEnumerable<double> value)
		{
			base.Options["colorGroups"] = value;
			return this;
		}

		/// <summary>Allows you to paint layer elements with similar attributes in the same color.</summary>
		[Generated]
		public VectorMapLayerBuilder ColorGroups(JS value)
		{
			base.Options["colorGroups"] = value;
			return this;
		}

		/// <summary>Specifies the function that customizes each layer element individually.</summary>
		[Generated]
		public VectorMapLayerBuilder Customize(string jsFunc)
		{
			AssignJS("customize", jsFunc);
			return this;
		}

		/// <summary>Specifies the function that customizes each layer element individually.</summary>
		[Generated]
		public VectorMapLayerBuilder Customize(RazorBlock jsFunc)
		{
			return Customize(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the name of the attribute containing marker data. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble", "pie" or "image".</summary>
		[Generated]
		public VectorMapLayerBuilder DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the attribute containing marker data. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble", "pie" or "image".</summary>
		[Generated]
		public VectorMapLayerBuilder DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies a data source for the layer.</summary>
		[Generated]
		public VectorMapLayerBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies a data source for the layer.</summary>
		[Generated]
		public VectorMapLayerBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies a data source for the layer.</summary>
		[Generated]
		public VectorMapLayerBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies a data source for the layer.</summary>
		[Generated]
		public VectorMapLayerBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies a data source for the layer.</summary>
		[Generated]
		public VectorMapLayerBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the type of a marker element. Setting this option makes sense only if the layer type is "marker".</summary>
		[Generated]
		public VectorMapLayerBuilder ElementType(VectorMapMarkerType value)
		{
			base.Options["elementType"] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredBorderColor(string value)
		{
			base.Options["hoveredBorderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredBorderColor(JS value)
		{
			base.Options["hoveredBorderColor"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured line width (for layers of a line type) or width for the border of the layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredBorderWidth(double value)
		{
			base.Options["hoveredBorderWidth"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured line width (for layers of a line type) or width for the border of the layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredBorderWidth(JS value)
		{
			base.Options["hoveredBorderWidth"] = value;
			return this;
		}

		/// <summary>Specifies a color for a layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredColor(string value)
		{
			base.Options["hoveredColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for a layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoveredColor(JS value)
		{
			base.Options["hoveredColor"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to change the appearance of a layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoverEnabled(bool value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to change the appearance of a layer element when it is hovered over.</summary>
		[Generated]
		public VectorMapLayerBuilder HoverEnabled(JS value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies marker label options.</summary>
		[Generated]
		public VectorMapLayerBuilder Label(Action<VectorMapLayersLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies the pixel-measured diameter of the marker that represents the biggest value. Setting this option makes sense only if the layer type is "marker".</summary>
		[Generated]
		public VectorMapLayerBuilder MaxSize(double value)
		{
			base.Options["maxSize"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured diameter of the marker that represents the biggest value. Setting this option makes sense only if the layer type is "marker".</summary>
		[Generated]
		public VectorMapLayerBuilder MaxSize(JS value)
		{
			base.Options["maxSize"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured diameter of the marker that represents the smallest value. Setting this option makes sense only if the layer type is "marker".</summary>
		[Generated]
		public VectorMapLayerBuilder MinSize(double value)
		{
			base.Options["minSize"] = value;
			return this;
		}

		/// <summary>Specifies the pixel-measured diameter of the marker that represents the smallest value. Setting this option makes sense only if the layer type is "marker".</summary>
		[Generated]
		public VectorMapLayerBuilder MinSize(JS value)
		{
			base.Options["minSize"] = value;
			return this;
		}

		/// <summary>Specifies the layer name.</summary>
		[Generated]
		public VectorMapLayerBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the layer name.</summary>
		[Generated]
		public VectorMapLayerBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the layer opacity (from 0 to 1).</summary>
		[Generated]
		public VectorMapLayerBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the layer opacity (from 0 to 1).</summary>
		[Generated]
		public VectorMapLayerBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the name of the palette or a custom range of colors to be used for coloring a layer.</summary>
		[Generated]
		public VectorMapLayerBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the name of the palette or a custom range of colors to be used for coloring a layer.</summary>
		[Generated]
		public VectorMapLayerBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the name of the palette or a custom range of colors to be used for coloring a layer.</summary>
		[Generated]
		public VectorMapLayerBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the number of colors in a palette.</summary>
		[Generated]
		public VectorMapLayerBuilder PaletteSize(double value)
		{
			base.Options["paletteSize"] = value;
			return this;
		}

		/// <summary>Specifies the number of colors in a palette.</summary>
		[Generated]
		public VectorMapLayerBuilder PaletteSize(JS value)
		{
			base.Options["paletteSize"] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedBorderColor(string value)
		{
			base.Options["selectedBorderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the border of the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedBorderColor(JS value)
		{
			base.Options["selectedBorderColor"] = value;
			return this;
		}

		/// <summary>Specifies a pixel-measured line width (for layers of a line type) or width for the border of the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedBorderWidth(double value)
		{
			base.Options["selectedBorderWidth"] = value;
			return this;
		}

		/// <summary>Specifies a pixel-measured line width (for layers of a line type) or width for the border of the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedBorderWidth(JS value)
		{
			base.Options["selectedBorderWidth"] = value;
			return this;
		}

		/// <summary>Specifies a color for the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedColor(string value)
		{
			base.Options["selectedColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the layer element when it is selected.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectedColor(JS value)
		{
			base.Options["selectedColor"] = value;
			return this;
		}

		/// <summary>Specifies whether single or multiple map elements can be selected on a vector map.</summary>
		[Generated]
		public VectorMapLayerBuilder SelectionMode(SelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies the size of markers. Setting this option makes sense only if the layer type is "marker" and the elementType is "dot", "pie" or "image".</summary>
		[Generated]
		public VectorMapLayerBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the size of markers. Setting this option makes sense only if the layer type is "marker" and the elementType is "dot", "pie" or "image".</summary>
		[Generated]
		public VectorMapLayerBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the field that provides data to be used for sizing bubble markers. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble".</summary>
		[Generated]
		public VectorMapLayerBuilder SizeGroupingField(string value)
		{
			base.Options["sizeGroupingField"] = value;
			return this;
		}

		/// <summary>Specifies the field that provides data to be used for sizing bubble markers. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble".</summary>
		[Generated]
		public VectorMapLayerBuilder SizeGroupingField(JS value)
		{
			base.Options["sizeGroupingField"] = value;
			return this;
		}

		/// <summary>Allows you to display bubbles with similar attributes in the same size. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble".</summary>
		[Generated]
		public VectorMapLayerBuilder SizeGroups(IEnumerable<double> value)
		{
			base.Options["sizeGroups"] = value;
			return this;
		}

		/// <summary>Allows you to display bubbles with similar attributes in the same size. Setting this option makes sense only if the layer type is "marker" and the elementType is "bubble".</summary>
		[Generated]
		public VectorMapLayerBuilder SizeGroups(JS value)
		{
			base.Options["sizeGroups"] = value;
			return this;
		}

		/// <summary>Specifies layer type.</summary>
		[Generated]
		public VectorMapLayerBuilder Type(VectorMapLayerType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
