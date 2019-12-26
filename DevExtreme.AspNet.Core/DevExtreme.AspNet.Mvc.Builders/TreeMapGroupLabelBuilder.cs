using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the group labels.</summary>
	public class TreeMapGroupLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the font settings of the group labels.</summary>
		[Generated]
		public TreeMapGroupLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies what to do with labels that overflow their group headers: hide, truncated them with ellipsis, or leave them as they are.</summary>
		[Generated]
		public TreeMapGroupLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Changes the visibility of the group labels.</summary>
		[Generated]
		public TreeMapGroupLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Changes the visibility of the group labels.</summary>
		[Generated]
		public TreeMapGroupLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
