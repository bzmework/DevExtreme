using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the header filter feature.</summary>
	public class PivotGridHeaderFilterBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridHeaderFilterBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the header filter.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the header filter's search panel, and when the search is executed.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies whether to show all field values or only those that satisfy the other applied filters.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder ShowRelevantValues(bool value)
		{
			base.Options["showRelevantValues"] = value;
			return this;
		}

		/// <summary>Specifies whether to show all field values or only those that satisfy the other applied filters.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder ShowRelevantValues(JS value)
		{
			base.Options["showRelevantValues"] = value;
			return this;
		}

		/// <summary>Configures the texts of the popup menu's elements.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Texts(Action<PivotGridHeaderFilterTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the popup menu containing filtering values.</summary>
		[Generated]
		public PivotGridHeaderFilterBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
