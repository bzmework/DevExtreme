namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance a link's border changes to when the link is hovered over or pressed.</summary>
	public class SankeyLinkHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color a link's border changes to when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color a link's border changes to when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether a link's border is visible when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether a link's border is visible when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width a link's border changes to when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width a link's border changes to when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
