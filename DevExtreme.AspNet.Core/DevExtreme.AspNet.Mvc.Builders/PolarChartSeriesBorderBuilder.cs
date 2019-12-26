namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the series border configuration options.</summary>
	public class PolarChartSeriesBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a series.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a dash style for the borders of series points.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a series.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a series in pixels.</summary>
		[Generated]
		public PolarChartSeriesBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
