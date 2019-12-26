namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the column chooser.</summary>
	public class TreeListColumnChooserBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListColumnChooserBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the column chooser when it is empty.</summary>
		[Generated]
		public TreeListColumnChooserBuilder EmptyPanelText(string value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the column chooser when it is empty.</summary>
		[Generated]
		public TreeListColumnChooserBuilder EmptyPanelText(JS value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the height of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies how a user manages columns using the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Mode(GridColumnChooserMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the column chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public TreeListColumnChooserBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the column chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public TreeListColumnChooserBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the title of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the title of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the width of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the column chooser.</summary>
		[Generated]
		public TreeListColumnChooserBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
