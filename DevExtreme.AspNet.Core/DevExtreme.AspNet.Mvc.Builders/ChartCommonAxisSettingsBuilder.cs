using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines common settings for both the argument and value axis in a chart.</summary>
	public class ChartCommonAxisSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Configures the scale breaks' appearance.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder BreakStyle(Action<ChartCommonAxisSettingsBreakStyleBuilder> configurator)
		{
			NestedOptions("breakStyle", configurator);
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the axis line.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Configures the appearance of all constant lines in the widget.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder ConstantLineStyle(Action<ChartCommonAxisSettingsConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks and grid lines should cross axis labels or lie between them. Applies only to the axes of the "discrete" type.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Configures the grid.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Grid(Action<ChartCommonAxisSettingsGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Inverts the axis.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Configures axis labels.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Label(Action<ChartCommonAxisSettingsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MaxValueMargin(double value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the maximum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MaxValueMargin(JS value)
		{
			base.Options["maxValueMargin"] = value;
			return this;
		}

		/// <summary>Configures the minor grid.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MinorGrid(Action<ChartCommonAxisSettingsMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Configures the appearance of minor axis ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MinorTick(Action<ChartCommonAxisSettingsMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MinValueMargin(double value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Controls the empty space between the minimum series points and the axis. Applies only to the axes of the "continuous" and "logarithmic" type.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder MinValueMargin(JS value)
		{
			base.Options["minValueMargin"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the axis line should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the axis.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the appearance of strips.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder StripStyle(Action<ChartCommonAxisSettingsStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>Configures the appearance of major axis ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Tick(Action<ChartCommonAxisSettingsTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Configures axis titles.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Title(Action<ChartCommonAxisSettingsTitleBuilder> configurator)
		{
			NestedOptions("title", configurator);
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder ValueMarginsEnabled(bool value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Adds an empty space between the axis and the minimum and maximum series points.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder ValueMarginsEnabled(JS value)
		{
			base.Options["valueMarginsEnabled"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the axis line visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the axis line in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
