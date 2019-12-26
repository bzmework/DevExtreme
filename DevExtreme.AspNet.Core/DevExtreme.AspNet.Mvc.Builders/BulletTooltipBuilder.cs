using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the tooltip.</summary>
	public class BulletTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BulletTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BulletTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public BulletTooltipBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public BulletTooltipBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's border.</summary>
		[Generated]
		public BulletTooltipBuilder Border(Action<BulletTooltipBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public BulletTooltipBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public BulletTooltipBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public BulletTooltipBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public BulletTooltipBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Allows you to change tooltip appearance.</summary>
		[Generated]
		public BulletTooltipBuilder CustomizeTooltip(string jsFunc)
		{
			AssignJS("customizeTooltip", jsFunc);
			return this;
		}

		/// <summary>Allows you to change tooltip appearance.</summary>
		[Generated]
		public BulletTooltipBuilder CustomizeTooltip(RazorBlock jsFunc)
		{
			return CustomizeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public BulletTooltipBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' font options.</summary>
		[Generated]
		public BulletTooltipBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public BulletTooltipBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public BulletTooltipBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public BulletTooltipBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public BulletTooltipBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public BulletTooltipBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public BulletTooltipBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public BulletTooltipBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public BulletTooltipBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public BulletTooltipBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public BulletTooltipBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's shadow.</summary>
		[Generated]
		public BulletTooltipBuilder Shadow(Action<BulletTooltipShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public BulletTooltipBuilder ZIndex(int value)
		{
			base.Options["zIndex"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public BulletTooltipBuilder ZIndex(JS value)
		{
			base.Options["zIndex"] = value;
			return this;
		}
	}
}
