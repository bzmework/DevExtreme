namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the links' borders.</summary>
	public class SankeyLinkBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLinkBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the links' borders.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the links' borders.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the borders are visible.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets the borders' width in pixels.</summary>
		[Generated]
		public SankeyLinkBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
