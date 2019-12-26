namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for axis ticks.</summary>
	public class PolarChartCommonAxisSettingsTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies ticks color.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick length.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tick opacity.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not ticks are visible on an axis.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies tick width.</summary>
		[Generated]
		public PolarChartCommonAxisSettingsTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
