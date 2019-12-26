using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of all constant lines in the widget.</summary>
	public class ChartCommonAxisSettingsConstantLineStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of constant lines.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of constant lines.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures constant line labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Label(Action<ChartCommonAxisSettingsConstantLineStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom side of a constant line and the constant line label.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of constant lines in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsConstantLineStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
