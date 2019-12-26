namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the annotation's shadows.</summary>
	public class ChartCommonAnnotationConfigShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of the shadows. A larger value increases the blur distance.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of the shadows. A larger value increases the blur distance.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors the annotation's shadows.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the annotation's shadows.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the shadows.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the shadows.</summary>
		[Generated]
		public ChartCommonAnnotationConfigShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
