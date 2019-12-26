namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the delay of submenu show and hiding.</summary>
	public class ContextMenuShowSubmenuModeDelayBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder Hide(double value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is hidden.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder Hide(JS value)
		{
			base.Options["hide"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder Show(double value)
		{
			base.Options["show"] = value;
			return this;
		}

		/// <summary>The time span after which the submenu is shown.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeDelayBuilder Show(JS value)
		{
			base.Options["show"] = value;
			return this;
		}
	}
}
