namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a selected point.</summary>
	public class PolarChartSeriesPointSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected point.</summary>
		[Generated]
		public PolarChartSeriesPointSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
