using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of groups in the selected state.</summary>
	public class TreeMapGroupSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the group borders in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBuilder Border(Action<TreeMapGroupSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the group headers in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group headers in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}
	}
}
