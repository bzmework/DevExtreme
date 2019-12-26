namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a selected series.</summary>
	public class PieChartSeriesSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the border of a selected series point.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets a border visibility for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border visibility for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a selected series.</summary>
		[Generated]
		public PieChartSeriesSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
