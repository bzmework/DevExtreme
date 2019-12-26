using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for argument axis labels.</summary>
	public class PolarChartArgumentAxisLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a label on the argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the text for a hint that appears when a user hovers the mouse pointer over a label on the argument axis.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by argument axis labels.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns the text to be displayed by argument axis labels.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies font options for axis labels.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder IndentFromAxis(double value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder IndentFromAxis(JS value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Decides how to arrange axis labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder OverlappingBehavior(PolarChartOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartArgumentAxisLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
