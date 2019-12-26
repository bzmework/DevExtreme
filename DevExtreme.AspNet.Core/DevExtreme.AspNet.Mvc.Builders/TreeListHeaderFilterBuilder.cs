using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the header filter feature.</summary>
	public class TreeListHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu that contains values for filtering.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu that contains values for filtering.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Contains options that specify text for various elements of the popup menu.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Texts(Action<TreeListHeaderFilterTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Indicates whether header filter icons are visible.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether header filter icons are visible.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu that contains values for filtering.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu that contains values for filtering.</summary>
		[Generated]
		public TreeListHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
