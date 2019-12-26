namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for axis ticks.</summary>
	public class PolarChartValueAxisTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartValueAxisTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
