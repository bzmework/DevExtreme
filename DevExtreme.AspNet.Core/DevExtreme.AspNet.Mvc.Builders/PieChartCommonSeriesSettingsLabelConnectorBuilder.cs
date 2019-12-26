namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies connector options for series point labels.</summary>
	public class PieChartCommonSeriesSettingsLabelConnectorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PieChartCommonSeriesSettingsLabelConnectorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
