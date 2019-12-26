using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of a selected series point.</summary>
	public class ChartCommonSeriesSettingsPointSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the border of a selected point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Border(Action<ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of series points in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of series points in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the selected state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
