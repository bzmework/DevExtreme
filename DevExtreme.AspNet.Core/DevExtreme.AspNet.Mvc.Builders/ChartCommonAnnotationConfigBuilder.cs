using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class ChartCommonAnnotationConfigBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAnnotationConfigBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether users can drag and drop the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder AllowDragging(bool value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Specifies whether users can drag and drop the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder AllowDragging(JS value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Argument(DateTime value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Argument(double value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Argument(string value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Argument(JS value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Specifies the length of the annotation's arrow in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the annotation's arrow in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's arrow at its junction with the annotation rectangle.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder ArrowWidth(double value)
		{
			base.Options["arrowWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's arrow at its junction with the annotation rectangle.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder ArrowWidth(JS value)
		{
			base.Options["arrowWidth"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis on which the value is specified. Useful for a multi-axis chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Axis(string value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis on which the value is specified. Useful for a multi-axis chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Axis(JS value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Configures the appearance of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Border(Action<ChartCommonAnnotationConfigBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color that fills the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color that fills the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Customizes the text and appearance of the annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder CustomizeTooltip(string jsFunc)
		{
			AssignJS("customizeTooltip", jsFunc);
			return this;
		}

		/// <summary>Customizes the text and appearance of the annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder CustomizeTooltip(RazorBlock jsFunc)
		{
			return CustomizeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's description displayed in the tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Description(string value)
		{
			base.Options["description"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's description displayed in the tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Description(JS value)
		{
			base.Options["description"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's font options. Applies only to text annotations.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the annotation's height in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's height in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Image(Action<ChartCommonAnnotationConfigImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Moves the annotation horizontally.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the annotation horizontally.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the annotation vertically.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Moves the annotation vertically.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's opacity.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's opacity.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Along with paddingTopBottom, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Along with paddingTopBottom, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Along with paddingLeftRight, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Along with paddingLeftRight, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Anchors the annotation to a series point. Accepts the name of the point's series.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Series(string value)
		{
			base.Options["series"] = value;
			return this;
		}

		/// <summary>Anchors the annotation to a series point. Accepts the name of the point's series.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Series(JS value)
		{
			base.Options["series"] = value;
			return this;
		}

		/// <summary>Configures the annotation's shadows.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Shadow(Action<ChartCommonAnnotationConfigShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's text. Applies only if the type is "text".</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's text. Applies only if the type is "text".</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the annotation's text when it overflows the allocated space after applying wordWrap: hide, truncate it and display an ellipsis, or do nothing.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation tooltip is enabled.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipEnabled(bool value)
		{
			base.Options["tooltipEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation tooltip is enabled.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipEnabled(JS value)
		{
			base.Options["tooltipEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipTemplate(string templateContent)
		{
			AssignTemplate("tooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("tooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipTemplate(TemplateName name)
		{
			AssignTemplate("tooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder TooltipTemplate(JS value)
		{
			base.Options["tooltipTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation displays a text or an image. This is a required setting.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Type(AnnotationType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Value(DateTime value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's width in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's width in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the annotation's text if it does not fit into a single line.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}

		/// <summary>Along with y, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Along with y, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Along with x, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Along with x, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
