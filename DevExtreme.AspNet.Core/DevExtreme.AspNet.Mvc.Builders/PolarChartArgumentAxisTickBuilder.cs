namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for axis ticks.</summary>
	public class PolarChartArgumentAxisTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartArgumentAxisTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
