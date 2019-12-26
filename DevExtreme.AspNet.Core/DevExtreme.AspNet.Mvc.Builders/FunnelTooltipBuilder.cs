using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures tooltips - small pop-up rectangles that display information about a data-visualizing widget element being pressed or hovered over with the mouse pointer.</summary>
	public class FunnelTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public FunnelTooltipBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public FunnelTooltipBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's border.</summary>
		[Generated]
		public FunnelTooltipBuilder Border(Action<FunnelTooltipBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public FunnelTooltipBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public FunnelTooltipBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public FunnelTooltipBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public FunnelTooltipBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public FunnelTooltipBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public FunnelTooltipBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Customizes a specific tooltip's appearance.</summary>
		[Generated]
		public FunnelTooltipBuilder CustomizeTooltip(string jsFunc)
		{
			AssignJS("customizeTooltip", jsFunc);
			return this;
		}

		/// <summary>Customizes a specific tooltip's appearance.</summary>
		[Generated]
		public FunnelTooltipBuilder CustomizeTooltip(RazorBlock jsFunc)
		{
			return CustomizeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public FunnelTooltipBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public FunnelTooltipBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' font options.</summary>
		[Generated]
		public FunnelTooltipBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public FunnelTooltipBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public FunnelTooltipBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public FunnelTooltipBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public FunnelTooltipBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public FunnelTooltipBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public FunnelTooltipBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public FunnelTooltipBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's shadow.</summary>
		[Generated]
		public FunnelTooltipBuilder Shadow(Action<FunnelTooltipShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public FunnelTooltipBuilder ZIndex(int value)
		{
			base.Options["zIndex"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public FunnelTooltipBuilder ZIndex(JS value)
		{
			base.Options["zIndex"] = value;
			return this;
		}
	}
}
