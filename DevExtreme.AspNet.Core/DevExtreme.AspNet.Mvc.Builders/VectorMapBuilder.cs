using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The VectorMap is a widget that visualizes geographical locations. This widget represents a geographical map that contains areas and markers. Areas embody continents and countries. Markers flag specific points on the map, for example, towns, cities or capitals.</summary>
	public class VectorMapBuilder : WidgetBuilder
	{
		[Generated]
		public VectorMapBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public VectorMapBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public VectorMapBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the options for the map background.</summary>
		[Generated]
		public VectorMapBuilder Background(Action<VectorMapBackgroundBuilder> configurator)
		{
			NestedOptions("background", configurator);
			return this;
		}

		/// <summary>Specifies the positioning of a map in geographical coordinates.</summary>
		[Generated]
		public VectorMapBuilder Bounds(IEnumerable<double> value)
		{
			base.Options["bounds"] = value;
			return this;
		}

		/// <summary>Specifies the positioning of a map in geographical coordinates.</summary>
		[Generated]
		public VectorMapBuilder Bounds(JS value)
		{
			base.Options["bounds"] = value;
			return this;
		}

		/// <summary>Specifies the geographical coordinates of the center for a map.</summary>
		[Generated]
		public VectorMapBuilder Center(IEnumerable<double> value)
		{
			base.Options["center"] = value;
			return this;
		}

		/// <summary>Specifies the geographical coordinates of the center for a map.</summary>
		[Generated]
		public VectorMapBuilder Center(JS value)
		{
			base.Options["center"] = value;
			return this;
		}

		/// <summary>Configures the control bar.</summary>
		[Generated]
		public VectorMapBuilder ControlBar(Action<VectorMapControlBarBuilder> configurator)
		{
			NestedOptions("controlBar", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public VectorMapBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public VectorMapBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public VectorMapBuilder ElementAttr(string attributeName, object value)
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
		public VectorMapBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public VectorMapBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public VectorMapBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public VectorMapBuilder Export(Action<VectorMapExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies options for VectorMap widget layers.</summary>
		[Generated]
		public VectorMapBuilder Layers(Action<CollectionFactory<VectorMapLayerBuilder>> configurator)
		{
			Collection("layers", configurator);
			return this;
		}

		/// <summary>Configures map legends.</summary>
		[Generated]
		public VectorMapBuilder Legends(Action<CollectionFactory<VectorMapLegendBuilder>> configurator)
		{
			Collection("legends", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public VectorMapBuilder LoadingIndicator(Action<VectorMapLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Specifies a map's maximum zoom factor.</summary>
		[Generated]
		public VectorMapBuilder MaxZoomFactor(double value)
		{
			base.Options["maxZoomFactor"] = value;
			return this;
		}

		/// <summary>Specifies a map's maximum zoom factor.</summary>
		[Generated]
		public VectorMapBuilder MaxZoomFactor(JS value)
		{
			base.Options["maxZoomFactor"] = value;
			return this;
		}

		/// <summary>A function that is executed each time the center coordinates are changed.</summary>
		[Generated]
		public VectorMapBuilder OnCenterChanged(string jsFunc)
		{
			AssignJS("onCenterChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the center coordinates are changed.</summary>
		[Generated]
		public VectorMapBuilder OnCenterChanged(RazorBlock jsFunc)
		{
			return OnCenterChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when any location on the map is clicked or tapped.</summary>
		[Generated]
		public VectorMapBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when any location on the map is clicked or tapped.</summary>
		[Generated]
		public VectorMapBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public VectorMapBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public VectorMapBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public VectorMapBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public VectorMapBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public VectorMapBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public VectorMapBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public VectorMapBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public VectorMapBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public VectorMapBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public VectorMapBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public VectorMapBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public VectorMapBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public VectorMapBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public VectorMapBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public VectorMapBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public VectorMapBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a layer element is selected or selection is canceled.</summary>
		[Generated]
		public VectorMapBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a layer element is selected or selection is canceled.</summary>
		[Generated]
		public VectorMapBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public VectorMapBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public VectorMapBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public VectorMapBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public VectorMapBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the zoom factor is changed.</summary>
		[Generated]
		public VectorMapBuilder OnZoomFactorChanged(string jsFunc)
		{
			AssignJS("onZoomFactorChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the zoom factor is changed.</summary>
		[Generated]
		public VectorMapBuilder OnZoomFactorChanged(RazorBlock jsFunc)
		{
			return OnZoomFactorChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Disables the panning capability.</summary>
		[Generated]
		public VectorMapBuilder PanningEnabled(bool value)
		{
			base.Options["panningEnabled"] = value;
			return this;
		}

		/// <summary>Disables the panning capability.</summary>
		[Generated]
		public VectorMapBuilder PanningEnabled(JS value)
		{
			base.Options["panningEnabled"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public VectorMapBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public VectorMapBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies the map projection.</summary>
		[Generated]
		public VectorMapBuilder Projection(VectorMapProjection value)
		{
			base.Options["projection"] = value;
			return this;
		}

		/// <summary>Specifies the map projection.</summary>
		[Generated]
		public VectorMapBuilder Projection(string value)
		{
			base.Options["projection"] = value;
			return this;
		}

		/// <summary>Specifies the map projection.</summary>
		[Generated]
		public VectorMapBuilder Projection(JS value)
		{
			base.Options["projection"] = value;
			return this;
		}

		/// <summary>Specifies the map projection.</summary>
		[Generated]
		public VectorMapBuilder Projection(Action<VectorMapProjectionConfigBuilder> configurator)
		{
			NestedOptions("projection", configurator);
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public VectorMapBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public VectorMapBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public VectorMapBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public VectorMapBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public VectorMapBuilder Size(Action<VectorMapSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public VectorMapBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public VectorMapBuilder Title(Action<VectorMapTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public VectorMapBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public VectorMapBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public VectorMapBuilder Tooltip(Action<VectorMapTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies whether the map should respond to touch gestures.</summary>
		[Generated]
		public VectorMapBuilder TouchEnabled(bool value)
		{
			base.Options["touchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the map should respond to touch gestures.</summary>
		[Generated]
		public VectorMapBuilder TouchEnabled(JS value)
		{
			base.Options["touchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the map should respond when a user rolls the mouse wheel.</summary>
		[Generated]
		public VectorMapBuilder WheelEnabled(bool value)
		{
			base.Options["wheelEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the map should respond when a user rolls the mouse wheel.</summary>
		[Generated]
		public VectorMapBuilder WheelEnabled(JS value)
		{
			base.Options["wheelEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a number that is used to zoom a map initially.</summary>
		[Generated]
		public VectorMapBuilder ZoomFactor(double value)
		{
			base.Options["zoomFactor"] = value;
			return this;
		}

		/// <summary>Specifies a number that is used to zoom a map initially.</summary>
		[Generated]
		public VectorMapBuilder ZoomFactor(JS value)
		{
			base.Options["zoomFactor"] = value;
			return this;
		}

		/// <summary>Disables the zooming capability.</summary>
		[Generated]
		public VectorMapBuilder ZoomingEnabled(bool value)
		{
			base.Options["zoomingEnabled"] = value;
			return this;
		}

		/// <summary>Disables the zooming capability.</summary>
		[Generated]
		public VectorMapBuilder ZoomingEnabled(JS value)
		{
			base.Options["zoomingEnabled"] = value;
			return this;
		}
	}
}
