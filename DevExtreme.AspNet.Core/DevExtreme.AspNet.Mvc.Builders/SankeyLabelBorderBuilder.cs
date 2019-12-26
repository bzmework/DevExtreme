namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the labels' borders.</summary>
	public class SankeyLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the labels' borders.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the labels' borders.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
