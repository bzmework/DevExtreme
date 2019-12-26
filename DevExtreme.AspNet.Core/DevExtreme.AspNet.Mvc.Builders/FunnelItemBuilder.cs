using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures funnel items' appearance.</summary>
	public class FunnelItemBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures a funnel item's border.</summary>
		[Generated]
		public FunnelItemBuilder Border(Action<FunnelItemBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Configures a funnel item's appearance when a user presses the item or hovers the mouse pointer over it.</summary>
		[Generated]
		public FunnelItemBuilder HoverStyle(Action<FunnelItemHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Configures a funnel item's appearance when a user selects it.</summary>
		[Generated]
		public FunnelItemBuilder SelectionStyle(Action<FunnelItemSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}
	}
}
