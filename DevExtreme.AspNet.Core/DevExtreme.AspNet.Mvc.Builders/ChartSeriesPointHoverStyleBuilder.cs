using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance adopted by a series point when a user pauses on it.</summary>
	public class ChartSeriesPointHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the point border when a user pauses on the point.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Border(Action<ChartSeriesPointHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color of series points in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of series points in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specfies the diameter of series points in the hovered state.</summary>
		[Generated]
		public ChartSeriesPointHoverStyleBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}
	}
}
