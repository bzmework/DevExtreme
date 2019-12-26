using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The TreeMap is a widget that displays hierarchical data by using nested rectangles.</summary>
	public class TreeMapBuilder : WidgetBuilder
	{
		[Generated]
		public TreeMapBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TreeMapBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TreeMapBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides nested items for a group. Applies to hierarchical data sources only.</summary>
		[Generated]
		public TreeMapBuilder ChildrenField(string value)
		{
			base.Options["childrenField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides nested items for a group. Applies to hierarchical data sources only.</summary>
		[Generated]
		public TreeMapBuilder ChildrenField(JS value)
		{
			base.Options["childrenField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides colors for tiles.</summary>
		[Generated]
		public TreeMapBuilder ColorField(string value)
		{
			base.Options["colorField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides colors for tiles.</summary>
		[Generated]
		public TreeMapBuilder ColorField(JS value)
		{
			base.Options["colorField"] = value;
			return this;
		}

		/// <summary>Manages the color settings.</summary>
		[Generated]
		public TreeMapBuilder Colorizer(Action<TreeMapColorizerBuilder> configurator)
		{
			NestedOptions("colorizer", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeMapBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeMapBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeMapBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeMapBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TreeMapBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public TreeMapBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public TreeMapBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeMapBuilder ElementAttr(string attributeName, object value)
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
		public TreeMapBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeMapBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TreeMapBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public TreeMapBuilder Export(Action<TreeMapExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Configures groups.</summary>
		[Generated]
		public TreeMapBuilder Group(Action<TreeMapGroupBuilder> configurator)
		{
			NestedOptions("group", configurator);
			return this;
		}

		/// <summary>Specifies whether tiles and groups change their style when a user pauses on them.</summary>
		[Generated]
		public TreeMapBuilder HoverEnabled(bool value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether tiles and groups change their style when a user pauses on them.</summary>
		[Generated]
		public TreeMapBuilder HoverEnabled(JS value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides IDs for items. Applies to plain data sources only.</summary>
		[Generated]
		public TreeMapBuilder IdField(string value)
		{
			base.Options["idField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides IDs for items. Applies to plain data sources only.</summary>
		[Generated]
		public TreeMapBuilder IdField(JS value)
		{
			base.Options["idField"] = value;
			return this;
		}

		/// <summary>Specifies whether the user will interact with a single tile or its group.</summary>
		[Generated]
		public TreeMapBuilder InteractWithGroup(bool value)
		{
			base.Options["interactWithGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether the user will interact with a single tile or its group.</summary>
		[Generated]
		public TreeMapBuilder InteractWithGroup(JS value)
		{
			base.Options["interactWithGroup"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides texts for tile and group labels.</summary>
		[Generated]
		public TreeMapBuilder LabelField(string value)
		{
			base.Options["labelField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides texts for tile and group labels.</summary>
		[Generated]
		public TreeMapBuilder LabelField(JS value)
		{
			base.Options["labelField"] = value;
			return this;
		}

		/// <summary>Specifies the layout algorithm.</summary>
		[Generated]
		public TreeMapBuilder LayoutAlgorithm(TreeMapLayoutAlgorithm value)
		{
			base.Options["layoutAlgorithm"] = value;
			return this;
		}

		/// <summary>Specifies the direction in which the items will be laid out.</summary>
		[Generated]
		public TreeMapBuilder LayoutDirection(TreeMapLayoutDirection value)
		{
			base.Options["layoutDirection"] = value;
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public TreeMapBuilder LoadingIndicator(Action<TreeMapLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Specifies how many hierarchical levels must be visualized.</summary>
		[Generated]
		public TreeMapBuilder MaxDepth(double value)
		{
			base.Options["maxDepth"] = value;
			return this;
		}

		/// <summary>Specifies how many hierarchical levels must be visualized.</summary>
		[Generated]
		public TreeMapBuilder MaxDepth(JS value)
		{
			base.Options["maxDepth"] = value;
			return this;
		}

		/// <summary>A function that is executed when a node is clicked or tapped.</summary>
		[Generated]
		public TreeMapBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a node is clicked or tapped.</summary>
		[Generated]
		public TreeMapBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeMapBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TreeMapBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public TreeMapBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public TreeMapBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user drills up or down.</summary>
		[Generated]
		public TreeMapBuilder OnDrill(string jsFunc)
		{
			AssignJS("onDrill", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user drills up or down.</summary>
		[Generated]
		public TreeMapBuilder OnDrill(RazorBlock jsFunc)
		{
			return OnDrill(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public TreeMapBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public TreeMapBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public TreeMapBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public TreeMapBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public TreeMapBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public TreeMapBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a node.</summary>
		[Generated]
		public TreeMapBuilder OnHoverChanged(string jsFunc)
		{
			AssignJS("onHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a node.</summary>
		[Generated]
		public TreeMapBuilder OnHoverChanged(RazorBlock jsFunc)
		{
			return OnHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public TreeMapBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public TreeMapBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeMapBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TreeMapBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed only once, after the nodes are initialized.</summary>
		[Generated]
		public TreeMapBuilder OnNodesInitialized(string jsFunc)
		{
			AssignJS("onNodesInitialized", jsFunc);
			return this;
		}

		/// <summary>A function that is executed only once, after the nodes are initialized.</summary>
		[Generated]
		public TreeMapBuilder OnNodesInitialized(RazorBlock jsFunc)
		{
			return OnNodesInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the nodes are displayed and each time the collection of active nodes is changed.</summary>
		[Generated]
		public TreeMapBuilder OnNodesRendering(string jsFunc)
		{
			AssignJS("onNodesRendering", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the nodes are displayed and each time the collection of active nodes is changed.</summary>
		[Generated]
		public TreeMapBuilder OnNodesRendering(RazorBlock jsFunc)
		{
			return OnNodesRendering(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeMapBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TreeMapBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a node is selected or selection is canceled.</summary>
		[Generated]
		public TreeMapBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a node is selected or selection is canceled.</summary>
		[Generated]
		public TreeMapBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the name of the data source field that provides parent IDs for items. Applies to plain data sources only.</summary>
		[Generated]
		public TreeMapBuilder ParentField(string value)
		{
			base.Options["parentField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides parent IDs for items. Applies to plain data sources only.</summary>
		[Generated]
		public TreeMapBuilder ParentField(JS value)
		{
			base.Options["parentField"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public TreeMapBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public TreeMapBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public TreeMapBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public TreeMapBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		[Obsolete("Use the tile.label.textOverflow option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public TreeMapBuilder ResolveLabelOverflow(TreeMapResolveLabelOverflow value)
		{
			base.Options["resolveLabelOverflow"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeMapBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TreeMapBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a single or multiple nodes can be in the selected state simultaneously.</summary>
		[Generated]
		public TreeMapBuilder SelectionMode(SelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public TreeMapBuilder Size(Action<TreeMapSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public TreeMapBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures tiles.</summary>
		[Generated]
		public TreeMapBuilder Tile(Action<TreeMapTileBuilder> configurator)
		{
			NestedOptions("tile", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public TreeMapBuilder Title(Action<TreeMapTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public TreeMapBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public TreeMapBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips - small pop-up rectangles that display information about a data-visualizing widget element being pressed or hovered over with the mouse pointer.</summary>
		[Generated]
		public TreeMapBuilder Tooltip(Action<TreeMapTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides values for tiles.</summary>
		[Generated]
		public TreeMapBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field that provides values for tiles.</summary>
		[Generated]
		public TreeMapBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}
	}
}
