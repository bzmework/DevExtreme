using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for a hovered series.</summary>
	public class PieChartSeriesHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a hovered series.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBuilder Border(Action<PieChartSeriesHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a point is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBuilder Hatching(Action<PieChartSeriesHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
