namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's shadow.</summary>
	public class SankeyTooltipShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyTooltipShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of a tooltip's shadow. The larger the value, the blurrier the shadow's edge.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's shadow.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the horizontal offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the vertical offset of a tooltip's shadow relative to the tooltip itself. Measured in pixels.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's shadow.</summary>
		[Generated]
		public SankeyTooltipShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
