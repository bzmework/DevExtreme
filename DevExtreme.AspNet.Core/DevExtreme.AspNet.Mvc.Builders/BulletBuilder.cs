using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Bullet widget is useful when you need to compare a single measure to a target value. The widget comprises a horizontal bar indicating the measure and a vertical line indicating the target value.</summary>
	public class BulletBuilder : WidgetBuilder
	{
		[Generated]
		public BulletBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public BulletBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public BulletBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BulletBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the bullet bar.</summary>
		[Generated]
		public BulletBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the bullet bar.</summary>
		[Generated]
		public BulletBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public BulletBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to the user interaction.</summary>
		[Generated]
		public BulletBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BulletBuilder ElementAttr(string attributeName, object value)
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
		public BulletBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BulletBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public BulletBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies an end value for the invisible scale.</summary>
		[Generated]
		public BulletBuilder EndScaleValue(double value)
		{
			base.Options["endScaleValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value for the invisible scale.</summary>
		[Generated]
		public BulletBuilder EndScaleValue(JS value)
		{
			base.Options["endScaleValue"] = value;
			return this;
		}

		/// <summary>Generates space around the widget.</summary>
		[Generated]
		public BulletBuilder Margin(Action<BulletMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public BulletBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public BulletBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public BulletBuilder OnDrawn(string jsFunc)
		{
			AssignJS("onDrawn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's rendering has finished.</summary>
		[Generated]
		public BulletBuilder OnDrawn(RazorBlock jsFunc)
		{
			return OnDrawn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public BulletBuilder OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget is exported.</summary>
		[Generated]
		public BulletBuilder OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public BulletBuilder OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is exported.</summary>
		[Generated]
		public BulletBuilder OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public BulletBuilder OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported widget is saved to the user's local storage.</summary>
		[Generated]
		public BulletBuilder OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public BulletBuilder OnIncidentOccurred(string jsFunc)
		{
			AssignJS("onIncidentOccurred", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an error or warning occurs.</summary>
		[Generated]
		public BulletBuilder OnIncidentOccurred(RazorBlock jsFunc)
		{
			return OnIncidentOccurred(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public BulletBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public BulletBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public BulletBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public BulletBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public BulletBuilder OnTooltipHidden(string jsFunc)
		{
			AssignJS("onTooltipHidden", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip becomes hidden.</summary>
		[Generated]
		public BulletBuilder OnTooltipHidden(RazorBlock jsFunc)
		{
			return OnTooltipHidden(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public BulletBuilder OnTooltipShown(string jsFunc)
		{
			AssignJS("onTooltipShown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a tooltip appears.</summary>
		[Generated]
		public BulletBuilder OnTooltipShown(RazorBlock jsFunc)
		{
			return OnTooltipShown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public BulletBuilder PathModified(bool value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Notifies the widget that it is embedded into an HTML page that uses a tag modifying the path.</summary>
		[Generated]
		public BulletBuilder PathModified(JS value)
		{
			base.Options["pathModified"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public BulletBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public BulletBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the target line.</summary>
		[Generated]
		public BulletBuilder ShowTarget(bool value)
		{
			base.Options["showTarget"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the target line.</summary>
		[Generated]
		public BulletBuilder ShowTarget(JS value)
		{
			base.Options["showTarget"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the line indicating zero on the invisible scale.</summary>
		[Generated]
		public BulletBuilder ShowZeroLevel(bool value)
		{
			base.Options["showZeroLevel"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show the line indicating zero on the invisible scale.</summary>
		[Generated]
		public BulletBuilder ShowZeroLevel(JS value)
		{
			base.Options["showZeroLevel"] = value;
			return this;
		}

		/// <summary>Specifies the widget's size in pixels.</summary>
		[Generated]
		public BulletBuilder Size(Action<BulletSizeBuilder> configurator)
		{
			NestedOptions("size", configurator);
			return this;
		}

		/// <summary>Specifies a start value for the invisible scale.</summary>
		[Generated]
		public BulletBuilder StartScaleValue(double value)
		{
			base.Options["startScaleValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value for the invisible scale.</summary>
		[Generated]
		public BulletBuilder StartScaleValue(JS value)
		{
			base.Options["startScaleValue"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by the target line.</summary>
		[Generated]
		public BulletBuilder Target(double value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>Specifies the value indicated by the target line.</summary>
		[Generated]
		public BulletBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>Specifies a color for both the target and zero level lines.</summary>
		[Generated]
		public BulletBuilder TargetColor(string value)
		{
			base.Options["targetColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for both the target and zero level lines.</summary>
		[Generated]
		public BulletBuilder TargetColor(JS value)
		{
			base.Options["targetColor"] = value;
			return this;
		}

		/// <summary>Specifies the width of the target line.</summary>
		[Generated]
		public BulletBuilder TargetWidth(double value)
		{
			base.Options["targetWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the target line.</summary>
		[Generated]
		public BulletBuilder TargetWidth(JS value)
		{
			base.Options["targetWidth"] = value;
			return this;
		}

		/// <summary>Sets the name of the theme the widget uses.</summary>
		[Generated]
		public BulletBuilder Theme(VizTheme value)
		{
			base.Options["theme"] = value;
			return this;
		}

		/// <summary>Configures the tooltip.</summary>
		[Generated]
		public BulletBuilder Tooltip(Action<BulletTooltipBuilder> configurator)
		{
			NestedOptions("tooltip", configurator);
			return this;
		}

		/// <summary>Specifies the primary value indicated by the bullet bar.</summary>
		[Generated]
		public BulletBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the primary value indicated by the bullet bar.</summary>
		[Generated]
		public BulletBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}
	}
}
