namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a funnel item's border appearance when a user presses the item or hovers the mouse pointer over it.</summary>
	public class FunnelItemHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Shows a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Thickens a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Thickens a funnel item's border when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
