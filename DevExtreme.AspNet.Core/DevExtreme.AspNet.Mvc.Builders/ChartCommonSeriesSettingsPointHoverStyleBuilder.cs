using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by a series point when a user pauses on it.</summary>
	public class ChartCommonSeriesSettingsPointHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the point border when a user pauses on the point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Border(Action<ChartCommonSeriesSettingsPointHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of series points in the hovered state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of series points in the hovered state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the hovered state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the hovered state.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointHoverStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
