using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for showing and hiding the first level submenu.</summary>
	public class MenuShowFirstSubmenuModeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MenuShowFirstSubmenuModeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the delay in submenu showing and hiding.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeBuilder Delay(Action<MenuShowFirstSubmenuModeDelayBuilder> configurator)
		{
			NestedOptions("delay", configurator);
			return this;
		}

		/// <summary>Specifies the delay in submenu showing and hiding.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the delay in submenu showing and hiding.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the mode name.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeBuilder Name(ShowSubmenuMode value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
