using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the context menu's settings.</summary>
	public class DiagramContextMenuBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramContextMenuBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramContextMenuBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Lists commands in the context menu.</summary>
		[Generated]
		public DiagramContextMenuBuilder Commands(IEnumerable<DiagramContextMenuCommand> value)
		{
			base.Options["commands"] = value;
			return this;
		}

		/// <summary>Specifies whether the context menu is enabled.</summary>
		[Generated]
		public DiagramContextMenuBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the context menu is enabled.</summary>
		[Generated]
		public DiagramContextMenuBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}
	}
}
