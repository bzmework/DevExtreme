using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Sparkline widget is a compact chart that contains only one series. Owing to their size, sparklines occupy very little space and can be easily collected in a table or embedded straight in text.</summary>
	public class SparklineBuilder : WidgetBuilder
	{
		[Generated]
		public SparklineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SparklineBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SparklineBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SparklineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for a sparkline.</summary>
		[Generated]
		public SparklineBuilder ArgumentField(string value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides arguments for a sparkline.</summary>
		[Generated]
		public SparklineBuilder ArgumentField(JS value)
		{
			base.Options["argumentField"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating negative values. Available for a sparkline of the bar type only.</summary>
		[Generated]
		public SparklineBuilder BarNegativeColor(string value)
		{
			base.Options["barNegativeColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating negative values. Available for a sparkline of the bar type only.</summary>
		[Generated]
		public SparklineBuilder BarNegativeColor(JS value)
		{
			base.Options["barNegativeColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating positive values. Available for a sparkline of the bar type only.</summary>
		[Generated]
		public SparklineBuilder BarPositiveColor(string value)
		{
			base.Options["barPositiveColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating positive values. Available for a sparkline of the bar type only.</summary>
		[Generated]
		public SparklineBuilder BarPositiveColor(JS value)
		{
			base.Options["barPositiveColor"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SparklineBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SparklineBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SparklineBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SparklineBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SparklineBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public SparklineBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public SparklineBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SparklineBuilder ElementAttr(string attributeName, object value)
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
		public SparklineBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SparklineBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SparklineBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Sets a color for the boundary of both the first and last points on a sparkline.</summary>
		[Generated]
		public SparklineBuilder FirstLastColor(string value)
		{
			base.Options["firstLastColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the boundary of both the first and last points on a sparkline.</summary>
		[Generated]
		public SparklineBuilder FirstLastColor(JS value)
		{
			base.Options["firstLastColor"] = value;
			return this;
		}

		/// <summary>Specifies whether the sparkline should ignore null data points.</summary>
		[Generated]
		public SparklineBuilder IgnoreEmptyPoints(bool value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Specifies whether the sparkline should ignore null data points.</summary>
		[Generated]
		public SparklineBuilder IgnoreEmptyPoints(JS value)
		{
			base.Options["ignoreEmptyPoints"] = value;
			return this;
		}

		/// <summary>Sets a color for a line on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder LineColor(string value)
		{
			base.Options["lineColor"] = value;
			return this;
		}

		/// <summary>Sets a color for a line on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder LineColor(JS value)
		{
			base.Options["lineColor"] = value;
			return this;
		}

		/// <summary>Specifies a width for a line on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder LineWidth(double value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Specifies a width for a line on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder LineWidth(JS value)
		{
			base.Options["lineWidth"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating the values that are less than the winloss threshold. Available for a sparkline of the winloss type only.</summary>
		[Generated]
		public SparklineBuilder LossColor(string value)
		{
			base.Options["lossColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating the values that are less than the winloss threshold. Available for a sparkline of the winloss type only.</summary>
		[Generated]
		public SparklineBuilder LossColor(JS value)
		{
			base.Options["lossColor"] = value;
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public SparklineBuilder Margin(Action<SparklineMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Sets a color for the boundary of the maximum point on a sparkline.</summary>
		[Generated]
		public SparklineBuilder MaxColor(string value)
		{
			base.Options["maxColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the boundary of the maximum point on a sparkline.</summary>
		[Generated]
		public SparklineBuilder MaxColor(JS value)
		{
			base.Options["maxColor"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value of the sparkline's value axis.</summary>
		[Generated]
		public SparklineBuilder MaxValue(double value)
		{
			base.Options["maxValue"] = value;
			return this;
		}

		/// <summary>Specifies the maximum value of the sparkline's value axis.</summary>
		[Generated]
		public SparklineBuilder MaxValue(JS value)
		{
			base.Options["maxValue"] = value;
			return this;
		}

		/// <summary>Sets a color for the boundary of the minimum point on a sparkline.</summary>
		[Generated]
		public SparklineBuilder MinColor(string value)
		{
			base.Options["minColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the boundary of the minimum point on a sparkline.</summary>
		[Generated]
		public SparklineBuilder MinColor(JS value)
		{
			base.Options["minColor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value of the sparkline value axis.</summary>
		[Generated]
		public SparklineBuilder MinValue(double value)
		{
			base.Options["minValue"] = value;
			return this;
		}

		/// <summary>Specifies the minimum value of the sparkline value axis.</summary>
		[Generated]
		public SparklineBuilder MinValue(JS value)
		{
			base.Options["minValue"] = value;
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SparklineBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SparklineBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public SparklineBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public SparklineBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public SparklineBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public SparklineBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public SparklineBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public SparklineBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public SparklineBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public SparklineBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public SparklineBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public SparklineBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SparklineBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SparklineBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SparklineBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SparklineBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public SparklineBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public SparklineBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public SparklineBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public SparklineBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public SparklineBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public SparklineBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Sets a color for points on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder PointColor(string value)
		{
			base.Options["pointColor"] = value;
			return this;
		}

		/// <summary>Sets a color for points on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder PointColor(JS value)
		{
			base.Options["pointColor"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of sparkline points in pixels. Available for the sparklines of line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder PointSize(double value)
		{
			base.Options["pointSize"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of sparkline points in pixels. Available for the sparklines of line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder PointSize(JS value)
		{
			base.Options["pointSize"] = value;
			return this;
		}

		/// <summary>Specifies a symbol to use as a point marker on a sparkline. Available for the sparklines of the line- and area-like types.</summary>
		[Generated]
		public SparklineBuilder PointSymbol(VizPointSymbol value)
		{
			base.Options["pointSymbol"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SparklineBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SparklineBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate both the first and last values on a sparkline.</summary>
		[Generated]
		public SparklineBuilder ShowFirstLast(bool value)
		{
			base.Options["showFirstLast"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate both the first and last values on a sparkline.</summary>
		[Generated]
		public SparklineBuilder ShowFirstLast(JS value)
		{
			base.Options["showFirstLast"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate both the minimum and maximum values on a sparkline.</summary>
		[Generated]
		public SparklineBuilder ShowMinMax(bool value)
		{
			base.Options["showMinMax"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to indicate both the minimum and maximum values on a sparkline.</summary>
		[Generated]
		public SparklineBuilder ShowMinMax(JS value)
		{
			base.Options["showMinMax"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public SparklineBuilder Size(Action<SparklineSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public SparklineBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the tooltip.</summary>
		[Generated]
		public SparklineBuilder Tooltip(Action<SparklineTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Determines the type of a sparkline.</summary>
		[Generated]
		public SparklineBuilder Type(SparklineType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for a sparkline.</summary>
		[Generated]
		public SparklineBuilder ValueField(string value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Specifies the data source field that provides values for a sparkline.</summary>
		[Generated]
		public SparklineBuilder ValueField(JS value)
		{
			base.Options["valueField"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating the values greater than a winloss threshold. Available for a sparkline of the winloss type only.</summary>
		[Generated]
		public SparklineBuilder WinColor(string value)
		{
			base.Options["winColor"] = value;
			return this;
		}

		/// <summary>Sets a color for the bars indicating the values greater than a winloss threshold. Available for a sparkline of the winloss type only.</summary>
		[Generated]
		public SparklineBuilder WinColor(JS value)
		{
			base.Options["winColor"] = value;
			return this;
		}

		/// <summary>Specifies a value that serves as a threshold for the sparkline of the winloss type.</summary>
		[Generated]
		public SparklineBuilder WinlossThreshold(double value)
		{
			base.Options["winlossThreshold"] = value;
			return this;
		}

		/// <summary>Specifies a value that serves as a threshold for the sparkline of the winloss type.</summary>
		[Generated]
		public SparklineBuilder WinlossThreshold(JS value)
		{
			base.Options["winlossThreshold"] = value;
			return this;
		}
	}
}
