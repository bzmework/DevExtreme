using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Funnel is a widget that visualizes a value at different stages. It helps assess value changes throughout these stages and identify potential issues. The Funnel widget conveys information using different interactive elements (tooltips, labels, legend) and enables you to create not only a funnel, but also a pyramid chart.</summary>
	public class FunnelBuilder : WidgetBuilder
	{
		[Generated]
		public FunnelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public FunnelBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public FunnelBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies adaptive layout options.</summary>
		[Generated]
		public FunnelBuilder AdaptiveLayout(Action<FunnelAdaptiveLayoutBuilder> configurator)
		{
			NestedOptions("adaptiveLayout", configurator);
			return this;
		}

		/// <summary>Specifies the algorithm for building the funnel.</summary>
		[Generated]
		public FunnelBuilder Algorithm(FunnelAlgorithm value)
		{
			base.Options["algorithm"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for funnel items. The argument identifies a funnel item and represents it on the legend.</summary>
		[Generated]
		public FunnelBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides arguments for funnel items. The argument identifies a funnel item and represents it on the legend.</summary>
		[Generated]
		public FunnelBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides colors for funnel items. If this field is absent, the palette provides the colors.</summary>
		[Generated]
		public FunnelBuilder ColorField(string value)
		{
			base.Options["colorField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides colors for funnel items. If this field is absent, the palette provides the colors.</summary>
		[Generated]
		public FunnelBuilder ColorField(JS value)
		{
			base.Options["colorField"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public FunnelBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public FunnelBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public FunnelBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public FunnelBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public FunnelBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public FunnelBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public FunnelBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FunnelBuilder ElementAttr(string attributeName, object value)
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
		public FunnelBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FunnelBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FunnelBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public FunnelBuilder Export(Action<FunnelExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies whether funnel items change their style when a user pauses on them.</summary>
		[Generated]
		public FunnelBuilder HoverEnabled(bool value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether funnel items change their style when a user pauses on them.</summary>
		[Generated]
		public FunnelBuilder HoverEnabled(JS value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Turns the funnel upside down.</summary>
		[Generated]
		public FunnelBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Turns the funnel upside down.</summary>
		[Generated]
		public FunnelBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Configures funnel items' appearance.</summary>
		[Generated]
		public FunnelBuilder Item(Action<FunnelItemBuilder> configurator)
		{
			NestedOptions("item", configurator);
			return this;
		}

		/// <summary>Configures funnel item labels.</summary>
		[Generated]
		public FunnelBuilder Label(Action<FunnelLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Configures the legend.</summary>
		[Generated]
		public FunnelBuilder Legend(Action<FunnelLegendBuilder> configurator)
		{
			NestedOptions("legend", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public FunnelBuilder LoadingIndicator(Action<FunnelLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public FunnelBuilder Margin(Action<FunnelMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Specifies the ratio between the height of the neck and that of the whole funnel. Accepts values from 0 to 1. Applies only if the algorithm is "dynamicHeight".</summary>
		[Generated]
		public FunnelBuilder NeckHeight(double value)
		{
			base.Options["neckHeight"] = value;
			return this;
		}

		/// <summary>Specifies the ratio between the height of the neck and that of the whole funnel. Accepts values from 0 to 1. Applies only if the algorithm is "dynamicHeight".</summary>
		[Generated]
		public FunnelBuilder NeckHeight(JS value)
		{
			base.Options["neckHeight"] = value;
			return this;
		}

		/// <summary>Specifies the ratio between the width of the neck and that of the whole funnel. Accepts values from 0 to 1. Applies only if the algorithm is "dynamicHeight".</summary>
		[Generated]
		public FunnelBuilder NeckWidth(double value)
		{
			base.Options["neckWidth"] = value;
			return this;
		}

		/// <summary>Specifies the ratio between the width of the neck and that of the whole funnel. Accepts values from 0 to 1. Applies only if the algorithm is "dynamicHeight".</summary>
		[Generated]
		public FunnelBuilder NeckWidth(JS value)
		{
			base.Options["neckWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FunnelBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FunnelBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public FunnelBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public FunnelBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public FunnelBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public FunnelBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public FunnelBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public FunnelBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public FunnelBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public FunnelBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a funnel item.</summary>
		[Generated]
		public FunnelBuilder OnHoverChanged(string jsFunc)
		{
			AssignJS("onHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a funnel item.</summary>
		[Generated]
		public FunnelBuilder OnHoverChanged(RazorBlock jsFunc)
		{
			return OnHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public FunnelBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public FunnelBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FunnelBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FunnelBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a funnel item is clicked or tapped.</summary>
		[Generated]
		public FunnelBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a funnel item is clicked or tapped.</summary>
		[Generated]
		public FunnelBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public FunnelBuilder OnLegendClick(string jsFunc)
		{
			AssignJS("onLegendClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public FunnelBuilder OnLegendClick(RazorBlock jsFunc)
		{
			return OnLegendClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FunnelBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FunnelBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a funnel item is selected or selection is canceled.</summary>
		[Generated]
		public FunnelBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a funnel item is selected or selection is canceled.</summary>
		[Generated]
		public FunnelBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used to colorize funnel items.</summary>
		[Generated]
		public FunnelBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize funnel items.</summary>
		[Generated]
		public FunnelBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize funnel items.</summary>
		[Generated]
		public FunnelBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of funnel items.</summary>
		[Generated]
		public FunnelBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public FunnelBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public FunnelBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public FunnelBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public FunnelBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies how item labels should behave when they overlap.</summary>
		[Generated]
		public FunnelBuilder ResolveLabelOverlapping(FunnelResolveLabelOverlapping value)
		{
			base.Options["resolveLabelOverlapping"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FunnelBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FunnelBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a single or multiple funnel items can be in the selected state at a time. Assigning "none" disables the selection feature.</summary>
		[Generated]
		public FunnelBuilder SelectionMode(SelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public FunnelBuilder Size(Action<FunnelSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies whether to sort funnel items.</summary>
		[Generated]
		public FunnelBuilder SortData(bool value)
		{
			base.Options["sortData"] = value;
			return this;
		}

		/// <summary>Specifies whether to sort funnel items.</summary>
		[Generated]
		public FunnelBuilder SortData(JS value)
		{
			base.Options["sortData"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public FunnelBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public FunnelBuilder Title(Action<FunnelTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public FunnelBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public FunnelBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips - small pop-up rectangles that display information about a data-visualizing widget element being pressed or hovered over with the mouse pointer.</summary>
		[Generated]
		public FunnelBuilder Tooltip(Action<FunnelTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies which data source field provides values for funnel items. The value defines a funnel item's area.</summary>
		[Generated]
		public FunnelBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies which data source field provides values for funnel items. The value defines a funnel item's area.</summary>
		[Generated]
		public FunnelBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}
	}
}
