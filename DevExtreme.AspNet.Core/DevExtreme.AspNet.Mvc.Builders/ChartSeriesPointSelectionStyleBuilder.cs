using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of a selected series point.</summary>
	public class ChartSeriesPointSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the border of a selected point.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Border(Action<ChartSeriesPointSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of series points in the selected state.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of series points in the selected state.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the selected state.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the selected state.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
