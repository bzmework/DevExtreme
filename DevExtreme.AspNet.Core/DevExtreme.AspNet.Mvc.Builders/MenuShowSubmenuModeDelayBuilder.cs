namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the delay of submenu show and hiding.</summary>
	public class MenuShowSubmenuModeDelayBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MenuShowSubmenuModeDelayBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MenuShowSubmenuModeDelayBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public MenuShowSubmenuModeDelayBuilder Hide(double value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public MenuShowSubmenuModeDelayBuilder Hide(JS value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public MenuShowSubmenuModeDelayBuilder Show(double value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public MenuShowSubmenuModeDelayBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}
	}
}
