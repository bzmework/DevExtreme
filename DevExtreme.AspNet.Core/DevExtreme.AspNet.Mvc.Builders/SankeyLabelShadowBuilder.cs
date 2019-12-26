namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the labels' shadows.</summary>
	public class SankeyLabelShadowBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLabelShadowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shadows' blur distance. A larger value increases the blur distance.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Blur(double value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Specifies the shadows' blur distance. A larger value increases the blur distance.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Blur(JS value)
		{
			base.Options["blur"] = value;
			return this;
		}

		/// <summary>Colors the labels' shadows.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the labels' shadows.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally from their initial positions.</summary>
		[Generated]
		public SankeyLabelShadowBuilder OffsetX(double value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows horizontally from their initial positions.</summary>
		[Generated]
		public SankeyLabelShadowBuilder OffsetX(JS value)
		{
			base.Options["offsetX"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically from their initial positions.</summary>
		[Generated]
		public SankeyLabelShadowBuilder OffsetY(double value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Moves the shadows vertically from their initial positions.</summary>
		[Generated]
		public SankeyLabelShadowBuilder OffsetY(JS value)
		{
			base.Options["offsetY"] = value;
			return this;
		}

		/// <summary>Specifies the shadows' transparency.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the shadows' transparency.</summary>
		[Generated]
		public SankeyLabelShadowBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}
	}
}
