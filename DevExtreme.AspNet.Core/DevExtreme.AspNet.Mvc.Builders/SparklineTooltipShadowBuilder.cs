namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's shadow.</summary>
	public class SparklineTooltipShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SparklineTooltipShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public SparklineTooltipShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
