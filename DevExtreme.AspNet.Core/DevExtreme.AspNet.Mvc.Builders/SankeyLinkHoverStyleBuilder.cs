using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance a link changes to when it is hovered over or pressed.</summary>
	public class SankeyLinkHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLinkHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance a link's border changes to when the link is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Border(Action<SankeyLinkHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color a link changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color a link changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Applies hatching to a link when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Hatching(Action<SankeyLinkHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}

		/// <summary>Specifies the transparency a link changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency a link changes to when it is hovered over or pressed.</summary>
		[Generated]
		public SankeyLinkHoverStyleBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
