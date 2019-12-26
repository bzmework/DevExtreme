using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures series points in scatter, line- and area-like series.</summary>
	public class ChartSeriesPointBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the series point border in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartSeriesPointBuilder Border(Action<ChartSeriesPointBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the series points.</summary>
		[Generated]
		public ChartSeriesPointBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the series points.</summary>
		[Generated]
		public ChartSeriesPointBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user pauses on a series point.</summary>
		[Generated]
		public ChartSeriesPointBuilder HoverMode(ChartPointInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance adopted by a series point when a user pauses on it.</summary>
		[Generated]
		public ChartSeriesPointBuilder HoverStyle(Action<ChartSeriesPointHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartSeriesPointBuilder Image(Action<ChartSeriesPointImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartSeriesPointBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Substitutes the standard point symbols with an image.</summary>
		[Generated]
		public ChartSeriesPointBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Specifies series elements to be highlighted when a user selects a series point.</summary>
		[Generated]
		public ChartSeriesPointBuilder SelectionMode(ChartPointInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance of a selected series point.</summary>
		[Generated]
		public ChartSeriesPointBuilder SelectionStyle(Action<ChartSeriesPointSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies the diameter of series points in pixels.</summary>
		[Generated]
		public ChartSeriesPointBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of series points in pixels.</summary>
		[Generated]
		public ChartSeriesPointBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies which symbol should represent series points in scatter, line- and area-like series.</summary>
		[Generated]
		public ChartSeriesPointBuilder Symbol(PointSymbol value)
		{
			base.Options["symbol"] = value;
			return this;
		}

		/// <summary>Makes the series points visible.</summary>
		[Generated]
		public ChartSeriesPointBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the series points visible.</summary>
		[Generated]
		public ChartSeriesPointBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
