namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify texts for editing-related UI elements.</summary>
	public class DataGridEditingTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridEditingTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridEditingTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Add" button. Applies only if editing.allowAdding is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder AddRow(string value)
		{
			base.Options["addRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Add" button. Applies only if editing.allowAdding is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder AddRow(JS value)
		{
			base.Options["addRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the "Discard" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder CancelAllChanges(string value)
		{
			base.Options["cancelAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the "Discard" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder CancelAllChanges(JS value)
		{
			base.Options["cancelAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that cancels changes in a row. Applies only if editing.allowUpdating is true and editing.mode is "row".</summary>
		[Generated]
		public DataGridEditingTextsBuilder CancelRowChanges(string value)
		{
			base.Options["cancelRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that cancels changes in a row. Applies only if editing.allowUpdating is true and editing.mode is "row".</summary>
		[Generated]
		public DataGridEditingTextsBuilder CancelRowChanges(JS value)
		{
			base.Options["cancelRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies a message that prompts a user to confirm deletion.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ConfirmDeleteMessage(string value)
		{
			base.Options["confirmDeleteMessage"] = value;
			return this;
		}

		/// <summary>Specifies a message that prompts a user to confirm deletion.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ConfirmDeleteMessage(JS value)
		{
			base.Options["confirmDeleteMessage"] = value;
			return this;
		}

		/// <summary>Specifies a title for the window that asks a user to confirm deletion.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ConfirmDeleteTitle(string value)
		{
			base.Options["confirmDeleteTitle"] = value;
			return this;
		}

		/// <summary>Specifies a title for the window that asks a user to confirm deletion.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ConfirmDeleteTitle(JS value)
		{
			base.Options["confirmDeleteTitle"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that delete rows. Applies only if allowDeleting is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder DeleteRow(string value)
		{
			base.Options["deleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that delete rows. Applies only if allowDeleting is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder DeleteRow(JS value)
		{
			base.Options["deleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that switch rows into the editing state. Applies only if allowUpdating is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder EditRow(string value)
		{
			base.Options["editRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that switch rows into the editing state. Applies only if allowUpdating is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder EditRow(JS value)
		{
			base.Options["editRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Save" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder SaveAllChanges(string value)
		{
			base.Options["saveAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Save" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder SaveAllChanges(JS value)
		{
			base.Options["saveAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that saves changes made in a row. Applies only if allowUpdating is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder SaveRowChanges(string value)
		{
			base.Options["saveRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that saves changes made in a row. Applies only if allowUpdating is true.</summary>
		[Generated]
		public DataGridEditingTextsBuilder SaveRowChanges(JS value)
		{
			base.Options["saveRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that recover deleted rows. Applies only if allowDeleting is true and editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder UndeleteRow(string value)
		{
			base.Options["undeleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that recover deleted rows. Applies only if allowDeleting is true and editing.mode is "batch".</summary>
		[Generated]
		public DataGridEditingTextsBuilder UndeleteRow(JS value)
		{
			base.Options["undeleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint appearing when a user pauses on the button that cancels changes in a cell. Applies only if editing.mode is "cell" and data validation is enabled.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ValidationCancelChanges(string value)
		{
			base.Options["validationCancelChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint appearing when a user pauses on the button that cancels changes in a cell. Applies only if editing.mode is "cell" and data validation is enabled.</summary>
		[Generated]
		public DataGridEditingTextsBuilder ValidationCancelChanges(JS value)
		{
			base.Options["validationCancelChanges"] = value;
			return this;
		}
	}
}
