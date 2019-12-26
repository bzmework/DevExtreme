namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the delay in submenu showing and hiding.</summary>
	public class MenuShowFirstSubmenuModeDelayBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder Hide(double value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder Hide(JS value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder Show(double value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public MenuShowFirstSubmenuModeDelayBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}
	}
}
