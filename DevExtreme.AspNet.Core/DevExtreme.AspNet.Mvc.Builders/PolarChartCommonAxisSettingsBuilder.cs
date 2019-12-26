using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options that are common for all axes of the PolarChart widget.</summary>
	public class PolarChartCommonAxisSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the axis. When false, the axis contains integer values only.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the line that represents an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the appearance of all the widget's constant lines.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder ConstantLineStyle(Action<PolarChartCommonAxisSettingsConstantLineStyleBuilder> configurator)
		{
			NestedOptions("constantLineStyle", configurator);
			return this;
		}

		/// <summary>Specifies whether ticks/grid lines of a discrete axis are located between labels or cross the labels.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder DiscreteAxisDivisionMode(DiscreteAxisDivisionMode value)
		{
			base.Options["discreteAxisDivisionMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder EndOnTick(bool value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>Specifies whether to force the axis to start and end on ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder EndOnTick(JS value)
		{
			base.Options["endOnTick"] = value;
			return this;
		}

		/// <summary>An object defining the configuration options for the grid lines of an axis in the PolarChart widget.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Grid(Action<PolarChartCommonAxisSettingsGridBuilder> configurator)
		{
			NestedOptions("grid", configurator);
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Inverted(bool value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an axis is inverted.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Inverted(JS value)
		{
			base.Options["inverted"] = value;
			return this;
		}

		/// <summary>An object defining the label configuration options that are common for all axes in the PolarChart widget.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Label(Action<PolarChartCommonAxisSettingsLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies the options of the minor grid.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder MinorGrid(Action<PolarChartCommonAxisSettingsMinorGridBuilder> configurator)
		{
			NestedOptions("minorGrid", configurator);
			return this;
		}

		/// <summary>Specifies the options of the minor ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder MinorTick(Action<PolarChartCommonAxisSettingsMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the line that represents an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for strip style.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder StripStyle(Action<PolarChartCommonAxisSettingsStripStyleBuilder> configurator)
		{
			NestedOptions("stripStyle", configurator);
			return this;
		}

		/// <summary>An object defining the configuration options for axis ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Tick(Action<PolarChartCommonAxisSettingsTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the line that represents an axis in a chart is visible.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the line that represents an axis in the chart.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
