namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the label connectors.</summary>
	public class ChartCommonSeriesSettingsLabelConnectorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the connectors.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the connectors.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the connectors visible. Applies only if label.visible is set to true.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the connectors visible. Applies only if label.visible is set to true.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the connectors in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the connectors in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelConnectorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
