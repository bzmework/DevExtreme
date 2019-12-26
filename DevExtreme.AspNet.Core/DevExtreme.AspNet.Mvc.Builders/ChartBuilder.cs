using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Chart is a widget that visualizes data from a local or remote storage using a great variety of series types along with different interactive elements, such as tooltips, crosshair pointer, legend, etc.</summary>
	public class ChartBuilder : WidgetBuilder
	{
		[Generated]
		public ChartBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ChartBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ChartBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies adaptive layout options.</summary>
		[Generated]
		public ChartBuilder AdaptiveLayout(Action<ChartAdaptiveLayoutBuilder> configurator)
		{
			NestedOptions("adaptiveLayout", configurator);
			return this;
		}

		/// <summary>Specifies whether to adjust the value axis's visualRange when the argument axis is being zoomed or panned.</summary>
		[Generated]
		public ChartBuilder AdjustOnZoom(bool value)
		{
			base.Options["adjustOnZoom"] = value;
			return this;
		}

		/// <summary>Specifies whether to adjust the value axis's visualRange when the argument axis is being zoomed or panned.</summary>
		[Generated]
		public ChartBuilder AdjustOnZoom(JS value)
		{
			base.Options["adjustOnZoom"] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public ChartBuilder Animation(Action<ChartAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public ChartBuilder Animation(bool value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public ChartBuilder Animation(JS value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies the annotation collection.</summary>
		[Generated]
		public ChartBuilder Annotations(Action<CollectionFactory<ChartAnnotationConfigBuilder>> configurator)
		{
			Collection("annotations", configurator);
			return this;
		}

		/// <summary>Configures the argument axis.</summary>
		[Generated]
		public ChartBuilder ArgumentAxis(Action<ChartArgumentAxisBuilder> configurator)
		{
			NestedOptions("argumentAxis", configurator);
			return this;
		}

		/// <summary>Specifies whether to hide series point markers automatically to reduce visual clutter.</summary>
		[Generated]
		public ChartBuilder AutoHidePointMarkers(bool value)
		{
			base.Options["autoHidePointMarkers"] = value;
			return this;
		}

		/// <summary>Specifies whether to hide series point markers automatically to reduce visual clutter.</summary>
		[Generated]
		public ChartBuilder AutoHidePointMarkers(JS value)
		{
			base.Options["autoHidePointMarkers"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public ChartBuilder BarGroupPadding(double value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Controls the padding and consequently the width of a group of bars with the same argument using relative units. Ignored if the barGroupWidth option is set.</summary>
		[Generated]
		public ChartBuilder BarGroupPadding(JS value)
		{
			base.Options["barGroupPadding"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for groups of bars with the same argument, measured in pixels. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public ChartBuilder BarGroupWidth(double value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		/// <summary>Specifies a fixed width for groups of bars with the same argument, measured in pixels. Takes precedence over the barGroupPadding option.</summary>
		[Generated]
		public ChartBuilder BarGroupWidth(JS value)
		{
			base.Options["barGroupWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder BarWidth(double value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.barPadding instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder BarWidth(JS value)
		{
			base.Options["barWidth"] = value;
			return this;
		}

		/// <summary>Specifies settings common for all annotations in the chart.</summary>
		[Generated]
		public ChartBuilder CommonAnnotationSettings(Action<ChartCommonAnnotationConfigBuilder> configurator)
		{
			NestedOptions("commonAnnotationSettings", configurator);
			return this;
		}

		/// <summary>Defines common settings for both the argument and value axis in a chart.</summary>
		[Generated]
		public ChartBuilder CommonAxisSettings(Action<ChartCommonAxisSettingsBuilder> configurator)
		{
			NestedOptions("commonAxisSettings", configurator);
			return this;
		}

		/// <summary>Defines common settings for all panes in a chart.</summary>
		[Generated]
		public ChartBuilder CommonPaneSettings(Action<ChartCommonPaneSettingsBuilder> configurator)
		{
			NestedOptions("commonPaneSettings", configurator);
			return this;
		}

		/// <summary>Specifies settings common for all series in the chart.</summary>
		[Generated]
		public ChartBuilder CommonSeriesSettings(Action<ChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("commonSeriesSettings", configurator);
			return this;
		}

		/// <summary>Colors the background of the chart container.</summary>
		[Generated]
		public ChartBuilder ContainerBackgroundColor(string value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the background of the chart container.</summary>
		[Generated]
		public ChartBuilder ContainerBackgroundColor(JS value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the crosshair feature.</summary>
		[Generated]
		public ChartBuilder Crosshair(Action<ChartCrosshairBuilder> configurator)
		{
			NestedOptions("crosshair", configurator);
			return this;
		}

		/// <summary>Customizes an individual annotation.</summary>
		[Generated]
		public ChartBuilder CustomizeAnnotation(string jsFunc)
		{
			AssignJS("customizeAnnotation", jsFunc);
			return this;
		}

		/// <summary>Customizes an individual annotation.</summary>
		[Generated]
		public ChartBuilder CustomizeAnnotation(RazorBlock jsFunc)
		{
			return CustomizeAnnotation(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public ChartBuilder CustomizeLabel(string jsFunc)
		{
			AssignJS("customizeLabel", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public ChartBuilder CustomizeLabel(RazorBlock jsFunc)
		{
			return CustomizeLabel(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public ChartBuilder CustomizePoint(string jsFunc)
		{
			AssignJS("customizePoint", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public ChartBuilder CustomizePoint(RazorBlock jsFunc)
		{
			return CustomizePoint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Processes data before visualizing it.</summary>
		[Generated]
		public ChartBuilder DataPrepareSettings(Action<ChartDataPrepareSettingsBuilder> configurator)
		{
			NestedOptions("dataPrepareSettings", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ChartBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ChartBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ChartBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ChartBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ChartBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies which pane should be used by default.</summary>
		[Generated]
		public ChartBuilder DefaultPane(string value)
		{
			base.Options["defaultPane"] = value;
			return this;
		}

		/// <summary>Specifies which pane should be used by default.</summary>
		[Generated]
		public ChartBuilder DefaultPane(JS value)
		{
			base.Options["defaultPane"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public ChartBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public ChartBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ChartBuilder ElementAttr(string attributeName, object value)
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
		public ChartBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ChartBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ChartBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder EqualBarWidth(bool value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.ignoreEmptyPoints instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder EqualBarWidth(JS value)
		{
			base.Options["equalBarWidth"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public ChartBuilder Export(Action<ChartExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies the options of a chart's legend.</summary>
		[Generated]
		public ChartBuilder Legend(Action<ChartLegendBuilder> configurator)
		{
			NestedOptions("legend", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public ChartBuilder LoadingIndicator(Action<ChartLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public ChartBuilder Margin(Action<ChartMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Specifies a coefficient determining the diameter of the largest bubble.</summary>
		[Generated]
		public ChartBuilder MaxBubbleSize(double value)
		{
			base.Options["maxBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies a coefficient determining the diameter of the largest bubble.</summary>
		[Generated]
		public ChartBuilder MaxBubbleSize(JS value)
		{
			base.Options["maxBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of the smallest bubble measured in pixels.</summary>
		[Generated]
		public ChartBuilder MinBubbleSize(double value)
		{
			base.Options["minBubbleSize"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of the smallest bubble measured in pixels.</summary>
		[Generated]
		public ChartBuilder MinBubbleSize(JS value)
		{
			base.Options["minBubbleSize"] = value;
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public ChartBuilder NegativesAsZeroes(bool value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>Forces the widget to treat negative values as zeroes. Applies to stacked-like series only.</summary>
		[Generated]
		public ChartBuilder NegativesAsZeroes(JS value)
		{
			base.Options["negativesAsZeroes"] = value;
			return this;
		}

		/// <summary>A function that is executed when a label on the argument axis is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnArgumentAxisClick(string jsFunc)
		{
			AssignJS("onArgumentAxisClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a label on the argument axis is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnArgumentAxisClick(RazorBlock jsFunc)
		{
			return OnArgumentAxisClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ChartBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ChartBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public ChartBuilder OnDone(string jsFunc)
		{
			AssignJS("onDone", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public ChartBuilder OnDone(RazorBlock jsFunc)
		{
			return OnDone(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public ChartBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public ChartBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public ChartBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public ChartBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public ChartBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public ChartBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public ChartBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public ChartBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public ChartBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public ChartBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ChartBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ChartBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnLegendClick(string jsFunc)
		{
			AssignJS("onLegendClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnLegendClick(RazorBlock jsFunc)
		{
			return OnLegendClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ChartBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ChartBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnPointClick(string jsFunc)
		{
			AssignJS("onPointClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnPointClick(RazorBlock jsFunc)
		{
			return OnPointClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public ChartBuilder OnPointHoverChanged(string jsFunc)
		{
			AssignJS("onPointHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public ChartBuilder OnPointHoverChanged(RazorBlock jsFunc)
		{
			return OnPointHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public ChartBuilder OnPointSelectionChanged(string jsFunc)
		{
			AssignJS("onPointSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public ChartBuilder OnPointSelectionChanged(RazorBlock jsFunc)
		{
			return OnPointSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnSeriesClick(string jsFunc)
		{
			AssignJS("onSeriesClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series is clicked or tapped.</summary>
		[Generated]
		public ChartBuilder OnSeriesClick(RazorBlock jsFunc)
		{
			return OnSeriesClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series.</summary>
		[Generated]
		public ChartBuilder OnSeriesHoverChanged(string jsFunc)
		{
			AssignJS("onSeriesHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series.</summary>
		[Generated]
		public ChartBuilder OnSeriesHoverChanged(RazorBlock jsFunc)
		{
			return OnSeriesHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series is selected or selection is canceled.</summary>
		[Generated]
		public ChartBuilder OnSeriesSelectionChanged(string jsFunc)
		{
			AssignJS("onSeriesSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series is selected or selection is canceled.</summary>
		[Generated]
		public ChartBuilder OnSeriesSelectionChanged(RazorBlock jsFunc)
		{
			return OnSeriesSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public ChartBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public ChartBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public ChartBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public ChartBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when zooming or panning ends.</summary>
		[Generated]
		public ChartBuilder OnZoomEnd(string jsFunc)
		{
			AssignJS("onZoomEnd", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when zooming or panning ends.</summary>
		[Generated]
		public ChartBuilder OnZoomEnd(RazorBlock jsFunc)
		{
			return OnZoomEnd(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when zooming or panning begins.</summary>
		[Generated]
		public ChartBuilder OnZoomStart(string jsFunc)
		{
			AssignJS("onZoomStart", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when zooming or panning begins.</summary>
		[Generated]
		public ChartBuilder OnZoomStart(RazorBlock jsFunc)
		{
			return OnZoomStart(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public ChartBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public ChartBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing series and their elements.</summary>
		[Generated]
		public ChartBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of series (in the Chart widget) or points in a series (in the PieChart widget).</summary>
		[Generated]
		public ChartBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Declares a collection of panes.</summary>
		[Generated]
		public ChartBuilder Panes(Action<CollectionFactory<ChartPaneBuilder>> configurator)
		{
			Collection("panes", configurator);
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public ChartBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public ChartBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether a single point or multiple points can be selected in the chart.</summary>
		[Generated]
		public ChartBuilder PointSelectionMode(ChartElementSelectionMode value)
		{
			base.Options["pointSelectionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public ChartBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public ChartBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether panes can be resized if other chart elements require more space after zooming or panning.</summary>
		[Generated]
		public ChartBuilder ResizePanesOnZoom(bool value)
		{
			base.Options["resizePanesOnZoom"] = value;
			return this;
		}

		/// <summary>Specifies whether panes can be resized if other chart elements require more space after zooming or panning.</summary>
		[Generated]
		public ChartBuilder ResizePanesOnZoom(JS value)
		{
			base.Options["resizePanesOnZoom"] = value;
			return this;
		}

		/// <summary>Specifies how the chart must behave when series point labels overlap.</summary>
		[Generated]
		public ChartBuilder ResolveLabelOverlapping(ChartResolveLabelOverlapping value)
		{
			base.Options["resolveLabelOverlapping"] = value;
			return this;
		}

		/// <summary>Swaps the axes around making the value axis horizontal and the argument axis vertical.</summary>
		[Generated]
		public ChartBuilder Rotated(bool value)
		{
			base.Options["rotated"] = value;
			return this;
		}

		/// <summary>Swaps the axes around making the value axis horizontal and the argument axis vertical.</summary>
		[Generated]
		public ChartBuilder Rotated(JS value)
		{
			base.Options["rotated"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ChartBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ChartBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the settings of the scroll bar.</summary>
		[Generated]
		public ChartBuilder ScrollBar(Action<ChartScrollBarBuilder> configurator)
		{
			NestedOptions("scrollBar", configurator);
			return this;
		}

		[Obsolete("Use the zoomAndPan option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder ScrollingMode(ChartPointerType value)
		{
			base.Options["scrollingMode"] = value;
			return this;
		}

		/// <summary>Specifies options for Chart widget series.</summary>
		[Generated]
		public ChartBuilder Series(Action<CollectionFactory<ChartSeriesBuilder>> configurator)
		{
			Collection("series", configurator);
			return this;
		}

		/// <summary>Specifies whether a single series or multiple series can be selected in the chart.</summary>
		[Generated]
		public ChartBuilder SeriesSelectionMode(ChartElementSelectionMode value)
		{
			base.Options["seriesSelectionMode"] = value;
			return this;
		}

		/// <summary>Defines options for the series template.</summary>
		[Generated]
		public ChartBuilder SeriesTemplate(Action<ChartSeriesTemplateBuilder> configurator)
		{
			NestedOptions("seriesTemplate", configurator);
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public ChartBuilder Size(Action<ChartSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies whether a point should remain in the hover state when the mouse pointer moves away.</summary>
		[Generated]
		public ChartBuilder StickyHovering(bool value)
		{
			base.Options["stickyHovering"] = value;
			return this;
		}

		/// <summary>Specifies whether a point should remain in the hover state when the mouse pointer moves away.</summary>
		[Generated]
		public ChartBuilder StickyHovering(JS value)
		{
			base.Options["stickyHovering"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to synchronize value axes when they are displayed on a single pane.</summary>
		[Generated]
		public ChartBuilder SynchronizeMultiAxes(bool value)
		{
			base.Options["synchronizeMultiAxes"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to synchronize value axes when they are displayed on a single pane.</summary>
		[Generated]
		public ChartBuilder SynchronizeMultiAxes(JS value)
		{
			base.Options["synchronizeMultiAxes"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public ChartBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public ChartBuilder Title(Action<ChartTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public ChartBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public ChartBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public ChartBuilder Tooltip(Action<ChartTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		[Obsolete("Use CommonSeries.aggregation.enabled instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder UseAggregation(bool value)
		{
			base.Options["useAggregation"] = value;
			return this;
		}

		[Obsolete("Use CommonSeries.aggregation.enabled instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder UseAggregation(JS value)
		{
			base.Options["useAggregation"] = value;
			return this;
		}

		/// <summary>Configures the value axis.</summary>
		[Generated]
		public ChartBuilder ValueAxis(Action<CollectionFactory<ChartValueAxisBuilder>> configurator)
		{
			Collection("valueAxis", configurator);
			return this;
		}

		/// <summary>Configures zooming and panning.</summary>
		[Generated]
		public ChartBuilder ZoomAndPan(Action<ChartZoomAndPanBuilder> configurator)
		{
			NestedOptions("zoomAndPan", configurator);
			return this;
		}

		[Obsolete("Use the zoomAndPan option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ChartBuilder ZoomingMode(ChartPointerType value)
		{
			base.Options["zoomingMode"] = value;
			return this;
		}
	}
}
