using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of submenu showing and hiding.</summary>
	public class ContextMenuShowSubmenuModeBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ContextMenuShowSubmenuModeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeBuilder Delay(Action<ContextMenuShowSubmenuModeDelayBuilder> configurator)
		{
			NestedOptions("delay", configurator);
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the delay of submenu show and hiding.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the mode name.</summary>
		[Generated]
		public ContextMenuShowSubmenuModeBuilder Name(ShowSubmenuMode value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
