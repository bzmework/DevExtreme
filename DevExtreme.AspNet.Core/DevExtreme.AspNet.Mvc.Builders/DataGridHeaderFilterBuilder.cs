using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the header filter feature.</summary>
	public class DataGridHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu that contains values for filtering.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu that contains values for filtering.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Contains options that specify text for various elements of the popup menu.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Texts(Action<DataGridHeaderFilterTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Indicates whether header filter icons are visible.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether header filter icons are visible.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu that contains values for filtering.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu that contains values for filtering.</summary>
		[Generated]
		public DataGridHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
