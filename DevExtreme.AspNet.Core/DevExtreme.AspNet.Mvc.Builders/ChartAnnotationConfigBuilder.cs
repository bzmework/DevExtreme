using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class ChartAnnotationConfigBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ChartAnnotationConfigBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether users can drag and drop the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder AllowDragging(bool value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Specifies whether users can drag and drop the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder AllowDragging(JS value)
		{
			base.Options["allowDragging"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Argument(DateTime value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Argument(double value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Argument(string value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a specific argument.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Argument(JS value)
		{
			base.Options["argument"] = value;
			return this;
		}

		/// <summary>Specifies the length of the annotation's arrow in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of the annotation's arrow in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's arrow at its junction with the annotation rectangle.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder ArrowWidth(double value)
		{
			base.Options["arrowWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's arrow at its junction with the annotation rectangle.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder ArrowWidth(JS value)
		{
			base.Options["arrowWidth"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis on which the value is specified. Useful for a multi-axis chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Axis(string value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Specifies the name of the value axis on which the value is specified. Useful for a multi-axis chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Axis(JS value)
		{
			base.Options["axis"] = value;
			return this;
		}

		/// <summary>Configures the appearance of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Border(Action<ChartAnnotationConfigBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies the color that fills the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color that fills the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Customizes the text and appearance of the annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder CustomizeTooltip(string jsFunc)
		{
			AssignJS("customizeTooltip", jsFunc);
			return this;
		}

		/// <summary>Customizes the text and appearance of the annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder CustomizeTooltip(RazorBlock jsFunc)
		{
			return CustomizeTooltip(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A container for custom data.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Data(object value)
		{
			base.Options["data"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's description displayed in the tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Description(string value)
		{
			base.Options["description"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's description displayed in the tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Description(JS value)
		{
			base.Options["description"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's font options. Applies only to text annotations.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the annotation's height in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's height in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Image(Action<ChartAnnotationConfigImageBuilder> configurator)
		{
			NestedOptions("image", configurator);
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Image(string value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Image(JS value)
		{
			base.Options["image"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's name.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's name.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Moves the annotation horizontally.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the annotation horizontally.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the annotation vertically.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Moves the annotation vertically.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's opacity.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's opacity.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Along with paddingTopBottom, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Along with paddingTopBottom, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Along with paddingLeftRight, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Along with paddingLeftRight, generates an empty space around the annotation's text or image; specified in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Anchors the annotation to a series point. Accepts the name of the point's series.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Series(string value)
		{
			base.Options["series"] = value;
			return this;
		}

		/// <summary>Anchors the annotation to a series point. Accepts the name of the point's series.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Series(JS value)
		{
			base.Options["series"] = value;
			return this;
		}

		/// <summary>Configures the annotation's shadows.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Shadow(Action<ChartAnnotationConfigShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom template for the annotation.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's text. Applies only if the type is "text".</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's text. Applies only if the type is "text".</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the annotation's text when it overflows the allocated space after applying wordWrap: hide, truncate it and display an ellipsis, or do nothing.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation tooltip is enabled.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipEnabled(bool value)
		{
			base.Options["tooltipEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation tooltip is enabled.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipEnabled(JS value)
		{
			base.Options["tooltipEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipTemplate(string templateContent)
		{
			AssignTemplate("tooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("tooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipTemplate(TemplateName name)
		{
			AssignTemplate("tooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for an annotation's tooltip.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder TooltipTemplate(JS value)
		{
			base.Options["tooltipTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the annotation displays a text or an image. This is a required setting.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Type(AnnotationType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Value(DateTime value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Value(double value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Positions the annotation relative to a value on the specified value axis.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's width in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the annotation's width in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the annotation's text if it does not fit into a single line.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}

		/// <summary>Along with y, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder X(double value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Along with y, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder X(JS value)
		{
			base.Options["x"] = value;
			return this;
		}

		/// <summary>Along with x, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Y(double value)
		{
			base.Options["y"] = value;
			return this;
		}

		/// <summary>Along with x, positions the annotation's center at a specific pixel coordinate. (0, 0) is the upper left corner of the chart.</summary>
		[Generated]
		public ChartAnnotationConfigBuilder Y(JS value)
		{
			base.Options["y"] = value;
			return this;
		}
	}
}
