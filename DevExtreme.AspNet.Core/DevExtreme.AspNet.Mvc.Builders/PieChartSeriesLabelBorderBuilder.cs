namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies border options for point labels.</summary>
	public class PieChartSeriesLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Indicates whether or not borders are visible in point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not borders are visible in point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PieChartSeriesLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
