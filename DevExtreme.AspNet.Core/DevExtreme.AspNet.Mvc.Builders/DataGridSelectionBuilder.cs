namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures runtime selection.</summary>
	public class DataGridSelectionBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridSelectionBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSelectionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can select all rows at once.</summary>
		[Generated]
		public DataGridSelectionBuilder AllowSelectAll(bool value)
		{
			base.Options["allowSelectAll"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can select all rows at once.</summary>
		[Generated]
		public DataGridSelectionBuilder AllowSelectAll(JS value)
		{
			base.Options["allowSelectAll"] = value;
			return this;
		}

		/// <summary>Makes selection deferred.</summary>
		[Generated]
		public DataGridSelectionBuilder Deferred(bool value)
		{
			base.Options["deferred"] = value;
			return this;
		}

		/// <summary>Makes selection deferred.</summary>
		[Generated]
		public DataGridSelectionBuilder Deferred(JS value)
		{
			base.Options["deferred"] = value;
			return this;
		}

		/// <summary>Specifies the selection mode.</summary>
		[Generated]
		public DataGridSelectionBuilder Mode(SelectionMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies the mode in which all the records are selected. Applies only if selection.allowSelectAll is true.</summary>
		[Generated]
		public DataGridSelectionBuilder SelectAllMode(SelectAllMode value)
		{
			base.Options["selectAllMode"] = value;
			return this;
		}

		/// <summary>Specifies when to display check boxes in rows. Applies only if selection.mode is "multiple".</summary>
		[Generated]
		public DataGridSelectionBuilder ShowCheckBoxesMode(GridSelectionShowCheckBoxesMode value)
		{
			base.Options["showCheckBoxesMode"] = value;
			return this;
		}
	}
}
