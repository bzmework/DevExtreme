using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures sankey links' appearance.</summary>
	public class SankeyLinkBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLinkBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLinkBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the links' borders.</summary>
		[Generated]
		public SankeyLinkBuilder Border(Action<SankeyLinkBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the sankey links. Applies only if colorMode is "none".</summary>
		[Generated]
		public SankeyLinkBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the sankey links. Applies only if colorMode is "none".</summary>
		[Generated]
		public SankeyLinkBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how to color links.</summary>
		[Generated]
		public SankeyLinkBuilder ColorMode(SankeyColorMode value)
		{
			base.Options["colorMode"] = value;
			return this;
		}

		/// <summary>Configures the appearance a link changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkBuilder HoverStyle(Action<SankeyLinkHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Specifies the links' transparency.</summary>
		[Generated]
		public SankeyLinkBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the links' transparency.</summary>
		[Generated]
		public SankeyLinkBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
