namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's shadow.</summary>
	public class BarGaugeTooltipShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeTooltipShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public BarGaugeTooltipShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
