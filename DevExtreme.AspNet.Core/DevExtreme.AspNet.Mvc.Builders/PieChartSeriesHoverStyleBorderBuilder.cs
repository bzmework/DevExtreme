namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a hovered series.</summary>
	public class PieChartSeriesHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for the series when it is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the border of a series point when this point is hovered over.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a hovered series.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a hovered series.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered series.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered series.</summary>
		[Generated]
		public PieChartSeriesHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
