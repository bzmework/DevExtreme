namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies border options for point labels.</summary>
	public class PolarChartSeriesLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a border color for point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Indicates whether borders are visible in point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether borders are visible in point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the border width for point labels.</summary>
		[Generated]
		public PolarChartSeriesLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
