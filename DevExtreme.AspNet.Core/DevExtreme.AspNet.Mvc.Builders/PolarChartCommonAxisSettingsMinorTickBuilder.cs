namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the minor ticks.</summary>
	public class PolarChartCommonAxisSettingsMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the minor ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies minor tick length.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the minor ticks.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the minor ticks are displayed on an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies minor tick width.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
