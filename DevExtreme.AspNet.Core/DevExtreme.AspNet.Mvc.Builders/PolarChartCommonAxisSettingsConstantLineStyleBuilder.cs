using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of all the widget's constant lines.</summary>
	public class PolarChartCommonAxisSettingsConstantLineStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for a constant line.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for a constant line.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for a constant line.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>An object defining constant line label options.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Label(Action<PolarChartCommonAxisSettingsConstantLineStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a constant line width in pixels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a constant line width in pixels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsConstantLineStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
