namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the annotation's shadows.</summary>
	public class ChartAnnotationConfigShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartAnnotationConfigShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of the shadows. A larger value increases the blur distance.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the blur distance of the shadows. A larger value increases the blur distance.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors the annotation's shadows.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the annotation's shadows.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the shadows.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the shadows.</summary>
		[Generated]
		public ChartAnnotationConfigShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
