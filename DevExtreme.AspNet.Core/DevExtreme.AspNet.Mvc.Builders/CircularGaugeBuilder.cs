using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The CircularGauge is a widget that indicates values on a circular numeric scale.</summary>
	public class CircularGaugeBuilder : WidgetBuilder
	{
		[Generated]
		public CircularGaugeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public CircularGaugeBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public CircularGaugeBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public CircularGaugeBuilder Animation(Action<CircularGaugeAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public CircularGaugeBuilder ContainerBackgroundColor(string value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public CircularGaugeBuilder ContainerBackgroundColor(JS value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public CircularGaugeBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public CircularGaugeBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CircularGaugeBuilder ElementAttr(string attributeName, object value)
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
		public CircularGaugeBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CircularGaugeBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public CircularGaugeBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public CircularGaugeBuilder Export(Action<CircularGaugeExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies the options required to set the geometry of the CircularGauge widget.</summary>
		[Generated]
		public CircularGaugeBuilder Geometry(Action<CircularGaugeGeometryBuilder> configurator)
		{
			NestedOptions("geometry", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public CircularGaugeBuilder LoadingIndicator(Action<CircularGaugeLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public CircularGaugeBuilder Margin(Action<CircularGaugeMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public CircularGaugeBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public CircularGaugeBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public CircularGaugeBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public CircularGaugeBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public CircularGaugeBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public CircularGaugeBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public CircularGaugeBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public CircularGaugeBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public CircularGaugeBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public CircularGaugeBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public CircularGaugeBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public CircularGaugeBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public CircularGaugeBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public CircularGaugeBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public CircularGaugeBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public CircularGaugeBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public CircularGaugeBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public CircularGaugeBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public CircularGaugeBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public CircularGaugeBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public CircularGaugeBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public CircularGaugeBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies gauge range container options.</summary>
		[Generated]
		public CircularGaugeBuilder RangeContainer(Action<CircularGaugeRangeContainerBuilder> configurator)
		{
			NestedOptions("rangeContainer", configurator);
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public CircularGaugeBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public CircularGaugeBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public CircularGaugeBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public CircularGaugeBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a gauge's scale options.</summary>
		[Generated]
		public CircularGaugeBuilder Scale(Action<CircularGaugeScaleBuilder> configurator)
		{
			NestedOptions("scale", configurator);
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public CircularGaugeBuilder Size(Action<CircularGaugeSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies the appearance options of subvalue indicators.</summary>
		[Generated]
		public CircularGaugeBuilder SubvalueIndicator(Action<GaugeIndicatorBuilder> configurator)
		{
			NestedOptions("subvalueIndicator", configurator);
			return this;
		}

		/// <summary>Specifies a set of subvalues to be designated by the subvalue indicators.</summary>
		[Generated]
		public CircularGaugeBuilder Subvalues(IEnumerable<double> value)
		{
			base.Options["subvalues"] = value;
			return this;
		}

		/// <summary>Specifies a set of subvalues to be designated by the subvalue indicators.</summary>
		[Generated]
		public CircularGaugeBuilder Subvalues(JS value)
		{
			base.Options["subvalues"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public CircularGaugeBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public CircularGaugeBuilder Title(Action<CircularGaugeTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public CircularGaugeBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public CircularGaugeBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public CircularGaugeBuilder Tooltip(Action<CircularGaugeTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies the main value on a gauge.</summary>
		[Generated]
		public CircularGaugeBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the main value on a gauge.</summary>
		[Generated]
		public CircularGaugeBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the appearance options of the value indicator.</summary>
		[Generated]
		public CircularGaugeBuilder ValueIndicator(Action<GaugeIndicatorBuilder> configurator)
		{
			NestedOptions("valueIndicator", configurator);
			return this;
		}
	}
}
