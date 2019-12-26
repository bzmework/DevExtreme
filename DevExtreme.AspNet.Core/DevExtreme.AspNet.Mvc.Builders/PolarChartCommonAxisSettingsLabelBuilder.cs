using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the label configuration options that are common for all axes in the PolarChart widget.</summary>
	public class PolarChartCommonAxisSettingsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for axis labels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder IndentFromAxis(double value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between an axis and its labels in pixels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder IndentFromAxis(JS value)
		{
			base.Options["indentFromAxis"] = value;
			return this;
		}

		/// <summary>Decides how to arrange axis labels when there is not enough space to keep all of them.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder OverlappingBehavior(PolarChartOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not axis labels are visible.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
