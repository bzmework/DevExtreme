using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures tooltips - small pop-up rectangles that display information about a data-visualizing widget element being pressed or hovered over with the mouse pointer.</summary>
	public class SankeyTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public SankeyTooltipBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public SankeyTooltipBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's border.</summary>
		[Generated]
		public SankeyTooltipBuilder Border(Action<SankeyTooltipBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public SankeyTooltipBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public SankeyTooltipBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public SankeyTooltipBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public SankeyTooltipBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public SankeyTooltipBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public SankeyTooltipBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Customizes link tooltips' appearance.</summary>
		[Generated]
		public SankeyTooltipBuilder CustomizeLinkTooltip(string jsFunc)
		{
			AssignJS("customizeLinkTooltip", jsFunc);
			return this;
		}

		/// <summary>Customizes link tooltips' appearance.</summary>
		[Generated]
		public SankeyTooltipBuilder CustomizeLinkTooltip(RazorBlock jsFunc)
		{
			return CustomizeLinkTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Customizes node tooltips' appearance.</summary>
		[Generated]
		public SankeyTooltipBuilder CustomizeNodeTooltip(string jsFunc)
		{
			AssignJS("customizeNodeTooltip", jsFunc);
			return this;
		}

		/// <summary>Customizes node tooltips' appearance.</summary>
		[Generated]
		public SankeyTooltipBuilder CustomizeNodeTooltip(RazorBlock jsFunc)
		{
			return CustomizeNodeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public SankeyTooltipBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public SankeyTooltipBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' font options.</summary>
		[Generated]
		public SankeyTooltipBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for a link's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder LinkTooltipTemplate(string templateContent)
		{
			AssignTemplate("linkTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a link's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder LinkTooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("linkTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a link's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder LinkTooltipTemplate(TemplateName name)
		{
			AssignTemplate("linkTooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for a link's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder LinkTooltipTemplate(JS value)
		{
			base.Options["linkTooltipTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for a node's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder NodeTooltipTemplate(string templateContent)
		{
			AssignTemplate("nodeTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a node's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder NodeTooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("nodeTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for a node's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder NodeTooltipTemplate(TemplateName name)
		{
			AssignTemplate("nodeTooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for a node's tooltip.</summary>
		[Generated]
		public SankeyTooltipBuilder NodeTooltipTemplate(JS value)
		{
			base.Options["nodeTooltipTemplate"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public SankeyTooltipBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public SankeyTooltipBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public SankeyTooltipBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public SankeyTooltipBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public SankeyTooltipBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public SankeyTooltipBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's shadow.</summary>
		[Generated]
		public SankeyTooltipBuilder Shadow(Action<SankeyTooltipShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public SankeyTooltipBuilder ZIndex(int value)
		{
			base.Options["zIndex"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public SankeyTooltipBuilder ZIndex(JS value)
		{
			base.Options["zIndex"] = value;
			return this;
		}
	}
}
