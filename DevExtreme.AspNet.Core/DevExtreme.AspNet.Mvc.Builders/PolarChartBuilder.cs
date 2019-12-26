using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The PolarChart is a widget that visualizes data in a polar coordinate system.</summary>
	public class PolarChartBuilder : WidgetBuilder
	{
		[Generated]
		public PolarChartBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public PolarChartBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public PolarChartBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies adaptive layout options.</summary>
		[Generated]
		public PolarChartBuilder AdaptiveLayout(Action<PolarChartAdaptiveLayoutBuilder> configurator)
		{
			NestedOptions("adaptiveLayout", configurator);
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PolarChartBuilder Animation(Action<PolarChartAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PolarChartBuilder Animation(bool value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PolarChartBuilder Animation(JS value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies argument axis options for the PolarChart widget.</summary>
		[Generated]
		public PolarChartBuilder ArgumentAxis(Action<PolarChartArgumentAxisBuilder> configurator)
		{
			NestedOptions("argumentAxis", configurator);
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public PolarChartBuilder BarGroupPadding(double value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the angular width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public PolarChartBuilder BarGroupPadding(JS value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for groups of bars with the same argument, measured in degrees. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public PolarChartBuilder BarGroupWidth(double value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed angular width for groups of bars with the same argument, measured in degrees. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public PolarChartBuilder BarGroupWidth(JS value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonPolarChartSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PolarChartBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonPolarChartSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PolarChartBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>An object defining the configuration options that are common for all axes of the PolarChart widget.</summary>
		[Generated]
		public PolarChartBuilder CommonAxisSettings(Action<PolarChartCommonAxisSettingsBuilder> configurator)
		{
			NestedOptions("commonAxisSettings", configurator);
			return this;
		}

		/// <summary>An object defining the configuration options that are common for all series of the PolarChart widget.</summary>
		[Generated]
		public PolarChartBuilder CommonSeriesSettings(Action<PolarChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("commonSeriesSettings", configurator);
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public PolarChartBuilder ContainerBackgroundColor(string value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public PolarChartBuilder ContainerBackgroundColor(JS value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public PolarChartBuilder CustomizeLabel(string jsFunc)
		{
			AssignJS("customizeLabel", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public PolarChartBuilder CustomizeLabel(RazorBlock jsFunc)
		{
			return CustomizeLabel(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public PolarChartBuilder CustomizePoint(string jsFunc)
		{
			AssignJS("customizePoint", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public PolarChartBuilder CustomizePoint(RazorBlock jsFunc)
		{
			return CustomizePoint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>An object providing options for managing data from a data source.</summary>
		[Generated]
		public PolarChartBuilder DataPrepareSettings(Action<PolarChartDataPrepareSettingsBuilder> configurator)
		{
			NestedOptions("dataPrepareSettings", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PolarChartBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PolarChartBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PolarChartBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PolarChartBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PolarChartBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public PolarChartBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public PolarChartBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PolarChartBuilder ElementAttr(string attributeName, object value)
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
		public PolarChartBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PolarChartBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PolarChartBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		[Obsolete("Use CommonPolarChartSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PolarChartBuilder EqualBarWidth(bool value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonPolarChartSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PolarChartBuilder EqualBarWidth(JS value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public PolarChartBuilder Export(Action<PolarChartExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies the options of a chart's legend.</summary>
		[Generated]
		public PolarChartBuilder Legend(Action<PolarChartLegendBuilder> configurator)
		{
			NestedOptions("legend", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public PolarChartBuilder LoadingIndicator(Action<PolarChartLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public PolarChartBuilder Margin(Action<PolarChartMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public PolarChartBuilder NegativesAsZeroes(bool value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public PolarChartBuilder NegativesAsZeroes(JS value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>A function that is executed when a label on the argument axis is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnArgumentAxisClick(string jsFunc)
		{
			AssignJS("onArgumentAxisClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a label on the argument axis is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnArgumentAxisClick(RazorBlock jsFunc)
		{
			return OnArgumentAxisClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PolarChartBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PolarChartBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public PolarChartBuilder OnDone(string jsFunc)
		{
			AssignJS("onDone", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public PolarChartBuilder OnDone(RazorBlock jsFunc)
		{
			return OnDone(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public PolarChartBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public PolarChartBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public PolarChartBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public PolarChartBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public PolarChartBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public PolarChartBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public PolarChartBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public PolarChartBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public PolarChartBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public PolarChartBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PolarChartBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PolarChartBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnLegendClick(string jsFunc)
		{
			AssignJS("onLegendClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnLegendClick(RazorBlock jsFunc)
		{
			return OnLegendClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PolarChartBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PolarChartBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnPointClick(string jsFunc)
		{
			AssignJS("onPointClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnPointClick(RazorBlock jsFunc)
		{
			return OnPointClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public PolarChartBuilder OnPointHoverChanged(string jsFunc)
		{
			AssignJS("onPointHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public PolarChartBuilder OnPointHoverChanged(RazorBlock jsFunc)
		{
			return OnPointHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public PolarChartBuilder OnPointSelectionChanged(string jsFunc)
		{
			AssignJS("onPointSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public PolarChartBuilder OnPointSelectionChanged(RazorBlock jsFunc)
		{
			return OnPointSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesClick(string jsFunc)
		{
			AssignJS("onSeriesClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series is clicked or tapped.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesClick(RazorBlock jsFunc)
		{
			return OnSeriesClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesHoverChanged(string jsFunc)
		{
			AssignJS("onSeriesHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesHoverChanged(RazorBlock jsFunc)
		{
			return OnSeriesHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series is selected or selection is canceled.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesSelectionChanged(string jsFunc)
		{
			AssignJS("onSeriesSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series is selected or selection is canceled.</summary>
		[Generated]
		public PolarChartBuilder OnSeriesSelectionChanged(RazorBlock jsFunc)
		{
			return OnSeriesSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public PolarChartBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public PolarChartBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public PolarChartBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public PolarChartBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when zooming or panning ends.</summary>
		[Generated]
		public PolarChartBuilder OnZoomEnd(string jsFunc)
		{
			AssignJS("onZoomEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when zooming or panning ends.</summary>
		[Generated]
		public PolarChartBuilder OnZoomEnd(RazorBlock jsFunc)
		{
			return OnZoomEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when zooming or panning begins.</summary>
		[Generated]
		public PolarChartBuilder OnZoomStart(string jsFunc)
		{
			AssignJS("onZoomStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when zooming or panning begins.</summary>
		[Generated]
		public PolarChartBuilder OnZoomStart(RazorBlock jsFunc)
		{
			return OnZoomStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public PolarChartBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public PolarChartBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public PolarChartBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of series (in the Chart widget) or points in a series (in the PieChart widget).</summary>
		[Generated]
		public PolarChartBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public PolarChartBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public PolarChartBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether a single point or multiple points can be selected in the chart.</summary>
		[Generated]
		public PolarChartBuilder PointSelectionMode(ChartElementSelectionMode value)
		{
			base.Options["pointSelectionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public PolarChartBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public PolarChartBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies how the chart must behave when series point labels overlap.</summary>
		[Generated]
		public PolarChartBuilder ResolveLabelOverlapping(PolarChartResolveLabelOverlapping value)
		{
			base.Options["resolveLabelOverlapping"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PolarChartBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PolarChartBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies options for PolarChart widget series.</summary>
		[Generated]
		public PolarChartBuilder Series(Action<CollectionFactory<PolarChartSeriesBuilder>> configurator)
		{
			Collection("series", configurator);
			return this;
		}

		/// <summary>Specifies whether a single series or multiple series can be selected in the chart.</summary>
		[Generated]
		public PolarChartBuilder SeriesSelectionMode(ChartElementSelectionMode value)
		{
			base.Options["seriesSelectionMode"] = value;
			return this;
		}

		/// <summary>Defines options for the series template.</summary>
		[Generated]
		public PolarChartBuilder SeriesTemplate(Action<PolarChartSeriesTemplateBuilder> configurator)
		{
			NestedOptions("seriesTemplate", configurator);
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public PolarChartBuilder Size(Action<PolarChartSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public PolarChartBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PolarChartBuilder Title(Action<PolarChartTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PolarChartBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PolarChartBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public PolarChartBuilder Tooltip(Action<PolarChartTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Indicates whether or not to display a "spider web".</summary>
		[Generated]
		public PolarChartBuilder UseSpiderWeb(bool value)
		{
			base.Options["useSpiderWeb"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to display a "spider web".</summary>
		[Generated]
		public PolarChartBuilder UseSpiderWeb(JS value)
		{
			base.Options["useSpiderWeb"] = value;
			return this;
		}

		/// <summary>Specifies value axis options for the PolarChart widget.</summary>
		[Generated]
		public PolarChartBuilder ValueAxis(Action<PolarChartValueAxisBuilder> configurator)
		{
			NestedOptions("valueAxis", configurator);
			return this;
		}
	}
}
