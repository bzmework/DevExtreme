namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's shadow.</summary>
	public class ChartTooltipShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartTooltipShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public ChartTooltipShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public ChartTooltipShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public ChartTooltipShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public ChartTooltipShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public ChartTooltipShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
