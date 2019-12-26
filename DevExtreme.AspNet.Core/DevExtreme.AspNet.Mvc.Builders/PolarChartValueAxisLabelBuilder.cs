using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for value axis labels.</summary>
	public class PolarChartValueAxisLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a label on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a label on the value axis.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in value axis labels.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed in value axis labels.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for axis labels.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder IndentFromAxis(double value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder IndentFromAxis(JS value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Decides how to arrange axis labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder OverlappingBehavior(PolarChartOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartValueAxisLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
