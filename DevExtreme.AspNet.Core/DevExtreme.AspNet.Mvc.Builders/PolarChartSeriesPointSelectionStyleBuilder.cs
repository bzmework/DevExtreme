using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a selected point.</summary>
	public class PolarChartSeriesPointSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Border(Action<PolarChartSeriesPointSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a point when it is selected.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a point when it is selected.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a selected point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the diameter of a selected point in the series that represents data points as symbols (not as bars for instance).</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
