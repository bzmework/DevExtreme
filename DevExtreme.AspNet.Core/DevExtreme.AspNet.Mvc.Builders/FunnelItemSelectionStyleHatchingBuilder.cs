namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Applies hatching to a selected funnel item.</summary>
	public class FunnelItemSelectionStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies hatching line direction.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies hatching line transparency.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies hatching line transparency.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies hatching line width in pixels.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies hatching line width in pixels.</summary>
		[Generated]
		public FunnelItemSelectionStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
