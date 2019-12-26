using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Field Chooser configuration options.</summary>
	public class PivotGridFieldChooserBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridFieldChooserBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the field chooser allows searching in the "All Fields" section.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether the field chooser allows searching in the "All Fields" section.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies when to apply changes made in the field chooser to the PivotGrid.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder ApplyChangesMode(ApplyChangesMode value)
		{
			base.Options["applyChangesMode"] = value;
			return this;
		}

		/// <summary>Enables or disables the field chooser.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables or disables the field chooser.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the field chooser height.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the field chooser height.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the field chooser layout.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Layout(PivotGridFieldChooserLayout value)
		{
			base.Options["layout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the field chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the field chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Strings that can be changed or localized in the pivot grid's integrated Field Chooser.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Texts(Action<PivotGridFieldChooserTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies the text to display as a title of the field chooser popup window.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the text to display as a title of the field chooser popup window.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the field chooser width.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the field chooser width.</summary>
		[Generated]
		public PivotGridFieldChooserBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
