namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Applies hatching to a node when it is hovered over or pressed.</summary>
	public class SankeyNodeHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' direction.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' transparency.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' transparency.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels between two hatching lines.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance in pixels between two hatching lines.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width.</summary>
		[Generated]
		public SankeyNodeHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
