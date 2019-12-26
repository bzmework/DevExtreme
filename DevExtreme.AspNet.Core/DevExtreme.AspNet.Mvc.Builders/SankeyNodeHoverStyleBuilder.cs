using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance a node changes to when it is hovered over or pressed.</summary>
	public class SankeyNodeHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyNodeHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance a node's border changes to when the node is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Border(Action<SankeyNodeHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color a node changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color a node changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Applies hatching to a node when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Hatching(Action<SankeyNodeHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the transparency a node changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency a node changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyNodeHoverStyleBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
