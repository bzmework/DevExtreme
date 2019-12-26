namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures keyboard navigation.</summary>
	public class DataGridKeyboardNavigationBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridKeyboardNavigationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether users can enter a new cell value on a key press. Applies if editing.mode is "cell" or "batch".</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder EditOnKeyPress(bool value)
		{
			base.Options["editOnKeyPress"] = value;
			return this;
		}

		/// <summary>Specifies whether users can enter a new cell value on a key press. Applies if editing.mode is "cell" or "batch".</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder EditOnKeyPress(JS value)
		{
			base.Options["editOnKeyPress"] = value;
			return this;
		}

		/// <summary>Enables keyboard navigation.</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables keyboard navigation.</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the Enter key switches the cell to the editing state or moves focus in the enterKeyDirection. Applies if editing.mode is "cell" or "batch".</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder EnterKeyAction(GridEnterKeyAction value)
		{
			base.Options["enterKeyAction"] = value;
			return this;
		}

		/// <summary>Specifies the direction in which to move focus when a user presses Enter. Applies if editing.mode is "cell" or "batch".</summary>
		[Generated]
		public DataGridKeyboardNavigationBuilder EnterKeyDirection(GridEnterKeyDirection value)
		{
			base.Options["enterKeyDirection"] = value;
			return this;
		}
	}
}
