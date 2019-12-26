using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the labels of the argument axis.</summary>
	public class ChartArgumentAxisLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns axis labels in relation to ticks.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies the hint that appears when a user points to an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder CustomizeHint(string jsFunc)
		{
			AssignJS("customizeHint", jsFunc);
			return this;
		}

		/// <summary>Specifies the hint that appears when a user points to an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder CustomizeHint(RazorBlock jsFunc)
		{
			return CustomizeHint(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes the text displayed by axis labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text displayed by axis labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Allows you to rotate or stagger axis labels. Applies to the horizontal axis only.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder DisplayMode(ChartLabelDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies font options for axis labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed in an axis label.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between an axis and its labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder IndentFromAxis(double value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between an axis and its labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder IndentFromAxis(JS value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Decides how to arrange axis labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder OverlappingBehavior(OverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Specifies the rotation angle of axis labels. Applies only if displayMode or overlappingBehavior is "rotate".</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies the rotation angle of axis labels. Applies only if displayMode or overlappingBehavior is "rotate".</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two staggered rows of axis labels. Applies only if displayMode or overlappingBehavior is "stagger".</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder StaggeringSpacing(double value)
		{
			base.Options["staggeringSpacing"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two staggered rows of axis labels. Applies only if displayMode or overlappingBehavior is "stagger".</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder StaggeringSpacing(JS value)
		{
			base.Options["staggeringSpacing"] = value;
			return this;
		}

		/// <summary>Specifies what to do with axis labels that overflow the allocated space after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Shows/hides axis labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows/hides axis labels.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap texts that do not fit into a single line.</summary>
		[Generated]
		public ChartArgumentAxisLabelBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
