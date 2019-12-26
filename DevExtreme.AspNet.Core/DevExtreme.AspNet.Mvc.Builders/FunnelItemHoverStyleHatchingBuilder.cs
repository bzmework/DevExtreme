namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Applies hatching to a funnel item when a user presses the item or hovers the mouse pointer over it.</summary>
	public class FunnelItemHoverStyleHatchingBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies hatching line direction.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Direction(HatchingDirection value)
		{
			base.Options["direction"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of hatching lines.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of hatching lines.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Step(double value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies the distance between two side-by-side hatching lines in pixels.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Step(JS value)
		{
			base.Options["step"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width in pixels.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies hatching lines' width in pixels.</summary>
		[Generated]
		public FunnelItemHoverStyleHatchingBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
