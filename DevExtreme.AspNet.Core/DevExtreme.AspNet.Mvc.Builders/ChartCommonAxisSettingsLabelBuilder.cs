using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures axis labels.</summary>
	public class ChartCommonAxisSettingsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns axis labels in relation to ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Allows you to rotate or stagger axis labels. Applies to the horizontal axis only.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder DisplayMode(ChartLabelDisplayMode value)
		{
			base.Options["displayMode"] = value;
			return this;
		}

		/// <summary>Specifies font options for axis labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between an axis and its labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder IndentFromAxis(double value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between an axis and its labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder IndentFromAxis(JS value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Decides how to arrange axis labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder OverlappingBehavior(OverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Specifies the rotation angle of axis labels. Applies only if displayMode or overlappingBehavior is "rotate".</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder RotationAngle(double value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Specifies the rotation angle of axis labels. Applies only if displayMode or overlappingBehavior is "rotate".</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder RotationAngle(JS value)
		{
			base.Options["rotationAngle"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two staggered rows of axis labels. Applies only if displayMode or overlappingBehavior is "stagger".</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder StaggeringSpacing(double value)
		{
			base.Options["staggeringSpacing"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between two staggered rows of axis labels. Applies only if displayMode or overlappingBehavior is "stagger".</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder StaggeringSpacing(JS value)
		{
			base.Options["staggeringSpacing"] = value;
			return this;
		}

		/// <summary>Specifies what to do with axis labels that overflow the allocated space after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Shows/hides axis labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows/hides axis labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap texts that do not fit into a single line.</summary>
		[Generated]
		public ChartCommonAxisSettingsLabelBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
