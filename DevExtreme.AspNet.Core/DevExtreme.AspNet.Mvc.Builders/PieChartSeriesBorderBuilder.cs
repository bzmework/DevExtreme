namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the series border configuration options.</summary>
	public class PieChartSeriesBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the border of a series point.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PieChartSeriesBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
