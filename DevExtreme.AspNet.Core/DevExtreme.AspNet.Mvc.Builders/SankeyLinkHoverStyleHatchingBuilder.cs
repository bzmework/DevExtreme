namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Applies hatching to a link when it is hovered over or pressed.</summary>
	public class SankeyLinkHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' direction.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' transparency.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' transparency.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels between two hatching lines.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels between two hatching lines.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width.</summary>
		[Generated]
		public SankeyLinkHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
