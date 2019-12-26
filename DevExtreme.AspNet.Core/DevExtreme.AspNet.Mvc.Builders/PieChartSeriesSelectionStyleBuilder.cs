using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining configuration options for the series when it is selected.</summary>
	public class PieChartSeriesSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>An object defining the border options for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBuilder Border(Action<PieChartSeriesSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a color for a series when it is selected.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the hatching options to be applied when a point is selected.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBuilder Hatching(Action<PieChartSeriesSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
