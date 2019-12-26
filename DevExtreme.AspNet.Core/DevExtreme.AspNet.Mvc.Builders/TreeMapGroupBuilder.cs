using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures groups.</summary>
	public class TreeMapGroupBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the group borders.</summary>
		[Generated]
		public TreeMapGroupBuilder Border(Action<TreeMapGroupBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors the group headers.</summary>
		[Generated]
		public TreeMapGroupBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group headers.</summary>
		[Generated]
		public TreeMapGroupBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the height of the group headers in pixels.</summary>
		[Generated]
		public TreeMapGroupBuilder HeaderHeight(double value)
		{
			base.Options["headerHeight"] = value;
			return this;
		}

		/// <summary>Specifies the height of the group headers in pixels.</summary>
		[Generated]
		public TreeMapGroupBuilder HeaderHeight(JS value)
		{
			base.Options["headerHeight"] = value;
			return this;
		}

		/// <summary>Specifies whether groups change their style when a user pauses on them.</summary>
		[Generated]
		public TreeMapGroupBuilder HoverEnabled(bool value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether groups change their style when a user pauses on them.</summary>
		[Generated]
		public TreeMapGroupBuilder HoverEnabled(JS value)
		{
			base.Options["hoverEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the appearance of groups in the hover state.</summary>
		[Generated]
		public TreeMapGroupBuilder HoverStyle(Action<TreeMapGroupHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Configures the group labels.</summary>
		[Generated]
		public TreeMapGroupBuilder Label(Action<TreeMapGroupLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of groups in the selected state.</summary>
		[Generated]
		public TreeMapGroupBuilder SelectionStyle(Action<TreeMapGroupSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}
	}
}
