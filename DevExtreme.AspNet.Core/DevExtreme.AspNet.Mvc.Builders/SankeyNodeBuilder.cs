using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures sankey nodes' appearance.</summary>
	public class SankeyNodeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyNodeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyNodeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the nodes' borders.</summary>
		[Generated]
		public SankeyNodeBuilder Border(Action<SankeyNodeBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the sankey nodes.</summary>
		[Generated]
		public SankeyNodeBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the sankey nodes.</summary>
		[Generated]
		public SankeyNodeBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Configures the appearance a node changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeBuilder HoverStyle(Action<SankeyNodeHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies the nodes' transparency.</summary>
		[Generated]
		public SankeyNodeBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the nodes' transparency.</summary>
		[Generated]
		public SankeyNodeBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the vertical distance, in pixels, between two nodes.</summary>
		[Generated]
		public SankeyNodeBuilder Padding(double value)
		{
			base.Options["padding"] = value;
			return this;
		}

		/// <summary>Specifies the vertical distance, in pixels, between two nodes.</summary>
		[Generated]
		public SankeyNodeBuilder Padding(JS value)
		{
			base.Options["padding"] = value;
			return this;
		}

		/// <summary>Specifies the nodes' width in pixels.</summary>
		[Generated]
		public SankeyNodeBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the nodes' width in pixels.</summary>
		[Generated]
		public SankeyNodeBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
