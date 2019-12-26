namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the label borders.</summary>
	public class FunnelLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the label borders.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the label borders.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets the label border dash style.</summary>
		[Generated]
		public FunnelLabelBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows the label borders.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the label borders.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the label border width.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the label border width.</summary>
		[Generated]
		public FunnelLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
