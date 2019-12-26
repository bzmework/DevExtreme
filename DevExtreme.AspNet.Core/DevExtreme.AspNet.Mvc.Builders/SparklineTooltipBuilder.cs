using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the tooltip.</summary>
	public class SparklineTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SparklineTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SparklineTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public SparklineTooltipBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of a tooltip's arrow in pixels.</summary>
		[Generated]
		public SparklineTooltipBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBuilder Border(Action<SparklineTooltipBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors all tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public SparklineTooltipBuilder Container(string value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies the container in which to draw tooltips. The default container is the HTML DOM `` element.</summary>
		[Generated]
		public SparklineTooltipBuilder Container(JS value)
		{
			base.Options["container"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder ContentTemplate(string templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder ContentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("contentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder ContentTemplate(TemplateName name)
		{
			AssignTemplate("contentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder ContentTemplate(JS value)
		{
			base.Options["contentTemplate"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public SparklineTooltipBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes all the tooltip's corners rounded.</summary>
		[Generated]
		public SparklineTooltipBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Allows you to change tooltip appearance.</summary>
		[Generated]
		public SparklineTooltipBuilder CustomizeTooltip(string jsFunc)
		{
			AssignJS("customizeTooltip", jsFunc);
			return this;
		}

		/// <summary>Allows you to change tooltip appearance.</summary>
		[Generated]
		public SparklineTooltipBuilder CustomizeTooltip(RazorBlock jsFunc)
		{
			return CustomizeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables tooltips.</summary>
		[Generated]
		public SparklineTooltipBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' font options.</summary>
		[Generated]
		public SparklineTooltipBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SparklineTooltipBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SparklineTooltipBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SparklineTooltipBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats a value before it is displayed it in a tooltip.</summary>
		[Generated]
		public SparklineTooltipBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public SparklineTooltipBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies tooltips' transparency.</summary>
		[Generated]
		public SparklineTooltipBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public SparklineTooltipBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's left/right border and its text.</summary>
		[Generated]
		public SparklineTooltipBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public SparklineTooltipBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates an empty space, measured in pixels, between a tooltip's top/bottom border and its text.</summary>
		[Generated]
		public SparklineTooltipBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Configures a tooltip's shadow.</summary>
		[Generated]
		public SparklineTooltipBuilder Shadow(Action<SparklineTooltipShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public SparklineTooltipBuilder ZIndex(int value)
		{
			base.Options["zIndex"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's z-index.</summary>
		[Generated]
		public SparklineTooltipBuilder ZIndex(JS value)
		{
			base.Options["zIndex"] = value;
			return this;
		}
	}
}
