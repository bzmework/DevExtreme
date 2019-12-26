using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a funnel item's appearance when a user selects it.</summary>
	public class FunnelItemSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelItemSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelItemSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures a funnel item's border appearance when a user selects this item.</summary>
		[Generated]
		public FunnelItemSelectionStyleBuilder Border(Action<FunnelItemSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Applies hatching to a selected funnel item.</summary>
		[Generated]
		public FunnelItemSelectionStyleBuilder Hatching(Action<FunnelItemSelectionStyleHatchingBuilder> configurator)
		{
			NestedOptions("hatching", configurator);
			return this;
		}
	}
}
