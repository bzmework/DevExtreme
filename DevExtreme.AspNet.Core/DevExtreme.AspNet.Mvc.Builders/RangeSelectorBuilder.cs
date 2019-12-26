using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The RangeSelector is a widget that allows a user to select a range of values on a scale.</summary>
	public class RangeSelectorBuilder : WidgetBuilder
	{
		[Generated]
		public RangeSelectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public RangeSelectorBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public RangeSelectorBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the options for the range selector's background.</summary>
		[Generated]
		public RangeSelectorBuilder Background(Action<RangeSelectorBackgroundBuilder> configurator)
		{
			NestedOptions("background", configurator);
			return this;
		}

		/// <summary>Specifies the RangeSelector's behavior options.</summary>
		[Generated]
		public RangeSelectorBuilder Behavior(Action<RangeSelectorBehaviorBuilder> configurator)
		{
			NestedOptions("behavior", configurator);
			return this;
		}

		/// <summary>Specifies the options required to display a chart as the range selector's background.</summary>
		[Generated]
		public RangeSelectorBuilder Chart(Action<RangeSelectorChartBuilder> configurator)
		{
			NestedOptions("chart", configurator);
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public RangeSelectorBuilder ContainerBackgroundColor(string value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the parent page element.</summary>
		[Generated]
		public RangeSelectorBuilder ContainerBackgroundColor(JS value)
		{
			base.Options["containerBackgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies a data source for the scale values and for the chart at the background.</summary>
		[Generated]
		public RangeSelectorBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies a data source for the scale values and for the chart at the background.</summary>
		[Generated]
		public RangeSelectorBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Specifies a data source for the scale values and for the chart at the background.</summary>
		[Generated]
		public RangeSelectorBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Specifies a data source for the scale values and for the chart at the background.</summary>
		[Generated]
		public RangeSelectorBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Specifies a data source for the scale values and for the chart at the background.</summary>
		[Generated]
		public RangeSelectorBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies the data source field that provides data for the scale.</summary>
		[Generated]
		public RangeSelectorBuilder DataSourceField(string value)
		{
			base.Options["dataSourceField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides data for the scale.</summary>
		[Generated]
		public RangeSelectorBuilder DataSourceField(JS value)
		{
			base.Options["dataSourceField"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public RangeSelectorBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public RangeSelectorBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSelectorBuilder ElementAttr(string attributeName, object value)
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
		public RangeSelectorBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSelectorBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public RangeSelectorBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures the exporting and printing features.</summary>
		[Generated]
		public RangeSelectorBuilder Export(Action<RangeSelectorExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Range selector's indent options.</summary>
		[Generated]
		public RangeSelectorBuilder Indent(Action<RangeSelectorIndentBuilder> configurator)
		{
			NestedOptions("indent", configurator);
			return this;
		}

		/// <summary>Configures the loading indicator.</summary>
		[Generated]
		public RangeSelectorBuilder LoadingIndicator(Action<RangeSelectorLoadingIndicatorBuilder> configurator)
		{
			NestedOptions("loadingIndicator", configurator);
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public RangeSelectorBuilder Margin(Action<RangeSelectorMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public RangeSelectorBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public RangeSelectorBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public RangeSelectorBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public RangeSelectorBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public RangeSelectorBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public RangeSelectorBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public RangeSelectorBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public RangeSelectorBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public RangeSelectorBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public RangeSelectorBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public RangeSelectorBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public RangeSelectorBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public RangeSelectorBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public RangeSelectorBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public RangeSelectorBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public RangeSelectorBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public RangeSelectorBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public RangeSelectorBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public RangeSelectorBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public RangeSelectorBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public RangeSelectorBuilder RedrawOnResize(bool value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Specifies whether to redraw the widget when the size of the parent browser window changes or a mobile device rotates.</summary>
		[Generated]
		public RangeSelectorBuilder RedrawOnResize(JS value)
		{
			base.Options["redrawOnResize"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public RangeSelectorBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public RangeSelectorBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies options of the range selector's scale.</summary>
		[Generated]
		public RangeSelectorBuilder Scale(Action<RangeSelectorScaleBuilder> configurator)
		{
			NestedOptions("scale", configurator);
			return this;
		}

		/// <summary>Specifies the color of the selected range.</summary>
		[Generated]
		public RangeSelectorBuilder SelectedRangeColor(string value)
		{
			base.Options["selectedRangeColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the selected range.</summary>
		[Generated]
		public RangeSelectorBuilder SelectedRangeColor(JS value)
		{
			base.Options["selectedRangeColor"] = value;
			return this;
		}

		/// <summary>Specifies how the selected range should behave when data is updated. Applies only when the RangeSelector is bound to a data source.</summary>
		[Generated]
		public RangeSelectorBuilder SelectedRangeUpdateMode(VisualRangeUpdateMode value)
		{
			base.Options["selectedRangeUpdateMode"] = value;
			return this;
		}

		/// <summary>Specifies range selector shutter options.</summary>
		[Generated]
		public RangeSelectorBuilder Shutter(Action<RangeSelectorShutterBuilder> configurator)
		{
			NestedOptions("shutter", configurator);
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public RangeSelectorBuilder Size(Action<RangeSelectorSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of the range selector's slider handles.</summary>
		[Generated]
		public RangeSelectorBuilder SliderHandle(Action<RangeSelectorSliderHandleBuilder> configurator)
		{
			NestedOptions("sliderHandle", configurator);
			return this;
		}

		/// <summary>Defines the options of the range selector slider markers.</summary>
		[Generated]
		public RangeSelectorBuilder SliderMarker(Action<RangeSelectorSliderMarkerBuilder> configurator)
		{
			NestedOptions("sliderMarker", configurator);
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public RangeSelectorBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public RangeSelectorBuilder Title(Action<RangeSelectorTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public RangeSelectorBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Configures the widget's title.</summary>
		[Generated]
		public RangeSelectorBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>The selected range (initial or current). Equals the entire scale when not set.</summary>
		[Generated]
		public RangeSelectorBuilder Value(IEnumerable<DateTime> value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>The selected range (initial or current). Equals the entire scale when not set.</summary>
		[Generated]
		public RangeSelectorBuilder Value(IEnumerable<double> value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>The selected range (initial or current). Equals the entire scale when not set.</summary>
		[Generated]
		public RangeSelectorBuilder Value(IEnumerable<string> value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>The selected range (initial or current). Equals the entire scale when not set.</summary>
		[Generated]
		public RangeSelectorBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>The selected range (initial or current). Equals the entire scale when not set.</summary>
		[Generated]
		public RangeSelectorBuilder Value(Action<VizRangeBuilder> configurator)
		{
			NestedOptions("value", configurator);
			return this;
		}
	}
}
