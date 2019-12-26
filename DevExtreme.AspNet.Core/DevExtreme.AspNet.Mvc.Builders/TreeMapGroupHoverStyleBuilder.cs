using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of groups in the hover state.</summary>
	public class TreeMapGroupHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the group borders in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBuilder Border(Action<TreeMapGroupHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the group headers in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group headers in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}
	}
}
