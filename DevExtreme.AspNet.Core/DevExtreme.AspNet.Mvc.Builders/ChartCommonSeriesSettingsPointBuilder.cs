using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures series points in scatter, line- and area-like series.</summary>
	public class ChartCommonSeriesSettingsPointBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the series point border in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Border(Action<ChartCommonSeriesSettingsPointBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series points.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user pauses on a series point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder HoverMode(ChartPointInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by a series point when a user pauses on it.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder HoverStyle(Action<ChartCommonSeriesSettingsPointHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Image(Action<ChartCommonSeriesSettingsPointImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user selects a series point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder SelectionMode(ChartPointInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance of a selected series point.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder SelectionStyle(Action<ChartCommonSeriesSettingsPointSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies the diameter of series points in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of series points in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies which symbol should represent series points in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Symbol(PointSymbol value)
		{
			base.Options["symbol"] = value;
			return this;
		}

		/// <summary>Makes the series points visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the series points visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
