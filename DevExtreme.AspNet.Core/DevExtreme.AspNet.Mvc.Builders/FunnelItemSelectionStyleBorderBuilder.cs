namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a funnel item's border appearance when a user selects this item.</summary>
	public class FunnelItemSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Shows the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Thickens the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Thickens the selected funnel item's border.</summary>
		[Generated]
		public FunnelItemSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
