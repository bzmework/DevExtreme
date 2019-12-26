using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Sankey is a widget that visualizes the flow magnitude between value sets. The values being connected are called nodes; the connections - links. The higher the flow magnitude, the wider the link is.</summary>
	public class SankeyBuilder : WidgetBuilder
	{
		[Generated]
		public SankeyBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SankeyBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SankeyBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies adaptive layout options.</summary>
		[Generated]
		public SankeyBuilder AdaptiveLayout(Action<SankeyAdaptiveLayoutBuilder> configurator)
		{
			NestedOptions("adaptiveLayout", configurator);
			return this;
		}

		/// <summary>Aligns node columns vertically.</summary>
		[Generated]
		public SankeyBuilder Alignment(IEnumerable<VerticalAlignment> value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SankeyBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SankeyBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SankeyBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SankeyBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SankeyBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public SankeyBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public SankeyBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SankeyBuilder ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SankeyBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SankeyBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SankeyBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public SankeyBuilder Export(Action<SankeyExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies whether nodes and links change their style when they are hovered over or pressed.</summary>
		[Generated]
		public SankeyBuilder HoverEnabled(bool value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether nodes and links change their style when they are hovered over or pressed.</summary>
		[Generated]
		public SankeyBuilder HoverEnabled(JS value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Configures sankey nodes' labels.</summary>
		[Generated]
		public SankeyBuilder Label(Action<SankeyLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Configures sankey links' appearance.</summary>
		[Generated]
		public SankeyBuilder Link(Action<SankeyLinkBuilder> configurator)
		{
			NestedOptions("link", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public SankeyBuilder LoadingIndicator(Action<SankeyLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public SankeyBuilder Margin(Action<SankeyMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Configures sankey nodes' appearance.</summary>
		[Generated]
		public SankeyBuilder Node(Action<SankeyNodeBuilder> configurator)
		{
			NestedOptions("node", configurator);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SankeyBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SankeyBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public SankeyBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public SankeyBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public SankeyBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public SankeyBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public SankeyBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public SankeyBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public SankeyBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public SankeyBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public SankeyBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public SankeyBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SankeyBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SankeyBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a sankey link is clicked or tapped.</summary>
		[Generated]
		public SankeyBuilder OnLinkClick(string jsFunc)
		{
			AssignJS("onLinkClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a sankey link is clicked or tapped.</summary>
		[Generated]
		public SankeyBuilder OnLinkClick(RazorBlock jsFunc)
		{
			return OnLinkClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a sankey link.</summary>
		[Generated]
		public SankeyBuilder OnLinkHoverChanged(string jsFunc)
		{
			AssignJS("onLinkHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a sankey link.</summary>
		[Generated]
		public SankeyBuilder OnLinkHoverChanged(RazorBlock jsFunc)
		{
			return OnLinkHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a sankey node is clicked or tapped.</summary>
		[Generated]
		public SankeyBuilder OnNodeClick(string jsFunc)
		{
			AssignJS("onNodeClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a sankey node is clicked or tapped.</summary>
		[Generated]
		public SankeyBuilder OnNodeClick(RazorBlock jsFunc)
		{
			return OnNodeClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a sankey node.</summary>
		[Generated]
		public SankeyBuilder OnNodeHoverChanged(string jsFunc)
		{
			AssignJS("onNodeHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a sankey node.</summary>
		[Generated]
		public SankeyBuilder OnNodeHoverChanged(RazorBlock jsFunc)
		{
			return OnNodeHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SankeyBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SankeyBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used to colorize sankey nodes.</summary>
		[Generated]
		public SankeyBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize sankey nodes.</summary>
		[Generated]
		public SankeyBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize sankey nodes.</summary>
		[Generated]
		public SankeyBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies how to extend the palette when it contains less colors than the number of sankey nodes.</summary>
		[Generated]
		public SankeyBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public SankeyBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public SankeyBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public SankeyBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public SankeyBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SankeyBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SankeyBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public SankeyBuilder Size(Action<SankeySizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies nodes' sorting order in their columns.</summary>
		[Generated]
		public SankeyBuilder SortData(object value)
		{
			base.Options["sortData"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides links' source nodes.</summary>
		[Generated]
		public SankeyBuilder SourceField(string value)
		{
			base.Options["sourceField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides links' source nodes.</summary>
		[Generated]
		public SankeyBuilder SourceField(JS value)
		{
			base.Options["sourceField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides links' target nodes.</summary>
		[Generated]
		public SankeyBuilder TargetField(string value)
		{
			base.Options["targetField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides links' target nodes.</summary>
		[Generated]
		public SankeyBuilder TargetField(JS value)
		{
			base.Options["targetField"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public SankeyBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public SankeyBuilder Title(Action<SankeyTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public SankeyBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public SankeyBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips - small pop-up rectangles that display information about a data-visualizing widget element being pressed or hovered over with the mouse pointer.</summary>
		[Generated]
		public SankeyBuilder Tooltip(Action<SankeyTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides links' weights.</summary>
		[Generated]
		public SankeyBuilder WeightField(string value)
		{
			base.Options["weightField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides links' weights.</summary>
		[Generated]
		public SankeyBuilder WeightField(JS value)
		{
			base.Options["weightField"] = value;
			return this;
		}
	}
}
