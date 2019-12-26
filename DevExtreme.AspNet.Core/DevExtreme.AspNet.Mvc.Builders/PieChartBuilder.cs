using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The PieChart is a widget that visualizes data as a circle divided into sectors that each represents a portion of the whole.</summary>
	public class PieChartBuilder : WidgetBuilder
	{
		[Generated]
		public PieChartBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public PieChartBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public PieChartBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies adaptive layout options.</summary>
		[Generated]
		public PieChartBuilder AdaptiveLayout(Action<PieChartAdaptiveLayoutBuilder> configurator)
		{
			NestedOptions("adaptiveLayout", configurator);
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PieChartBuilder Animation(Action<PieChartAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PieChartBuilder Animation(bool value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public PieChartBuilder Animation(JS value)
		{
			base.Options["animation"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for content in the pie's center.</summary>
		[Generated]
		public PieChartBuilder CenterTemplate(string templateContent)
		{
			AssignTemplate("centerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for content in the pie's center.</summary>
		[Generated]
		public PieChartBuilder CenterTemplate(RazorBlock templateContent)
		{
			AssignTemplate("centerTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for content in the pie's center.</summary>
		[Generated]
		public PieChartBuilder CenterTemplate(TemplateName name)
		{
			AssignTemplate("centerTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for content in the pie's center.</summary>
		[Generated]
		public PieChartBuilder CenterTemplate(JS value)
		{
			base.Options["centerTemplate"] = value;
			return this;
		}

		/// <summary>An object defining the configuration options that are common for all series of the PieChart widget.</summary>
		[Generated]
		public PieChartBuilder CommonSeriesSettings(Action<PieChartCommonSeriesSettingsBuilder> configurator)
		{
			NestedOptions("commonSeriesSettings", configurator);
			return this;
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public PieChartBuilder CustomizeLabel(string jsFunc)
		{
			AssignJS("customizeLabel", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual point label.</summary>
		[Generated]
		public PieChartBuilder CustomizeLabel(RazorBlock jsFunc)
		{
			return CustomizeLabel(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public PieChartBuilder CustomizePoint(string jsFunc)
		{
			AssignJS("customizePoint", jsFunc);
			return this;
		}

		/// <summary>Customizes the appearance of an individual series point.</summary>
		[Generated]
		public PieChartBuilder CustomizePoint(RazorBlock jsFunc)
		{
			return CustomizePoint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PieChartBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PieChartBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PieChartBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PieChartBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PieChartBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the diameter of the pie.</summary>
		[Generated]
		public PieChartBuilder Diameter(double value)
		{
			base.Options["diameter"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of the pie.</summary>
		[Generated]
		public PieChartBuilder Diameter(JS value)
		{
			base.Options["diameter"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public PieChartBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public PieChartBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PieChartBuilder ElementAttr(string attributeName, object value)
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
		public PieChartBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PieChartBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PieChartBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public PieChartBuilder Export(Action<PieChartExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies the fraction of the inner radius relative to the total radius in the series of the 'doughnut' type. The value should be between 0 and 1.</summary>
		[Generated]
		public PieChartBuilder InnerRadius(double value)
		{
			base.Options["innerRadius"] = value;
			return this;
		}

		/// <summary>Specifies the fraction of the inner radius relative to the total radius in the series of the 'doughnut' type. The value should be between 0 and 1.</summary>
		[Generated]
		public PieChartBuilder InnerRadius(JS value)
		{
			base.Options["innerRadius"] = value;
			return this;
		}

		/// <summary>Specifies PieChart legend options.</summary>
		[Generated]
		public PieChartBuilder Legend(Action<PieChartLegendBuilder> configurator)
		{
			NestedOptions("legend", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public PieChartBuilder LoadingIndicator(Action<PieChartLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public PieChartBuilder Margin(Action<PieChartMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Specifies the minimum diameter of the pie.</summary>
		[Generated]
		public PieChartBuilder MinDiameter(double value)
		{
			base.Options["minDiameter"] = value;
			return this;
		}

		/// <summary>Specifies the minimum diameter of the pie.</summary>
		[Generated]
		public PieChartBuilder MinDiameter(JS value)
		{
			base.Options["minDiameter"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PieChartBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PieChartBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public PieChartBuilder OnDone(string jsFunc)
		{
			AssignJS("onDone", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when all series are ready.</summary>
		[Generated]
		public PieChartBuilder OnDone(RazorBlock jsFunc)
		{
			return OnDone(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public PieChartBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public PieChartBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public PieChartBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public PieChartBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public PieChartBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public PieChartBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public PieChartBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public PieChartBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public PieChartBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public PieChartBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PieChartBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PieChartBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public PieChartBuilder OnLegendClick(string jsFunc)
		{
			AssignJS("onLegendClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a legend item is clicked or tapped.</summary>
		[Generated]
		public PieChartBuilder OnLegendClick(RazorBlock jsFunc)
		{
			return OnLegendClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PieChartBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PieChartBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public PieChartBuilder OnPointClick(string jsFunc)
		{
			AssignJS("onPointClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is clicked or tapped.</summary>
		[Generated]
		public PieChartBuilder OnPointClick(RazorBlock jsFunc)
		{
			return OnPointClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public PieChartBuilder OnPointHoverChanged(string jsFunc)
		{
			AssignJS("onPointHoverChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the pointer enters or leaves a series point.</summary>
		[Generated]
		public PieChartBuilder OnPointHoverChanged(RazorBlock jsFunc)
		{
			return OnPointHoverChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public PieChartBuilder OnPointSelectionChanged(string jsFunc)
		{
			AssignJS("onPointSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a series point is selected or selection is canceled.</summary>
		[Generated]
		public PieChartBuilder OnPointSelectionChanged(RazorBlock jsFunc)
		{
			return OnPointSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public PieChartBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public PieChartBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public PieChartBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public PieChartBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used to colorize series and their elements.</summary>
		[Generated]
		public PieChartBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize series and their elements.</summary>
		[Generated]
		public PieChartBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize series and their elements.</summary>
		[Generated]
		public PieChartBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of series (in the Chart widget) or points in a series (in the PieChart widget).</summary>
		[Generated]
		public PieChartBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public PieChartBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public PieChartBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether a single point or multiple points can be selected in the chart.</summary>
		[Generated]
		public PieChartBuilder PointSelectionMode(ChartElementSelectionMode value)
		{
			base.Options["pointSelectionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public PieChartBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public PieChartBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies how a chart must behave when point labels overlap.</summary>
		[Generated]
		public PieChartBuilder ResolveLabelOverlapping(PieChartResolveLabelOverlapping value)
		{
			base.Options["resolveLabelOverlapping"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PieChartBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PieChartBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the direction that the pie chart segments will occupy.</summary>
		[Generated]
		public PieChartBuilder SegmentsDirection(PieChartSegmentsDirection value)
		{
			base.Options["segmentsDirection"] = value;
			return this;
		}

		/// <summary>Specifies options for the series of the PieChart widget.</summary>
		[Generated]
		public PieChartBuilder Series(Action<CollectionFactory<PieChartSeriesBuilder>> configurator)
		{
			Collection("series", configurator);
			return this;
		}

		/// <summary>Defines options for the series template.</summary>
		[Generated]
		public PieChartBuilder SeriesTemplate(Action<PieChartSeriesTemplateBuilder> configurator)
		{
			NestedOptions("seriesTemplate", configurator);
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public PieChartBuilder Size(Action<PieChartSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Allows you to display several adjoining pies in the same size.</summary>
		[Generated]
		public PieChartBuilder SizeGroup(string value)
		{
			base.Options["sizeGroup"] = value;
			return this;
		}

		/// <summary>Allows you to display several adjoining pies in the same size.</summary>
		[Generated]
		public PieChartBuilder SizeGroup(JS value)
		{
			base.Options["sizeGroup"] = value;
			return this;
		}

		/// <summary>Specifies the angle in arc degrees from which the first segment of a pie chart should start.</summary>
		[Generated]
		public PieChartBuilder StartAngle(double value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Specifies the angle in arc degrees from which the first segment of a pie chart should start.</summary>
		[Generated]
		public PieChartBuilder StartAngle(JS value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public PieChartBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PieChartBuilder Title(Action<PieChartTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PieChartBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public PieChartBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public PieChartBuilder Tooltip(Action<PieChartTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies the type of the pie chart series.</summary>
		[Generated]
		public PieChartBuilder Type(PieChartType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
