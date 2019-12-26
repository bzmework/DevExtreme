namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify texts for editing-related UI elements.</summary>
	public class TreeListEditingTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListEditingTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListEditingTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Add" button. Applies only if editing.allowAdding is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder AddRow(string value)
		{
			base.Options["addRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Add" button. Applies only if editing.allowAdding is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder AddRow(JS value)
		{
			base.Options["addRow"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that adds a new nested row. Applies if the editing.mode is "batch" or "cell".</summary>
		[Generated]
		public TreeListEditingTextsBuilder AddRowToNode(string value)
		{
			base.Options["addRowToNode"] = value;
			return this;
		}

		/// <summary>Specifies text for the button that adds a new nested row. Applies if the editing.mode is "batch" or "cell".</summary>
		[Generated]
		public TreeListEditingTextsBuilder AddRowToNode(JS value)
		{
			base.Options["addRowToNode"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the "Discard" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder CancelAllChanges(string value)
		{
			base.Options["cancelAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the "Discard" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder CancelAllChanges(JS value)
		{
			base.Options["cancelAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that cancels changes in a row. Applies only if editing.allowUpdating is true and editing.mode is "row".</summary>
		[Generated]
		public TreeListEditingTextsBuilder CancelRowChanges(string value)
		{
			base.Options["cancelRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that cancels changes in a row. Applies only if editing.allowUpdating is true and editing.mode is "row".</summary>
		[Generated]
		public TreeListEditingTextsBuilder CancelRowChanges(JS value)
		{
			base.Options["cancelRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies a message that prompts a user to confirm deletion.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ConfirmDeleteMessage(string value)
		{
			base.Options["confirmDeleteMessage"] = value;
			return this;
		}

		/// <summary>Specifies a message that prompts a user to confirm deletion.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ConfirmDeleteMessage(JS value)
		{
			base.Options["confirmDeleteMessage"] = value;
			return this;
		}

		/// <summary>Specifies a title for the window that asks a user to confirm deletion.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ConfirmDeleteTitle(string value)
		{
			base.Options["confirmDeleteTitle"] = value;
			return this;
		}

		/// <summary>Specifies a title for the window that asks a user to confirm deletion.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ConfirmDeleteTitle(JS value)
		{
			base.Options["confirmDeleteTitle"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that delete rows. Applies only if allowDeleting is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder DeleteRow(string value)
		{
			base.Options["deleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that delete rows. Applies only if allowDeleting is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder DeleteRow(JS value)
		{
			base.Options["deleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that switch rows into the editing state. Applies only if allowUpdating is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder EditRow(string value)
		{
			base.Options["editRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that switch rows into the editing state. Applies only if allowUpdating is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder EditRow(JS value)
		{
			base.Options["editRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Save" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder SaveAllChanges(string value)
		{
			base.Options["saveAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the global "Save" button. Applies only if editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder SaveAllChanges(JS value)
		{
			base.Options["saveAllChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that saves changes made in a row. Applies only if allowUpdating is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder SaveRowChanges(string value)
		{
			base.Options["saveRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a button that saves changes made in a row. Applies only if allowUpdating is true.</summary>
		[Generated]
		public TreeListEditingTextsBuilder SaveRowChanges(JS value)
		{
			base.Options["saveRowChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that recover deleted rows. Applies only if allowDeleting is true and editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder UndeleteRow(string value)
		{
			base.Options["undeleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for buttons that recover deleted rows. Applies only if allowDeleting is true and editing.mode is "batch".</summary>
		[Generated]
		public TreeListEditingTextsBuilder UndeleteRow(JS value)
		{
			base.Options["undeleteRow"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint appearing when a user pauses on the button that cancels changes in a cell. Applies only if editing.mode is "cell" and data validation is enabled.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ValidationCancelChanges(string value)
		{
			base.Options["validationCancelChanges"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint appearing when a user pauses on the button that cancels changes in a cell. Applies only if editing.mode is "cell" and data validation is enabled.</summary>
		[Generated]
		public TreeListEditingTextsBuilder ValidationCancelChanges(JS value)
		{
			base.Options["validationCancelChanges"] = value;
			return this;
		}
	}
}
