using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The BarGauge widget contains several circular bars that each indicates a single value.</summary>
	public class BarGaugeBuilder : WidgetBuilder
	{
		[Generated]
		public BarGaugeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public BarGaugeBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public BarGaugeBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies animation options.</summary>
		[Generated]
		public BarGaugeBuilder Animation(Action<BarGaugeAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>Specifies a color for the remaining segment of the bar's track.</summary>
		[Generated]
		public BarGaugeBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the remaining segment of the bar's track.</summary>
		[Generated]
		public BarGaugeBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies a distance between bars in pixels.</summary>
		[Generated]
		public BarGaugeBuilder BarSpacing(double value)
		{
			base.Options["barSpacing"] = value;
			return this;
		}

		/// <summary>Specifies a distance between bars in pixels.</summary>
		[Generated]
		public BarGaugeBuilder BarSpacing(JS value)
		{
			base.Options["barSpacing"] = value;
			return this;
		}

		/// <summary>Specifies a base value for bars.</summary>
		[Generated]
		public BarGaugeBuilder BaseValue(double value)
		{
			base.Options["baseValue"] = value;
			return this;
		}

		/// <summary>Specifies a base value for bars.</summary>
		[Generated]
		public BarGaugeBuilder BaseValue(JS value)
		{
			base.Options["baseValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public BarGaugeBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public BarGaugeBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BarGaugeBuilder ElementAttr(string attributeName, object value)
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
		public BarGaugeBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BarGaugeBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BarGaugeBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies an end value for the gauge's invisible scale.</summary>
		[Generated]
		public BarGaugeBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for the gauge's invisible scale.</summary>
		[Generated]
		public BarGaugeBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public BarGaugeBuilder Export(Action<BarGaugeExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Defines the shape of the gauge's arc.</summary>
		[Generated]
		public BarGaugeBuilder Geometry(Action<BarGaugeGeometryBuilder> configurator)
		{
			NestedOptions("geometry", configurator);
			return this;
		}

		/// <summary>Specifies the options of the labels that accompany gauge bars.</summary>
		[Generated]
		public BarGaugeBuilder Label(Action<BarGaugeLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Configures the legend.</summary>
		[Generated]
		public BarGaugeBuilder Legend(Action<BarGaugeLegendBuilder> configurator)
		{
			NestedOptions("legend", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public BarGaugeBuilder LoadingIndicator(Action<BarGaugeLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public BarGaugeBuilder Margin(Action<BarGaugeMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public BarGaugeBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public BarGaugeBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public BarGaugeBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public BarGaugeBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public BarGaugeBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public BarGaugeBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public BarGaugeBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public BarGaugeBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public BarGaugeBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public BarGaugeBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public BarGaugeBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public BarGaugeBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public BarGaugeBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public BarGaugeBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public BarGaugeBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public BarGaugeBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public BarGaugeBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public BarGaugeBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public BarGaugeBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public BarGaugeBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Sets the palette to be used for colorizing bars in the gauge.</summary>
		[Generated]
		public BarGaugeBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing bars in the gauge.</summary>
		[Generated]
		public BarGaugeBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used for colorizing bars in the gauge.</summary>
		[Generated]
		public BarGaugeBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of bars in the gauge.</summary>
		[Generated]
		public BarGaugeBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public BarGaugeBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public BarGaugeBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public BarGaugeBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public BarGaugeBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Defines the radius of the bar that is closest to the center relatively to the radius of the topmost bar.</summary>
		[Generated]
		public BarGaugeBuilder RelativeInnerRadius(double value)
		{
			base.Options["relativeInnerRadius"] = value;
			return this;
		}

		/// <summary>Defines the radius of the bar that is closest to the center relatively to the radius of the topmost bar.</summary>
		[Generated]
		public BarGaugeBuilder RelativeInnerRadius(JS value)
		{
			base.Options["relativeInnerRadius"] = value;
			return this;
		}

		/// <summary>Specifies how the widget should behave when bar labels overlap: hide certain labels or leave them overlapped.</summary>
		[Generated]
		public BarGaugeBuilder ResolveLabelOverlapping(BarGaugeResolveLabelOverlapping value)
		{
			base.Options["resolveLabelOverlapping"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public BarGaugeBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public BarGaugeBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public BarGaugeBuilder Size(Action<BarGaugeSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies a start value for the gauge's invisible scale.</summary>
		[Generated]
		public BarGaugeBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for the gauge's invisible scale.</summary>
		[Generated]
		public BarGaugeBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public BarGaugeBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public BarGaugeBuilder Title(Action<BarGaugeTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public BarGaugeBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public BarGaugeBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures tooltips.</summary>
		[Generated]
		public BarGaugeBuilder Tooltip(Action<BarGaugeTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies the array of values to be indicated on a bar gauge.</summary>
		[Generated]
		public BarGaugeBuilder Values(IEnumerable<double> value)
		{
			base.Options["values"] = value;
			return this;
		}

		/// <summary>Specifies the array of values to be indicated on a bar gauge.</summary>
		[Generated]
		public BarGaugeBuilder Values(JS value)
		{
			base.Options["values"] = value;
			return this;
		}
	}
}
