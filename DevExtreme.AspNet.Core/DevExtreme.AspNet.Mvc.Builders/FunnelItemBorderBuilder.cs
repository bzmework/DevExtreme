namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a funnel item's border.</summary>
	public class FunnelItemBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors a funnel item's border.</summary>
		[Generated]
		public FunnelItemBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a funnel item's border.</summary>
		[Generated]
		public FunnelItemBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes a funnel item's border visible.</summary>
		[Generated]
		public FunnelItemBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes a funnel item's border visible.</summary>
		[Generated]
		public FunnelItemBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets the width of a funnel item's border in pixels.</summary>
		[Generated]
		public FunnelItemBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets the width of a funnel item's border in pixels.</summary>
		[Generated]
		public FunnelItemBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
