using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a funnel item's appearance when a user presses the item or hovers the mouse pointer over it.</summary>
	public class FunnelItemHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures a funnel item's border appearance when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBuilder Border(Action<FunnelItemHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Applies hatching to a funnel item when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemHoverStyleBuilder Hatching(Action<FunnelItemHoverStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
