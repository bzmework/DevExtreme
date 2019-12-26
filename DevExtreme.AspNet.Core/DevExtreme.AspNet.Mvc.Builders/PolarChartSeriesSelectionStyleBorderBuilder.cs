namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a selected series.</summary>
	public class PolarChartSeriesSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PolarChartSeriesSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
