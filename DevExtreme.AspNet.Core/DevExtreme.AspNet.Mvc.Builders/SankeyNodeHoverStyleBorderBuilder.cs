namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance a node's border changes to when the node is hovered over or pressed.</summary>
	public class SankeyNodeHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color a node's border changes to when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color a node's border changes to when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether a node's border is visible when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether a node's border is visible when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width a node's border changes to when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width a node's border changes to when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
