namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies connector options for series point labels.</summary>
	public class PieChartSeriesLabelConnectorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartSeriesLabelConnectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of label connectors.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not label connectors are visible.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of label connectors.</summary>
		[Generated]
		public PieChartSeriesLabelConnectorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
