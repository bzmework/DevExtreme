namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies border options for points in the line and area series.</summary>
	public class PolarChartSeriesPointBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartSeriesPointBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for points in the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for points in the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets border visibility for points in the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for points in the line and area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for points in the line or area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for points in the line or area series.</summary>
		[Generated]
		public PolarChartSeriesPointBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
