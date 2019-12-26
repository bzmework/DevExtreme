namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the nodes' borders.</summary>
	public class SankeyNodeBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyNodeBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the nodes' borders.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the nodes' borders.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyNodeBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
