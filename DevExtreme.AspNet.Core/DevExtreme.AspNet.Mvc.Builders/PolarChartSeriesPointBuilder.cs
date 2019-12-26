using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for points in line and area series.</summary>
	public class PolarChartSeriesPointBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies border options for points in the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Border(Action<PolarChartSeriesPointBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the points color.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the points color.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies what series points to highlight when a point is hovered over.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder HoverMode(ChartPointInteractionMode value)
		{
			base.Options["hoverMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a hovered point.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder HoverStyle(Action<PolarChartSeriesPointHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Image(Action<PolarChartSeriesPointImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Specifies what series points to highlight when a point is selected.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder SelectionMode(ChartPointInteractionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>An object defining configuration options for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder SelectionStyle(Action<PolarChartSeriesPointSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}

		/// <summary>Specifies the point diameter in pixels for those series that represent data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the point diameter in pixels for those series that represent data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies a symbol for presenting points of the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Symbol(VizPointSymbol value)
		{
			base.Options["symbol"] = value;
			return this;
		}

		/// <summary>Specifies the points visibility for a line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the points visibility for a line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
