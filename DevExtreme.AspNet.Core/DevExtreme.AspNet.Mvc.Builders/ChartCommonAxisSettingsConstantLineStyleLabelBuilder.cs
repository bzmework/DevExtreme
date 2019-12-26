using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures constant line labels.</summary>
	public class ChartCommonAxisSettingsConstantLineStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for constant line labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the position of constant line labels on the chart plot.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
