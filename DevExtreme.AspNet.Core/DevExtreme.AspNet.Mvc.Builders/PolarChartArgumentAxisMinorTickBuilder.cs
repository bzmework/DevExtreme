namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the minor ticks.</summary>
	public class PolarChartArgumentAxisMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts minor ticks from the reference position.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts minor ticks from the reference position.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
