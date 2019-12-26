using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of submenu showing and hiding.</summary>
	public class MenuShowSubmenuModeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MenuShowSubmenuModeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuShowSubmenuModeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public MenuShowSubmenuModeBuilder Delay(Action<MenuShowSubmenuModeDelayBuilder> configurator)
		{
			NestedOptions("delay", configurator);
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public MenuShowSubmenuModeBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public MenuShowSubmenuModeBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the mode name.</summary>
		[Generated]
		public MenuShowSubmenuModeBuilder Name(ShowSubmenuMode value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
