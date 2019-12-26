namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the minor ticks.</summary>
	public class PolarChartValueAxisMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartValueAxisMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
