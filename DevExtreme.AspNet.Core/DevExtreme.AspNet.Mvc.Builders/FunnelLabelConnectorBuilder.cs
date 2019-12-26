namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures label connectors.</summary>
	public class FunnelLabelConnectorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLabelConnectorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shows label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows label connectors.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the label connector width in pixels.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the label connector width in pixels.</summary>
		[Generated]
		public FunnelLabelConnectorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
