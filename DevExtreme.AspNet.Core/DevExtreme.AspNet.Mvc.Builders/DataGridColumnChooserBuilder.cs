namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the column chooser.</summary>
	public class DataGridColumnChooserBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridColumnChooserBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder AllowSearch(bool value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether searching is enabled in the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder AllowSearch(JS value)
		{
			base.Options["allowSearch"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the column chooser when it is empty.</summary>
		[Generated]
		public DataGridColumnChooserBuilder EmptyPanelText(string value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies text displayed by the column chooser when it is empty.</summary>
		[Generated]
		public DataGridColumnChooserBuilder EmptyPanelText(JS value)
		{
			base.Options["emptyPanelText"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the height of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies how a user manages columns using the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Mode(GridColumnChooserMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the column chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public DataGridColumnChooserBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies a delay in milliseconds between when a user finishes typing in the column chooser's search panel, and when the search is executed.</summary>
		[Generated]
		public DataGridColumnChooserBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the title of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the title of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the width of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the column chooser.</summary>
		[Generated]
		public DataGridColumnChooserBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
